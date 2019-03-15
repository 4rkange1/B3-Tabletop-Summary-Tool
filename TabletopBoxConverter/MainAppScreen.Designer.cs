namespace TabletopBoxConverter
{
    partial class MainAppScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAppScreen));
            this.SaveButton = new System.Windows.Forms.Button();
            this.PlayerCount = new System.Windows.Forms.TextBox();
            this.GameType = new System.Windows.Forms.TextBox();
            this.Duration = new System.Windows.Forms.TextBox();
            this.RecommendedAge = new System.Windows.Forms.TextBox();
            this.Designer = new System.Windows.Forms.TextBox();
            this.Publisher = new System.Windows.Forms.TextBox();
            this.EaseOfLearning = new System.Windows.Forms.TextBox();
            this.EaseOfMastery = new System.Windows.Forms.TextBox();
            this.TurnLength = new System.Windows.Forms.TextBox();
            this.SaveBrowser = new System.Windows.Forms.SaveFileDialog();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Firebrick;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveButton.FlatAppearance.BorderSize = 3;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(756, 30);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(180, 77);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save as...";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // PlayerCount
            // 
            this.PlayerCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayerCount.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCount.Location = new System.Drawing.Point(68, 214);
            this.PlayerCount.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.PlayerCount.MaximumSize = new System.Drawing.Size(233, 100);
            this.PlayerCount.MinimumSize = new System.Drawing.Size(233, 37);
            this.PlayerCount.Multiline = true;
            this.PlayerCount.Name = "PlayerCount";
            this.PlayerCount.Size = new System.Drawing.Size(233, 83);
            this.PlayerCount.TabIndex = 1;
            this.PlayerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GameType
            // 
            this.GameType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GameType.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameType.Location = new System.Drawing.Point(370, 214);
            this.GameType.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.GameType.MaximumSize = new System.Drawing.Size(233, 100);
            this.GameType.MinimumSize = new System.Drawing.Size(233, 37);
            this.GameType.Multiline = true;
            this.GameType.Name = "GameType";
            this.GameType.Size = new System.Drawing.Size(233, 83);
            this.GameType.TabIndex = 2;
            this.GameType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Duration
            // 
            this.Duration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Duration.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.Location = new System.Drawing.Point(673, 214);
            this.Duration.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Duration.MaximumSize = new System.Drawing.Size(233, 100);
            this.Duration.MinimumSize = new System.Drawing.Size(233, 37);
            this.Duration.Multiline = true;
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(233, 83);
            this.Duration.TabIndex = 3;
            this.Duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RecommendedAge
            // 
            this.RecommendedAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RecommendedAge.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecommendedAge.Location = new System.Drawing.Point(68, 365);
            this.RecommendedAge.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.RecommendedAge.MaximumSize = new System.Drawing.Size(233, 100);
            this.RecommendedAge.MinimumSize = new System.Drawing.Size(233, 37);
            this.RecommendedAge.Multiline = true;
            this.RecommendedAge.Name = "RecommendedAge";
            this.RecommendedAge.Size = new System.Drawing.Size(233, 83);
            this.RecommendedAge.TabIndex = 4;
            this.RecommendedAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Designer
            // 
            this.Designer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Designer.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Designer.Location = new System.Drawing.Point(370, 365);
            this.Designer.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Designer.MaximumSize = new System.Drawing.Size(233, 100);
            this.Designer.MinimumSize = new System.Drawing.Size(233, 37);
            this.Designer.Multiline = true;
            this.Designer.Name = "Designer";
            this.Designer.Size = new System.Drawing.Size(233, 83);
            this.Designer.TabIndex = 5;
            this.Designer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Publisher
            // 
            this.Publisher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Publisher.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher.Location = new System.Drawing.Point(673, 365);
            this.Publisher.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Publisher.MaximumSize = new System.Drawing.Size(233, 100);
            this.Publisher.MinimumSize = new System.Drawing.Size(233, 37);
            this.Publisher.Multiline = true;
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(233, 83);
            this.Publisher.TabIndex = 6;
            this.Publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EaseOfLearning
            // 
            this.EaseOfLearning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EaseOfLearning.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EaseOfLearning.Location = new System.Drawing.Point(68, 514);
            this.EaseOfLearning.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.EaseOfLearning.MaximumSize = new System.Drawing.Size(233, 100);
            this.EaseOfLearning.MinimumSize = new System.Drawing.Size(233, 37);
            this.EaseOfLearning.Multiline = true;
            this.EaseOfLearning.Name = "EaseOfLearning";
            this.EaseOfLearning.Size = new System.Drawing.Size(233, 83);
            this.EaseOfLearning.TabIndex = 7;
            this.EaseOfLearning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EaseOfMastery
            // 
            this.EaseOfMastery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EaseOfMastery.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EaseOfMastery.Location = new System.Drawing.Point(370, 514);
            this.EaseOfMastery.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.EaseOfMastery.MaximumSize = new System.Drawing.Size(233, 100);
            this.EaseOfMastery.MinimumSize = new System.Drawing.Size(233, 37);
            this.EaseOfMastery.Multiline = true;
            this.EaseOfMastery.Name = "EaseOfMastery";
            this.EaseOfMastery.Size = new System.Drawing.Size(233, 83);
            this.EaseOfMastery.TabIndex = 8;
            this.EaseOfMastery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TurnLength
            // 
            this.TurnLength.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TurnLength.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnLength.Location = new System.Drawing.Point(673, 514);
            this.TurnLength.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.TurnLength.MaximumSize = new System.Drawing.Size(233, 100);
            this.TurnLength.MinimumSize = new System.Drawing.Size(233, 37);
            this.TurnLength.Multiline = true;
            this.TurnLength.Name = "TurnLength";
            this.TurnLength.Size = new System.Drawing.Size(233, 83);
            this.TurnLength.TabIndex = 9;
            this.TurnLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaveBrowser
            // 
            this.SaveBrowser.DefaultExt = "bmp";
            this.SaveBrowser.Title = "Choose a save location.";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(963, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 23);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainAppScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 648);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TurnLength);
            this.Controls.Add(this.EaseOfMastery);
            this.Controls.Add(this.EaseOfLearning);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.Designer);
            this.Controls.Add(this.RecommendedAge);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.GameType);
            this.Controls.Add(this.PlayerCount);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainAppScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox PlayerCount;
        private System.Windows.Forms.TextBox GameType;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.TextBox RecommendedAge;
        private System.Windows.Forms.TextBox Designer;
        private System.Windows.Forms.TextBox Publisher;
        private System.Windows.Forms.TextBox EaseOfLearning;
        private System.Windows.Forms.TextBox EaseOfMastery;
        private System.Windows.Forms.TextBox TurnLength;
        private System.Windows.Forms.SaveFileDialog SaveBrowser;
        private System.Windows.Forms.Button CloseButton;
    }
}

