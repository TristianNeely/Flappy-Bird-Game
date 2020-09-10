namespace Flappy_Bird_Game
{
    partial class Form1
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
            this.ScoreText = new System.Windows.Forms.Label();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.PipeBottom = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(18, 12);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(215, 56);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score: 0";
            this.ScoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // PipeTop
            // 
            this.PipeTop.Image = global::Flappy_Bird_Game.Properties.Resources.pipedown;
            this.PipeTop.Location = new System.Drawing.Point(646, -408);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(119, 539);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 3;
            this.PipeTop.TabStop = false;
            this.PipeTop.Click += new System.EventHandler(this.PipeTop_Click);
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.Aqua;
            this.Ground.Image = global::Flappy_Bird_Game.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-6, 588);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(818, 78);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 2;
            this.Ground.TabStop = false;
            this.Ground.Click += new System.EventHandler(this.Ground_Click);
            // 
            // PipeBottom
            // 
            this.PipeBottom.Image = global::Flappy_Bird_Game.Properties.Resources.pipe;
            this.PipeBottom.Location = new System.Drawing.Point(527, 464);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(119, 128);
            this.PipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom.TabIndex = 1;
            this.PipeBottom.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.Image = global::Flappy_Bird_Game.Properties.Resources.bird;
            this.FlappyBird.Location = new System.Drawing.Point(68, 223);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(86, 69);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBird.TabIndex = 0;
            this.FlappyBird.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PipeBottom);
            this.Controls.Add(this.FlappyBird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox PipeBottom;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

