namespace snaake
{
    partial class zmija
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
            oknosnake = new PictureBox();
            label1 = new Label();
            lblScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            lblGameOver = new Label();
            ((System.ComponentModel.ISupportInitialize)oknosnake).BeginInit();
            SuspendLayout();
            // 
            // oknosnake
            // 
            oknosnake.Location = new Point(3, -1);
            oknosnake.Name = "oknosnake";
            oknosnake.Size = new Size(394, 387);
            oknosnake.TabIndex = 0;
            oknosnake.TabStop = false;
            oknosnake.Paint += oknosnake_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(451, 13);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "Score:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblScore.Location = new Point(641, 13);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(0, 32);
            lblScore.TabIndex = 2;
            // 
            // gameTimer
            // 
            gameTimer.Tick += timer1_Tick;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.Location = new Point(38, 85);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(38, 15);
            lblGameOver.TabIndex = 3;
            lblGameOver.Text = "label2";
            lblGameOver.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGameOver);
            Controls.Add(lblScore);
            Controls.Add(label1);
            Controls.Add(oknosnake);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)oknosnake).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox oknosnake;
        private Label label1;
        private Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private Label lblGameOver;
    }
}
