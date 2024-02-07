using StrategyPatternExample.ImageStartegy;

namespace StrategyPatternExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("Test.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image files (*.jpg, *.pdf, *.bmp, *.png, *.tiff)|*.jpg, *.pdf, *.bmp, *.png, *.tiff";
            saveFileDialog.Title = "Select output directory:";
            saveFileDialog.ShowDialog();
            //if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            //{
            //    return;
            //}
            IImageSaveStrategy saveStrategy;
            var extension = Path.GetExtension(saveFileDialog.FileName);
            switch (extension.ToLower())
            {
                case ".jpg":
                    saveStrategy = new JPGStrategy();
                    break;
                case ".png":
                    saveStrategy = new PNGStrategy();
                    break;
                case ".pdf":
                    saveStrategy = new PNGStrategy();
                    break;
                case ".bmp":
                    saveStrategy = new PNGStrategy();
                    break;
                case ".tiff":
                    saveStrategy = new TIFFStrategy();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(extension);
            }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string folderName = saveFileDialog.FileName;
                saveStrategy.SaveImage(pictureBox1.Image, folderName);
            }
        }
    }
}