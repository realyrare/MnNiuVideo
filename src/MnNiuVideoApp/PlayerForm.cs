using MnNiuVideoApp;
using MnNiuVideoApp.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MnNiuVideo
{
    public partial class PlayerForm : Form
    {
        public PlayerForm()
        {
            InitializeComponent();
            new NginxProcess().StopService();
            var cameras = CameraUtils.ListCameras();
            if (toolStripComboBox1.ComboBox != null)
            {
                var list = new List<string>() { "--请选择相机--" };
                foreach (var item in cameras)
                {
                    list.Add(item.FriendlyName);
                }
                toolStripComboBox1.ComboBox.DataSource = list;
            }
        }
        TstRtmp rtmp = new TstRtmp();
        Thread thPlayer;
        private void StartPlayStripMenuItem_Click(object sender, EventArgs e)
        {
            StartPlayStripMenuItem.Enabled = false;
            TaskScheduler uiContext = TaskScheduler.FromCurrentSynchronizationContext();
            Task t = Task.Factory.StartNew(() =>
            {
                if (thPlayer != null)
                {
                    rtmp.Stop();
                    thPlayer = null;
                }
                else
                {
                    string path = FileHelper.GetLoadPath();
                    pic.Image = Image.FromFile(path);
                    thPlayer = new Thread(DeCoding)
                    {
                        IsBackground = true
                    };
                    thPlayer.Start();

                    StartPlayStripMenuItem.Text = "停止播放";
                    //StartPlayStripMenuItem.Enabled = true;
                }
            }).ContinueWith(m =>
            {
                StartPlayStripMenuItem.Enabled = true;
                Console.WriteLine("任务结束");
            }, uiContext);

        }

        /// <summary>
        /// 播放线程执行方法
        /// </summary>
        private unsafe void DeCoding()
        {
            try
            {
                Console.WriteLine("DeCoding run...");
                Bitmap oldBmp = null;
                // 更新图片显示
                TstRtmp.ShowBitmap show = (bmp) =>
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        if (this.pic.Image != null)
                        {
                            this.pic.Image = null;
                        }

                        if (bmp != null)
                        {
                            this.pic.Image = bmp;
                        }
                        if (oldBmp != null)
                        {
                            oldBmp.Dispose();
                        }
                        oldBmp = bmp;
                    }));
                };
                //线程间操作无效
                var url = string.Empty;
                this.Invoke(new Action(() =>
                {
                    url = PlayAddressComboBox.Text.Trim();
                }));

                if (string.IsNullOrEmpty(url))
                {
                    MessageBox.Show("播放地址为空!");
                    return;
                }
                rtmp.Start(show, url);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("DeCoding exit");
                rtmp?.Stop();
                thPlayer = null;
                this.Invoke(new MethodInvoker(() =>
                {
                    StartPlayStripMenuItem.Text = "开始播放";
                    StartPlayStripMenuItem.Enabled = true;
                }));
            }
        }




        private void DesktopRecordStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = FileHelper.VideoRecordPath();
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("视频存放文件路径为空");
            }
            string args = $"ffmpeg -f gdigrab -r 24 -offset_x 0 -offset_y 0 -video_size 1920x1080 -i desktop -f dshow -list_devices 0 -i video=\"Integrated Webcam\":audio=\"麦克风(Realtek Audio)\" -filter_complex \"[0:v] scale = 1920x1080[desktop];[1:v] scale = 192x108[webcam];[desktop][webcam] overlay = x = W - w - 50:y = H - h - 50\" -f flv \"rtmp://127.0.0.1:20050/myapp/test\" -map 0 {path}";
            VideoProcess.Run(args);
            StartLiveToolStripMenuItem.Text = "正在直播";
        }

        private void LiveRecordStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = FileHelper.VideoRecordPath();
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("视频存放文件路径为空");
            }
            var args = $" -f dshow -re -i  video=\"Integrated Webcam\" -tune zerolatency -vcodec libx264 -preset ultrafast -b:v 400k -s 704x576 -r 25 -acodec aac -b:a 64k -f flv \"rtmp://127.0.0.1:20050/myapp/test\" -map 0 {path}";
            VideoProcess.Run(args);
            StartLiveToolStripMenuItem.Text = "正在直播";
        }
        /// <summary>
        /// 开始直播（服务端开始推流）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartLiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (toolStripComboBox1.ComboBox != null)
                {
                    string camera = toolStripComboBox1.ComboBox.SelectedText;
                    if (string.IsNullOrEmpty(camera))
                    {
                        MessageBox.Show("请选择要使用的相机");
                        return;
                    }
                    var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Icon");
                    var imgPath = Path.Combine(path + "\\", "stop.jpg");
                    StartLiveToolStripMenuItem.Enabled = false;

                    StartLiveToolStripMenuItem.Image = Image.FromFile(imgPath);
                    string args = $" -f dshow -re -i  video=\"{camera}\" -tune zerolatency -vcodec libx264 -preset ultrafast -b:v 400k -s 704x576 -r 25 -acodec aac -b:a 64k -f flv \"rtmp://127.0.0.1:20050/myapp/test\"";
                    VideoProcess.Run(args);
                }

                StartLiveToolStripMenuItem.Text = "正在直播";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            // if (toolStripComboBox1.ComboBox != null) toolStripComboBox1.ComboBox.SelectedIndex = 0;
        }

        private void PlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void PlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("您是否退出?", "提示:", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dr != DialogResult.OK)
            {
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true; //不执行操作
                }
            }
            else
            {
                new NginxProcess().StopService();
                Application.Exit();
                e.Cancel = false; //关闭窗体
            }
        }
    }
}
