using ProjectPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ProjectPOS.Interfaces
{
    public interface ICloudStorage
    {
        IEnumerable<ViewModel> GetFiles();
        bool DeleteFile(string file, string fileExtension);
        bool UploadFile(HttpPostedFileBase blobFile);

        Task<bool> DownloadFileAsync(string file, string fileExtension);
    }
}