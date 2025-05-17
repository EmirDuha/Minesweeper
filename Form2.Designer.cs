namespace FORMSDENEME2
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            labelName = new Label();
            panelBackground1 = new Panel();
            panelBackground2 = new Panel();
            buttonBack = new Button();
            panelBackground3 = new Panel();
            pictureBoxFlag = new PictureBox();
            pictureBoxTimer = new PictureBox();
            labelScore = new Label();
            labelGameStatement = new Label();
            labelMoveCounter = new Label();
            labelTimeCounter = new Label();
            labelFlagCounter = new Label();
            buttonRestart = new Button();
            pictureBox1 = new PictureBox();
            panelBackground4 = new Panel();
            timerCounter = new System.Windows.Forms.Timer(components);
            buttonScoreboard = new Button();
            panelBackground2.SuspendLayout();
            panelBackground3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTimer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.FromArgb(128, 255, 255);
            labelName.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelName.Location = new Point(73, 16);
            labelName.Name = "labelName";
            labelName.Size = new Size(136, 54);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // panelBackground1
            // 
            panelBackground1.BackColor = Color.Gray;
            panelBackground1.Location = new Point(-1, 0);
            panelBackground1.Name = "panelBackground1";
            panelBackground1.Size = new Size(1516, 44);
            panelBackground1.TabIndex = 3;
            // 
            // panelBackground2
            // 
            panelBackground2.BackColor = Color.Gray;
            panelBackground2.Controls.Add(buttonScoreboard);
            panelBackground2.Controls.Add(buttonBack);
            panelBackground2.Controls.Add(labelName);
            panelBackground2.Location = new Point(-1, 31);
            panelBackground2.Name = "panelBackground2";
            panelBackground2.Size = new Size(306, 958);
            panelBackground2.TabIndex = 4;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonBack.Location = new Point(40, 754);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(221, 72);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // panelBackground3
            // 
            panelBackground3.BackColor = Color.Gray;
            panelBackground3.Controls.Add(pictureBoxFlag);
            panelBackground3.Controls.Add(pictureBoxTimer);
            panelBackground3.Controls.Add(labelScore);
            panelBackground3.Controls.Add(labelGameStatement);
            panelBackground3.Controls.Add(labelMoveCounter);
            panelBackground3.Controls.Add(labelTimeCounter);
            panelBackground3.Controls.Add(labelFlagCounter);
            panelBackground3.Controls.Add(buttonRestart);
            panelBackground3.Controls.Add(pictureBox1);
            panelBackground3.Location = new Point(1209, 31);
            panelBackground3.Name = "panelBackground3";
            panelBackground3.Size = new Size(306, 958);
            panelBackground3.TabIndex = 5;
            // 
            // pictureBoxFlag
            // 
            pictureBoxFlag.Image = (Image)resources.GetObject("pictureBoxFlag.Image");
            pictureBoxFlag.Location = new Point(65, 67);
            pictureBoxFlag.Name = "pictureBoxFlag";
            pictureBoxFlag.Size = new Size(72, 67);
            pictureBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFlag.TabIndex = 9;
            pictureBoxFlag.TabStop = false;
            // 
            // pictureBoxTimer
            // 
            pictureBoxTimer.Image = (Image)resources.GetObject("pictureBoxTimer.Image");
            pictureBoxTimer.Location = new Point(56, 153);
            pictureBoxTimer.Name = "pictureBoxTimer";
            pictureBoxTimer.Size = new Size(91, 92);
            pictureBoxTimer.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTimer.TabIndex = 10;
            pictureBoxTimer.TabStop = false;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.FromArgb(128, 255, 255);
            labelScore.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelScore.Location = new Point(32, 611);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(0, 38);
            labelScore.TabIndex = 8;
            // 
            // labelGameStatement
            // 
            labelGameStatement.AutoSize = true;
            labelGameStatement.BackColor = Color.FromArgb(128, 255, 255);
            labelGameStatement.Font = new Font("Tahoma", 28.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelGameStatement.Location = new Point(0, 767);
            labelGameStatement.Name = "labelGameStatement";
            labelGameStatement.Size = new Size(314, 59);
            labelGameStatement.TabIndex = 7;
            labelGameStatement.Text = "Game Over!";
            labelGameStatement.Visible = false;
            // 
            // labelMoveCounter
            // 
            labelMoveCounter.AutoSize = true;
            labelMoveCounter.BackColor = Color.FromArgb(128, 255, 255);
            labelMoveCounter.Font = new Font("Tahoma", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelMoveCounter.Location = new Point(146, 273);
            labelMoveCounter.Name = "labelMoveCounter";
            labelMoveCounter.Size = new Size(80, 53);
            labelMoveCounter.TabIndex = 3;
            labelMoveCounter.Text = "---";
            // 
            // labelTimeCounter
            // 
            labelTimeCounter.AutoSize = true;
            labelTimeCounter.BackColor = Color.FromArgb(128, 255, 255);
            labelTimeCounter.Font = new Font("Tahoma", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelTimeCounter.Location = new Point(146, 172);
            labelTimeCounter.Name = "labelTimeCounter";
            labelTimeCounter.Size = new Size(80, 53);
            labelTimeCounter.TabIndex = 2;
            labelTimeCounter.Text = "---";
            // 
            // labelFlagCounter
            // 
            labelFlagCounter.AutoSize = true;
            labelFlagCounter.BackColor = Color.FromArgb(128, 255, 255);
            labelFlagCounter.Font = new Font("Tahoma", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelFlagCounter.Location = new Point(146, 75);
            labelFlagCounter.Name = "labelFlagCounter";
            labelFlagCounter.Size = new Size(80, 53);
            labelFlagCounter.TabIndex = 1;
            labelFlagCounter.Text = "---";
            // 
            // buttonRestart
            // 
            buttonRestart.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonRestart.Location = new Point(56, 849);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(199, 72);
            buttonRestart.TabIndex = 0;
            buttonRestart.Text = "Restart";
            buttonRestart.UseVisualStyleBackColor = true;
            buttonRestart.Click += buttonRestart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 251);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panelBackground4
            // 
            panelBackground4.BackColor = Color.Gray;
            panelBackground4.Location = new Point(303, 949);
            panelBackground4.Name = "panelBackground4";
            panelBackground4.Size = new Size(909, 40);
            panelBackground4.TabIndex = 6;
            // 
            // timerCounter
            // 
            timerCounter.Tick += timerCounter_Tick;
            // 
            // buttonScoreboard
            // 
            buttonScoreboard.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonScoreboard.Location = new Point(40, 849);
            buttonScoreboard.Name = "buttonScoreboard";
            buttonScoreboard.Size = new Size(221, 72);
            buttonScoreboard.TabIndex = 4;
            buttonScoreboard.Text = "Scoreboard";
            buttonScoreboard.UseVisualStyleBackColor = true;
            buttonScoreboard.Click += buttonScoreboard_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1515, 989);
            Controls.Add(panelBackground1);
            Controls.Add(panelBackground4);
            Controls.Add(panelBackground2);
            Controls.Add(panelBackground3);
            Name = "Form2";
            Text = "Game";
            Load += Form2_Load;
            panelBackground2.ResumeLayout(false);
            panelBackground2.PerformLayout();
            panelBackground3.ResumeLayout(false);
            panelBackground3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTimer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelName;
        private Panel panelBackground1;
        private Panel panelBackground2;
        private Panel panelBackground3;
        private Panel panelBackground4;
        private Button buttonRestart;
        private Label labelGameStatement;
        private Label labelTimeCounter;
        private Label labelFlagCounter;
        private System.Windows.Forms.Timer timerCounter;
        private Label labelMoveCounter;
        private Label labelScore;
        private PictureBox pictureBoxTimer;
        private PictureBox pictureBoxFlag;
        private PictureBox pictureBox1;
        private Button buttonBack;
        private Button buttonScoreboard;
    }
}