using AForge.Video.DirectShow;
using AForge.Video;
using System.Diagnostics;
using project_images.Classes;
using System.Drawing.Imaging;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;

namespace project_images
{
    public partial class Form1 : Form
    {

        private VideoCaptureDevice webCam;
        Bitmap imgOriginal;
        bool isImageOriginal = true;
        Filters filters = new Filters();
        VideoFilters videoFilters = new VideoFilters();
        VideoCapture videoCapture;
        bool isPause = false;
        int typeFilter = 0;
        bool isSelectVideo = false;
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("D:\\Dev\\C#\\project_images\\project_images\\haarcascade_frontalface_alt_tree.xml");
        private int counterPerson = 0;
        private Color[] colorCamCapture = new Color[10];
        Image<Gray, Byte> R;
        Image<Gray, Byte> G;
        Image<Gray, Byte> B;


        public Form1()
        {
            InitializeComponent();
            InitializeColorCam();
        }

        private void InitializeColorCam()
        {
            colorCamCapture[0] = Color.Red;
            colorCamCapture[1] = Color.Green;
            colorCamCapture[2] = Color.Blue;
            colorCamCapture[3] = Color.Black;
            colorCamCapture[4] = Color.Coral;
            colorCamCapture[5] = Color.Red;
            colorCamCapture[6] = Color.Green;
            colorCamCapture[7] = Color.Blue;
            colorCamCapture[8] = Color.Black;
            colorCamCapture[9] = Color.Coral;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //loadDevices();
            string videoName = loadDevices();
            webCam= new VideoCaptureDevice(videoName);
            webCam.NewFrame += new NewFrameEventHandler(Capture);
            webCam.Start();
        }



        private string loadDevices(){
            FilterInfoCollection myDevices= new FilterInfoCollection (FilterCategory.VideoInputDevice);
            for (int i = 0; i < myDevices.Count; i++) {
                if (myDevices[i].Name.Equals("Integrated Camera")) {
                    return myDevices[i].MonikerString;
                }
            }
            return "";
        }


        private void Capture(Object sender, NewFrameEventArgs eventArgs) {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            //Bitmap imagen1 = imagen;

            Image<Bgr,Byte> newImage= image.ToImage<Bgr,byte>();
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(newImage, 1.2, 1);
            counterPerson = 0;
            foreach (Rectangle rectangle in rectangles) {
                Graphics graphics = Graphics.FromImage(image);
                Pen pen = new Pen(colorCamCapture[counterPerson], 3);
                graphics.DrawRectangle(pen, rectangle);
                counterPerson++;
            }
            if (InvokeRequired)
                Invoke(new Action(() => counterPerson_lbl.Text = counterPerson.ToString())); 

            pictureBox1.Image = image;
           
        }

