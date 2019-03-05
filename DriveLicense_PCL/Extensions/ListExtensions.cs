using DriveLicense_PCL.Implementacions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicense_PCL.Extencions
{
    public static class ListExtensions
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static async Task<List<DriverLicenseTicketsModel>> GetModelsWithImages(this List<DriverLicenseTicketsModel> Models, string FolderUrl)
        {
            List<string> ImageSrcs = new List<string>();
            ImageSrcs = await Task<List<string>>.Run(() =>
            {
                return Directory.GetFiles(FolderUrl).ToList();
            });

            List<DriverLicenseTicketsModel> ModelsWithImages = new List<DriverLicenseTicketsModel>();

            foreach(var item in ImageSrcs)
            {
                ModelsWithImages.AddRange(Models.Where(o => FolderUrl + o.Filename == item));
            }

            return ModelsWithImages;
        }
    }
}
