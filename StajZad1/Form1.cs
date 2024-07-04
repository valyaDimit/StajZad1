namespace StajZad1
{
    public partial class Form1 : Form
    {
        bool areLabelsFull = false;
        bool isDefaultColor = false;
        public Form1()
        {
            InitializeComponent();
            errorLabel.Visible = false;
            contrast1.Visible = false;
            contrast2.Visible = false;
            givenPicture.AllowDrop = true;
            button1.Enabled = false;
            yourColors.Visible = false;
            contrast1.Text = string.Empty;
            contrast2.Text = string.Empty;
            noteLabel.Visible = false;
        }

        Color GetColorFromCluster(List<Color> colors, int[] clusters, int clusterIndex)
        {
            var clusterColors = colors.Where((c, index) => clusters[index] == clusterIndex).ToList();
            if (clusterColors.Count == 0)
            {
                isDefaultColor = true;
                // Връща черен цвят или друг дефиниран цвят по подразбиране, ако списъкът е празен
                return Color.Black; // Можете да промените този цвят, ако е необходимо
            }
            int r = (int)clusterColors.Average(c => c.R);
            int g = (int)clusterColors.Average(c => c.G);
            int b = (int)clusterColors.Average(c => c.B);
            return Color.FromArgb(r, g, b);
        }
        private void doContrast_Click(object sender, EventArgs e)
        {
            if (givenPicture.Image != null && areLabelsFull == false)
            {
                Bitmap bitmap = new Bitmap(givenPicture.Image);

                List<Color> colors = new List<Color>();

                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        Color pixelColor = bitmap.GetPixel(x, y);
                        colors.Add(pixelColor);
                    }
                }

                var kmeans = new KMeans(2);
                var clusters = kmeans.Cluster(colors.Select(c => new double[] { c.R, c.G, c.B }).ToArray());

                Color primaryColor = GetColorFromCluster(colors, clusters, 0);
                Color secondaryColor = GetColorFromCluster(colors, clusters, 1);

                contrast1Picture.BackColor = primaryColor;
                contrast2Picture.BackColor = secondaryColor;

                if (primaryColor.IsNamedColor)
                {
                    contrast1.Text = primaryColor.Name + " ";
                }
                if (secondaryColor.IsNamedColor)
                {
                    contrast2.Text = secondaryColor.Name + " ";
                }
                contrast1.Text += $"RGB = ({primaryColor.R}, {primaryColor.G}, {primaryColor.B})";
                contrast2.Text += $"RGB = ({secondaryColor.R}, {secondaryColor.G}, {secondaryColor.B})";

                if (isDefaultColor)
                {
                    noteLabel.Visible = true;
                }

                yourColors.Visible = true;
                contrast1.Visible = true;
                contrast2.Visible = true;
                button1.Enabled = true;
                areLabelsFull = true;
            }
            else if (areLabelsFull)
            {

            }
            else
            {
                MessageBox.Show("Your image cannot be null!");
            }
        }

        private void givenPicture_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                string file = files[0];

                if (IsValidImageFile(file))
                {
                    givenPicture.Image = Image.FromFile(file);
                    //givenPicture.SizeMode = PictureBoxSizeMode.Normal;
                    if (givenPicture.Image.Width > givenPicture.Width || givenPicture.Image.Height > givenPicture.Height)
                    {
                        givenPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        givenPicture.Size = new Size(givenPicture.Image.Width, givenPicture.Image.Height);
                    }
                    errorLabel.Visible = false;
                }
                else
                {
                    errorProvider1.DataSource = givenPicture;
                    errorProvider1.SetError(givenPicture, "File must be a PNG or JPG/JPEG!");
                    errorLabel.Visible = true;
                }
            }
        }

        private void givenPicture_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files.Length > 0 && IsValidImageFile(files[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private bool IsValidImageFile(string file)
        {
            string ext = Path.GetExtension(file).ToLower();
            return ext == ".png" || ext == ".jpg" || ext == ".jpeg";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            givenPicture.Image = null;
            contrast1Picture.BackColor = Color.Transparent;
            contrast2Picture.BackColor = Color.Transparent;
            yourColors.Visible = false;
            contrast1.Text = "";
            contrast2.Text = "";
            contrast1.Visible = false;
            contrast2.Visible = false;
            button1.Enabled = false;
            areLabelsFull = false;
            givenPicture.Width = 266;
            givenPicture.Height = 235;
            noteLabel.Visible = false;
            isDefaultColor = false;
            // todo : razgledaj imageList, moje neshto da ti hrumne kato bonus; naprawi label da syobshtish che e zadaden default cweta (cherno) - opravi bool-a
        }
    }
}
