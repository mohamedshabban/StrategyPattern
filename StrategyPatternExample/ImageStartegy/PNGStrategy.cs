using System.Drawing.Imaging;

namespace StrategyPatternExample.ImageStartegy
{
    public class PNGStrategy : IImageSaveStrategy
    {
        public void SaveImage(Image image, string folderPath)
        {
            image.Save(folderPath, ImageFormat.Png);
            MessageBox.Show("png Image saved!");
        }
    }
}
