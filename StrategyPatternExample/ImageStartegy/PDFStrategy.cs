using System.Drawing.Imaging;

namespace StrategyPatternExample.ImageStartegy
{
    public class PDFStrategy : IImageSaveStrategy
    {
        public void SaveImage(Image image, string folderPath)
        {
            image.Save(folderPath, ImageFormat.Png);
            MessageBox.Show("pdf file saved!");
        }
    }
}
