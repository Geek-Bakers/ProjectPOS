using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ProjectPOS.Models
{
    public class ViewModel
    {
        public string ContainerName { get; set; }
        public string StorageUri { get; set; }
        public string FileName { get; set; }
        public string PrimaryUri { get; set; }
        public string fileExtenion { get; set; }

        public string FileNameWithoutExt
        {
            get
            {
                return Path.GetFileNameWithoutExtension(FileName);
            }
        }

        public string FileNameExtensionOnly
        {
            get
            {
                return System.IO.Path.GetExtension(FileName).Substring(1);
            }
        }
    }
}