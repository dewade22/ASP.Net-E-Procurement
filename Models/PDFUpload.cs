using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Balimoon_E_Procurement.Models
{
    public class PDFUpload
    {
        public async Task<string> UploadPDF(IFormFile file)
        {
            try
            {
                if (file != null)
                {
                    // bool isCopied = false;
                    string fileName = "";
                    var rnd = new Random();
                    int rand = rnd.Next(10000, 99999);
                    //1 check if the file length is greater than 0 bytes 
                    if (file.Length > 0)
                    {
                        //2 Get the extension of the file
                        string extension = Path.GetExtension(file.FileName);
                        //random the name
                        fileName = Guid.NewGuid().ToString() + rand.ToString() + extension;

                        //3 check the file extension as png
                        if (extension == ".pdf" || extension == ".docx" || extension == ".doc" || extension ==".zip" || extension == ".rar" || extension == ".7z")
                        {
                            //4 set the path where file will be copied
                            string filePath = Path.GetFullPath(
                                Path.Combine(Directory.GetCurrentDirectory(),
                                                            "wwwroot/VendorData"));
                            //5 copy the file to the path
                            using (var fileStream = new FileStream(
                                Path.Combine(filePath, fileName),
                                               FileMode.Create))


                            {
                                await file.CopyToAsync(fileStream);
                                // isCopied = true;
                            }
                        }
                        else
                        {
                            throw new Exception("File must be either .pdf, .docx, .doc, .zip, or .rar");
                        }
                    }
                    return fileName;
                }
                else
                {
                    string fileName = "";
                    return fileName;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
