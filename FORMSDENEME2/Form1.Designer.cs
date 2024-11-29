namespace FORMSDENEME2
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            labelEnterName = new Label();
            textBox2 = new TextBox();
            labelEnterFieldSize = new Label();
            labelEnterMine = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            buttonStart = new Button();
            labelInfo = new Label();
            pictureBox7 = new PictureBox();
            labelError = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 112);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(234, 18);
            label1.Name = "label1";
            label1.Size = new Size(373, 73);
            label1.TabIndex = 0;
            label1.Text = "Minesweeper";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(317, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 1;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // labelEnterName
            // 
            labelEnterName.AutoSize = true;
            labelEnterName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelEnterName.Location = new Point(182, 177);
            labelEnterName.Name = "labelEnterName";
            labelEnterName.Size = new Size(129, 20);
            labelEnterName.TabIndex = 2;
            labelEnterName.Text = "Enter your name:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(366, 288);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 27);
            textBox2.TabIndex = 7;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // labelEnterFieldSize
            // 
            labelEnterFieldSize.AutoSize = true;
            labelEnterFieldSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelEnterFieldSize.Location = new Point(112, 237);
            labelEnterFieldSize.Name = "labelEnterFieldSize";
            labelEnterFieldSize.Size = new Size(248, 20);
            labelEnterFieldSize.TabIndex = 5;
            labelEnterFieldSize.Text = "Enter size of field(10x10 - 30x30):";
            // 
            // labelEnterMine
            // 
            labelEnterMine.AutoSize = true;
            labelEnterMine.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelEnterMine.Location = new Point(125, 291);
            labelEnterMine.Name = "labelEnterMine";
            labelEnterMine.Size = new Size(235, 20);
            labelEnterMine.TabIndex = 6;
            labelEnterMine.Text = "Enter number of mines(min 10):";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            comboBox1.Location = new Point(366, 234);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(105, 28);
            comboBox1.TabIndex = 10;
            comboBox1.KeyDown += comboBox1_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(524, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(476, 282);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(477, 223);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(524, 166);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(476, 282);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 41);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(477, 223);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 43);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            pictureBox6.Visible = false;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonStart.Location = new Point(289, 360);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(249, 56);
            buttonStart.TabIndex = 17;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelInfo.Location = new Point(12, 419);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(136, 40);
            labelInfo.TabIndex = 18;
            labelInfo.Text = "Emir Duha Nakişci\r\n230229026\r\n";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1, 105);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(810, 393);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 19;
            pictureBox7.TabStop = false;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelError.Location = new Point(300, 428);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 20);
            labelError.TabIndex = 20;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(798, 468);
            Controls.Add(labelError);
            Controls.Add(labelInfo);
            Controls.Add(buttonStart);
            Controls.Add(pictureBox3);
            Controls.Add(comboBox1);
            Controls.Add(labelEnterMine);
            Controls.Add(labelEnterFieldSize);
            Controls.Add(textBox2);
            Controls.Add(labelEnterName);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox7);
            Name = "MainMenu";
            Text = "Main Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label labelEnterName;
        private TextBox textBox2;
        private Label labelEnterFieldSize;
        private Label labelEnterMine;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button buttonStart;
        private Label labelInfo;
        private PictureBox pictureBox7;
        private Label labelError;
    }
}
