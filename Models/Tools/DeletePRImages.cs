using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Balimoon_E_Procurement.Models.Tools
{
    public class DeletePRImages
    {
        public string Delete(string picture)
        {
            string hasil = "";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images\\PRImages", picture);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                hasil = "Sukses";
            }
            else
            {
                hasil = "Picture Not Found";
            }
            return hasil;
        }
    }
}
