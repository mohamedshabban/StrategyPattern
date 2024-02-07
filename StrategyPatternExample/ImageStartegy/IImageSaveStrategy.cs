namespace StrategyPatternExample.ImageStartegy
{
    public interface IImageSaveStrategy
    {
        void SaveImage(Image image, string folderPath);
    }
}
