using System;
using System.Drawing;
using System.IO;
using System.Net;

namespace Menu_Designs
{
    public class ImageFunctions
    {
        public static byte[] ImageToByte(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        public static Image ByteToImage(byte[] imageBytes)
        {
            if (imageBytes == null) { return null; }
            // Convert byte[] to Image
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }
        public static string DownloadImage(string url) //Downloads the image on the url
        {
            string imgName = url.Substring(url.LastIndexOf('/') + 1);
            if (!Directory.Exists(".\\images")) { Directory.CreateDirectory(".\\images"); }
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(url), @".\images\" + imgName);
            }
            return (".\\images\\" + imgName);
        }
    }
}
