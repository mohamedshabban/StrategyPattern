using System.Drawing.Imaging;

namespace StrategyPatternExample.ImageStartegy
{
    public class BMPStrategy : IImageSaveStrategy
    {
        public void SaveImage(Image image, string folderPath)
        {
            image.Save(folderPath, ImageFormat.Bmp);
            MessageBox.Show("bmp Image saved!");
        }
    }
}
