namespace gra
{
    partial class flappybird
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
            this.components = new System.ComponentModel.Container();
            this.ground = new System.Windows.Forms.PictureBox();
            this.down = new System.Windows.Forms.PictureBox();
            this.up = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.gamescore = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Moccasin;
            this.ground.Image = global::gra.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-14, 594);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(593, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // down
            // 
            this.down.Image = global::gra.Properties.Resources.pipe;
            this.down.Location = new System.Drawing.Point(307, 392);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(100, 202);
            this.down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.down.TabIndex = 2;
            this.down.TabStop = false;
            // 
            // up
            // 
            this.up.Image = global::gra.Properties.Resources.pipedown;
            this.up.Location = new System.Drawing.Point(410, -1);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(100, 222);
            this.up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.up.TabIndex = 1;
            this.up.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::gra.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(181, 271);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(74, 59);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // gamescore
            // 
            this.gamescore.AutoSize = true;
            this.gamescore.BackColor = System.Drawing.Color.Ivory;
            this.gamescore.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gamescore.Location = new System.Drawing.Point(-1, 610);
            this.gamescore.Name = "gamescore";
            this.gamescore.Size = new System.Drawing.Size(134, 34);
            this.gamescore.TabIndex = 4;
            this.gamescore.Text = "score : 0";
            this.gamescore.Click += new System.EventHandler(this.label1_Click);
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // flappybird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(577, 640);
            this.Controls.Add(this.gamescore);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.bird);
            this.Name = "flappybird";
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox up;
        private System.Windows.Forms.PictureBox down;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label gamescore;
        private System.Windows.Forms.Timer gametimer;
    }
}