using System;
using System.Drawing;
using System.Windows.Forms;

namespace TabletopBoxConverter
{
    public partial class MainAppScreen : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        bool isDragging = false;
        int lastYCoord = 0;

        public MainAppScreen()
        {
            InitializeComponent();
            this.KeyDown += EscapeKeyDown;
            this.MouseDown += MainAppScreen_MouseDown;
            this.MouseUp += MainAppScreen_MouseUp;
            this.MouseMove += MainAppScreen_MouseMove;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            ToggleVisibilityForScreenshot(true);

            string filePath = ChooseSaveLocation();
            if (String.IsNullOrWhiteSpace(filePath)) return;
            try
            {
                SaveFile(filePath);
            }
            catch
            {
                // Invalid filePath
            }

            ToggleVisibilityForScreenshot(false);
        }

        private string ChooseSaveLocation()
        {
            DialogResult dialogue = SaveBrowser.ShowDialog();
            if (dialogue == DialogResult.OK)
            {
                return SaveBrowser.FileName;
            }
            else
            {
                ToggleVisibilityForScreenshot(false);
                return "";
            }
        }

        private void SaveFile(string filePath)
        {
            var form = ActiveForm;
            using (var image = new Bitmap(form.Width, form.Height))
            {
                form.DrawToBitmap(image, new Rectangle(0, 0, image.Width, image.Height));
                image.Save(filePath);
            }
        }

        private void ToggleVisibilityForScreenshot(bool hideGadgets)
        {
            SaveButton.Visible = !hideGadgets;
            CloseButton.Visible = !hideGadgets;

            BorderStyle style = hideGadgets ? BorderStyle.None : BorderStyle.Fixed3D;

            PlayerCount.BorderStyle = style;
            GameType.BorderStyle = style;
            Duration.BorderStyle = style;
            RecommendedAge.BorderStyle = style;
            Designer.BorderStyle = style;
            Publisher.BorderStyle = style;
            EaseOfLearning.BorderStyle = style;
            EaseOfMastery.BorderStyle = style;
            TurnLength.BorderStyle = style;
        }

        private void EscapeKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void MainAppScreen_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainAppScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainAppScreen_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