        private void closeWebCam() {
            if (webCam != null && webCam.IsRunning) { 
                webCam.SignalToStop();
                webCam = null;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeWebCam();
        }

        private void btn_Grises_Click(object sender, EventArgs e)
        {
            if (isSelectVideo == false) { 
                getImageOriginal();
                Bitmap imgCopy = new Bitmap(pictureBox1.Image);
                Bitmap imgModify = filters.GrayScales(imgCopy);
                pictureBox2.Image = imgModify;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                Image<Bgr, Byte> newImage = imgModify.ToImage<Bgr, Byte>();
                R = newImage[0];
                G = newImage[1];
                B = newImage[2];
                histogramBox1.ClearHistogram();
                histogramBox2.ClearHistogram();
                histogramBox3.ClearHistogram();
                histogramBox1.GenerateHistograms(R, 64);
                histogramBox2.GenerateHistograms(G, 64);
                histogramBox3.GenerateHistograms(B, 64);
                histogramBox1.Refresh();
                histogramBox2.Refresh();
                histogramBox3.Refresh();

                return;
            }
            typeFilter = 1;

        }

        private void btn_Invertido_Click(object sender, EventArgs e)
        {
            if (isSelectVideo == false)
            {
                getImageOriginal();
                Bitmap imgCopy = new Bitmap(pictureBox1.Image);
                Bitmap imgModify = filters.Invert(imgCopy);
                pictureBox2.Image = imgModify;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                Image<Bgr, Byte> newImage = imgModify.ToImage<Bgr,Byte>();
                R = newImage[0];
                G = newImage[1];
                B = newImage[2];
                histogramBox1.ClearHistogram();
                histogramBox2.ClearHistogram();
                histogramBox3.ClearHistogram();
                histogramBox1.GenerateHistograms(R,64);
                histogramBox2.GenerateHistograms(G, 64);
                histogramBox3.GenerateHistograms(B, 64);
                histogramBox1.Refresh();
                histogramBox2.Refresh();
                histogramBox3.Refresh();
                return;
            }
            typeFilter = 2;
        }

        private void btn_Rojo_Click(object sender, EventArgs e)
        {
            if (isSelectVideo == false)
            {
                getImageOriginal();
                Bitmap imgCopy = new Bitmap(pictureBox1.Image);
                Bitmap imgModify = filters.ColorRed(imgCopy);
                pictureBox2.Image = imgModify;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                Image<Bgr, Byte> newImage = imgModify.ToImage<Bgr, Byte>();
                R = newImage[0];
                G = newImage[1];
                B = newImage[2];
                histogramBox1.ClearHistogram();
                histogramBox2.ClearHistogram();
                histogramBox3.ClearHistogram();
                histogramBox1.GenerateHistograms(R, 64);
                histogramBox2.GenerateHistograms(G, 64);
                histogramBox3.GenerateHistograms(B, 64);
                histogramBox1.Refresh();
                histogramBox2.Refresh();
                histogramBox3.Refresh();

                return;
            }
            typeFilter = 3;
        }

        private void btn_Brillo_Click(object sender, EventArgs e)
        {
            if (isSelectVideo == false)
            {
                getImageOriginal();
                Bitmap imgCopy = new Bitmap(pictureBox1.Image);
                Bitmap imgModify= filters.Brightness(imgCopy);
                pictureBox2.Image = imgModify;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                Image<Bgr, Byte> newImage = imgModify.ToImage<Bgr, Byte>();
                R = newImage[0];
                G = newImage[1];
                B = newImage[2];
                histogramBox1.ClearHistogram();
                histogramBox2.ClearHistogram();
                histogramBox3.ClearHistogram();
                histogramBox1.GenerateHistograms(R, 64);
                histogramBox2.GenerateHistograms(G, 64);
                histogramBox3.GenerateHistograms(B, 64);
                histogramBox1.Refresh();
                histogramBox2.Refresh();
                histogramBox3.Refresh();
                return;
            }
            typeFilter = 4;
        }

        private void btn_Binario_Click(object sender, EventArgs e)
        {
            if (isSelectVideo == false)
            {
                getImageOriginal();
                Bitmap imgCopy = new Bitmap(pictureBox1.Image);
                Bitmap imgModify = filters.Binary(imgCopy);
                pictureBox2.Image = imgModify;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                Image<Bgr, Byte> newImage = imgModify.ToImage<Bgr, Byte>();
                R = newImage[0];
                G = newImage[1];
                B = newImage[2];
                histogramBox1.ClearHistogram();
                histogramBox2.ClearHistogram();
                histogramBox3.ClearHistogram();
                histogramBox1.GenerateHistograms(R, 64);
                histogramBox2.GenerateHistograms(G, 64);
                histogramBox3.GenerateHistograms(B, 64);
                histogramBox1.Refresh();
                histogramBox2.Refresh();
                histogramBox3.Refresh();

                return;
            }
            typeFilter = 5;
        }


        private void getImageOriginal()
        {
            if (isImageOriginal){
              imgOriginal = new Bitmap(pictureBox1.Image);//PictureBox
                isImageOriginal = false;
            }
        }

        private void btn_CargarImg_Click(object sender, EventArgs e)
        {
            isSelectVideo = false;
            closeWebCam();
            pictureBox1.Image = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_GuardarImg_Click(object sender, EventArgs e)
        {
            int longitud = 7;
            Guid myGuid = Guid.NewGuid();
            string token = myGuid.ToString().Replace("-", string.Empty).Substring(0, longitud);
            pictureBox2.Image.Save("../../Imagenes/" + token + ".png", ImageFormat.Png);
            MessageBox.Show("Image Saved", "Dowload Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_GuardarImagenNoEffect_Click(object sender, EventArgs e)
        {

        }

        private async void btn_CargarVideo_Click(object sender, EventArgs e)
        {
            isSelectVideo = true;
            closeWebCam();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                videoCapture = new VideoCapture(openFileDialog.FileName);
                Mat mat = new Mat();
                Bitmap originalImage =mat.ToBitmap();
                while (!isPause) {
                    videoCapture.Read(mat);
                    if (!mat.IsEmpty)
                    {
                        Bitmap bitMapResult;
                        switch (typeFilter)
                        {
                            case 0:
                                bitMapResult = mat.ToBitmap();
                                break;
                            case 1:
                                bitMapResult = videoFilters.GrayScales(mat.ToBitmap());
                                break;
                            case 2:
                                bitMapResult = videoFilters.Invert(mat.ToBitmap());
                                break;
                            case 3:
                                bitMapResult = videoFilters.ColorRed(mat.ToBitmap());
                                break;
                            case 4:
                                bitMapResult = videoFilters.Brightness(mat.ToBitmap());
                                break;
                            case 5:
                                bitMapResult = videoFilters.Binary(mat.ToBitmap());
                                break;
                            default:
                                bitMapResult = mat.ToBitmap();
                                break;
                        }
                        pictureBox1.Image = mat.ToBitmap();
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox2.Image = bitMapResult;
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        double fps = videoCapture.Get(Emgu.CV.CvEnum.CapProp.Fps);
                        await Task.Delay(1000 / Convert.ToInt32(fps));
                    }
                    else {
                        break;
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }








    }
}