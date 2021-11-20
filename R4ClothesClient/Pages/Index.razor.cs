using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using R4ClothesClient.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace R4ClothesClient.Pages
{
    public partial class Index
    {
        private long maxFileSize = 1024 * 15;
        public string url;
        public string path;
        IList<IBrowserFile> files = new List<IBrowserFile>();
        public async Task Gui()
        {
            
        }

        
        private async Task UploadFiles(InputFileChangeEventArgs e)
        {
            foreach (var item in e.GetMultipleFiles(2))
            {
                files.Add(item);
                url = await _uploadImage.GetUrlImage(item);
            }
            var file = files.FirstOrDefault();
            Console.WriteLine(path);
            Console.WriteLine(file.Name);
            //TODO upload the files to the server
        }
    }
}
