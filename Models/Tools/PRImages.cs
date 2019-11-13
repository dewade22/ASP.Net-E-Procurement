using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ImageResize;
using System.Drawing;

namespace Balimoon_E_Procurement.Models.Tools
{
    public class PRImages
    {
        public async Task<string> ImagesUpload(IFormFile file)
        {
            try
            {
                if (file != null)
                {
                    string filename = "";
                    var rnd = new Random();
                    int rand = rnd.Next(10, 99999999);
                    if (file.Length > 0 && file.Length < 26214400)
                    {
                        string extension = Path.GetExtension(file.FileName);
                        filename = Guid.NewGuid().ToString() + rand.ToString() + extension;
                        if (extension == ".jpg" || extension == ".png" || extension == ".jpeg" || extension == ".tiff" || extension == ".gif")
                        {
                            string filePath = Path.GetFullPath(
                               Path.Combine(Directory.GetCurrentDirectory(),
                                                           "wwwroot/Images/PRImages"));
                            using (var fileStream = new FileStream(
                                Path.Combine(filePath, filename),
                                               FileMode.Create))
                            {
                                await file.CopyToAsync(fileStream);
                            }
                            var newImg = Image.FromFile("wwwroot\\Images\\PRImages\\" + filename);
                            var scaleImage = ImageResize.Scale(newImg, 800, 800);
                            scaleImage.SaveAs("wwwroot\\Images\\PRImages\\1"+ filename);
                            newImg.Dispose();
                            scaleImage.Dispose();
                            var oldImg = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images\\PRImages", filename);
                            filename = "1" + filename;
                            System.IO.File.Delete(oldImg);


                        }
                        else
                        {
                            throw new Exception("File must be either .jpg, .jpeg, .png and Maximum Size is 2MB");
                        }
                        
                    }
                    return filename;
                }
                else
                {
                    string fileName = "";
                    return fileName;
                }
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        
    }
}
