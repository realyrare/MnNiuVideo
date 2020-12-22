using System;
using System.Collections.Generic;
using System.Text;

namespace MnNiuVideoApp.Models
{
    public class CameraInfo
    {
        public string FriendlyName { get; internal set; }
        public int Index { get; internal set; }
        public VideoCapabilities[] VideoCapabilities { get; internal set; }
    }
}
