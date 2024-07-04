namespace StajZad1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            givenPicture = new PictureBox();
            contrast1 = new Label();
            contrast2 = new Label();
            doContrast = new Button();
            errorLabel = new Label();
            contrast1Picture = new PictureBox();
            contrast2Picture = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            button1 = new Button();
            yourColors = new Label();
            noteLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)givenPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contrast1Picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contrast2Picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(51, 44);
            label1.Name = "label1";
            label1.Size = new Size(206, 28);
            label1.TabIndex = 0;
            label1.Text = "Drag your image here:";
            // 
            // givenPicture
            // 
            givenPicture.BorderStyle = BorderStyle.FixedSingle;
            givenPicture.Location = new Point(36, 88);
            givenPicture.Name = "givenPicture";
            givenPicture.Size = new Size(266, 235);
            givenPicture.TabIndex = 1;
            givenPicture.TabStop = false;
            givenPicture.DragDrop += givenPicture_DragDrop;
            givenPicture.DragEnter += givenPicture_DragEnter;
            // 
            // contrast1
            // 
            contrast1.AutoSize = true;
            contrast1.Location = new Point(458, 201);
            contrast1.Name = "contrast1";
            contrast1.Size = new Size(36, 15);
            contrast1.TabIndex = 2;
            contrast1.Text = "Color";
            // 
            // contrast2
            // 
            contrast2.AutoSize = true;
            contrast2.Location = new Point(458, 377);
            contrast2.Name = "contrast2";
            contrast2.Size = new Size(36, 15);
            contrast2.TabIndex = 3;
            contrast2.Text = "Color";
            // 
            // doContrast
            // 
            doContrast.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            doContrast.Location = new Point(36, 359);
            doContrast.Name = "doContrast";
            doContrast.Size = new Size(178, 48);
            doContrast.TabIndex = 4;
            doContrast.Text = "Show contrast colors";
            doContrast.UseVisualStyleBackColor = true;
            doContrast.Click += doContrast_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(36, 326);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(191, 15);
            errorLabel.TabIndex = 5;
            errorLabel.Text = "Image must be a PNG or JPG/JPEG!";
            // 
            // contrast1Picture
            // 
            contrast1Picture.Location = new Point(458, 88);
            contrast1Picture.Name = "contrast1Picture";
            contrast1Picture.Size = new Size(170, 110);
            contrast1Picture.TabIndex = 6;
            contrast1Picture.TabStop = false;
            // 
            // contrast2Picture
            // 
            contrast2Picture.Location = new Point(458, 264);
            contrast2Picture.Name = "contrast2Picture";
            contrast2Picture.Size = new Size(170, 110);
            contrast2Picture.TabIndex = 7;
            contrast2Picture.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(240, 359);
            button1.Name = "button1";
            button1.Size = new Size(93, 48);
            button1.TabIndex = 8;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // yourColors
            // 
            yourColors.AutoSize = true;
            yourColors.Font = new Font("Segoe UI", 15F);
            yourColors.Location = new Point(458, 44);
            yourColors.Name = "yourColors";
            yourColors.Size = new Size(192, 28);
            yourColors.TabIndex = 9;
            yourColors.Text = "Here are your colors:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.ForeColor = Color.Teal;
            noteLabel.Location = new Point(458, 402);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(291, 30);
            noteLabel.TabIndex = 10;
            noteLabel.Text = "Note: One of the colors was automatically set to black\r\nbecause the image's colors were too similar\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(noteLabel);
            Controls.Add(yourColors);
            Controls.Add(button1);
            Controls.Add(contrast2Picture);
            Controls.Add(contrast1Picture);
            Controls.Add(errorLabel);
            Controls.Add(doContrast);
            Controls.Add(contrast2);
            Controls.Add(contrast1);
            Controls.Add(givenPicture);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Contrasting Colors";
            ((System.ComponentModel.ISupportInitialize)givenPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)contrast1Picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)contrast2Picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox givenPicture;
        private Label contrast1;
        private Label contrast2;
        private Button doContrast;
        private Label errorLabel;
        private PictureBox contrast1Picture;
        private PictureBox contrast2Picture;
        private ErrorProvider errorProvider1;
        private Button button1;
        private Label yourColors;
        private Label noteLabel;
    }
}
