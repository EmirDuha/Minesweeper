namespace FORMSDENEME2
{
    partial class Form3
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
            listBoxScoreboard = new ListBox();
            SuspendLayout();
            // 
            // listBoxScoreboard
            // 
            listBoxScoreboard.BackColor = Color.FromArgb(0, 192, 192);
            listBoxScoreboard.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listBoxScoreboard.FormattingEnabled = true;
            listBoxScoreboard.ItemHeight = 28;
            listBoxScoreboard.Location = new Point(12, 12);
            listBoxScoreboard.Name = "listBoxScoreboard";
            listBoxScoreboard.Size = new Size(489, 480);
            listBoxScoreboard.TabIndex = 0;
            // 
            // Scoreboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(513, 528);
            Controls.Add(listBoxScoreboard);
            Name = "Form3";
            Text = "Form3";
            Load += Scoreboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxScoreboard;
    }
}