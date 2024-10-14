using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.XPhoto;
using System.Data;
using System.IO;


namespace CPM
{
    public partial class Form1 : Form
    {
        public VideoCapture videoCapture;
        public Mat captureFrame = new Mat();
        public Bitmap paint = new Bitmap(640, 480);
        public bool camIsOn = false;
        public int R, G, B = 0;
        Bitmap white = new Bitmap(640, 480);

        public bool videoStart = false;

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < paint.Width; i++)
                for (int j = 0; j < paint.Height; j++)
                    paint.SetPixel(i, j, Color.FromArgb(255, 255, 255, 255));
        }

        private void FrameRead(Mat captureFrame)
        {
            Mat thresh = new Mat();
            Mat gray = new Mat();
            Cv2.CvtColor(captureFrame, gray, ColorConversionCodes.BGR2GRAY);
            Cv2.Threshold(gray, thresh, 100, 255, ThresholdTypes.Binary);

            Bitmap threshBitmap = BitmapConverter.ToBitmap(thresh);

            for (int i = 0; i < threshBitmap.Width; i++)
                for (int j = 0; j < threshBitmap.Height; j++)
                    if (threshBitmap.GetPixel(i, j) == Color.FromArgb(255, 255, 255, 255))
                        paint.SetPixel(i, j, Color.FromArgb(255, R, G, B));

            DrawPB.Image = paint;
        }

        private void OnOffBtn_Click(object sender, EventArgs e)
        {
            if (videoStart)
            {
                videoStart = false;
                VideoPB.Image = white;
                DrawPB.Image = white;
                framtick.Stop();
                Clearr();
            }


            if (camIsOn == false)
                CaptureOn();
            else
                CaptureOff();
        }

        public void CaptureOff()
        {
            framtick.Stop();
            VideoPB.Image = white;
            DrawPB.Image = white;
            Clearr();
            camIsOn = false;
            OnOffBtn.Text = "Enable Camera";
        }

        public void CaptureOn()
        {
            videoCapture = new VideoCapture(0);
            framtick.Start();
            camIsOn = true;
            OnOffBtn.Text = "Disable camera";
        }

        private void framtick_Tick(object sender, EventArgs e)
        {
            if (camIsOn == true)
            {
                videoCapture.Read(captureFrame);
                VideoPB.Image = BitmapConverter.ToBitmap(captureFrame);
                FrameRead(captureFrame);
            }
            else if(videoStart == true)
            {
                videoCapture.Read(captureFrame);
                VideoPB.Image = BitmapConverter.ToBitmap(captureFrame);
                FrameRead(captureFrame);
            }
        }

        private void SetColor_Click(object sender, EventArgs e)
        {
            R = (int)numR.Value;
            G = (int)numG.Value;
            B = (int)numB.Value;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Clearr();
        }

        private void Clearr()
        {
            DrawPB.Image = white;
            for (int i = 0; i < paint.Width; i++)
                for (int j = 0; j < paint.Height; j++)
                    paint.SetPixel(i, j, Color.FromArgb(255, 255, 255, 255));
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Document";
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    paint.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("Impossible to save image", "FATAL ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (camIsOn)
                CaptureOff();

            if(videoStart == false)
            {
                string FilePath = "";
                OpenFileDialog choofdlog = new OpenFileDialog();
                choofdlog.Filter = "All Files (*.*)|*.*";
                choofdlog.FilterIndex = 1;
                choofdlog.Multiselect = false;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FilePath = openFileDialog1.FileName;
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
                videoCapture = new VideoCapture(FilePath);
                videoStart = true;
                framtick.Start();
            }
            else
            {
                videoStart = false;
                framtick.Stop();
            }
        }
    }
}