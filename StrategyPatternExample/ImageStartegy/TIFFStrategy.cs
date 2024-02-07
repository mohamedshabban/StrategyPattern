using System.Drawing.Imaging;

namespace StrategyPatternExample.ImageStartegy
{
    public class TIFFStrategy : IImageSaveStrategy
    {
        public void SaveImage(Image image, string folderPath)
        {
            image.Save(folderPath, ImageFormat.Tiff);
            MessageBox.Show("tiff Image saved!");
        }
    }
}
