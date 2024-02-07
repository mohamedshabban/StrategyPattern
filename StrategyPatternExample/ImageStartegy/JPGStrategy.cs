using System.Drawing.Imaging;

namespace StrategyPatternExample.ImageStartegy
{
    public class JPGStrategy : IImageSaveStrategy
    {
        public void SaveImage(Image image, string folderPath)
        {
            image.Save(folderPath, ImageFormat.Jpeg);
            MessageBox.Show("jpg Image saved!");
        }
    }
}
