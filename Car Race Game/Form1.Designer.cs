namespace Car_Race_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.track1 = new System.Windows.Forms.PictureBox();
            this.track2 = new System.Windows.Forms.PictureBox();
            this.track3 = new System.Windows.Forms.PictureBox();
            this.score_text = new System.Windows.Forms.Label();
            this.gameover = new System.Windows.Forms.Label();
            this.enemy_1 = new System.Windows.Forms.PictureBox();
            this.enemy_2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.speed_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.track1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // track1
            // 
            this.track1.BackColor = System.Drawing.Color.Red;
            this.track1.Location = new System.Drawing.Point(303, 29);
            this.track1.Name = "track1";
            this.track1.Size = new System.Drawing.Size(22, 93);
            this.track1.TabIndex = 0;
            this.track1.TabStop = false;
            this.track1.Click += new System.EventHandler(this.track1_Click);
            // 
            // track2
            // 
            this.track2.BackColor = System.Drawing.Color.Lime;
            this.track2.Location = new System.Drawing.Point(303, 239);
            this.track2.Name = "track2";
            this.track2.Size = new System.Drawing.Size(22, 97);
            this.track2.TabIndex = 1;
            this.track2.TabStop = false;
            // 
            // track3
            // 
            this.track3.BackColor = System.Drawing.Color.Yellow;
            this.track3.Location = new System.Drawing.Point(303, 451);
            this.track3.Name = "track3";
            this.track3.Size = new System.Drawing.Size(22, 89);
            this.track3.TabIndex = 2;
            this.track3.TabStop = false;
            // 
            // score_text
            // 
            this.score_text.AutoSize = true;
            this.score_text.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_text.ForeColor = System.Drawing.Color.DarkOrange;
            this.score_text.Location = new System.Drawing.Point(12, 9);
            this.score_text.Name = "score_text";
            this.score_text.Size = new System.Drawing.Size(70, 35);
            this.score_text.TabIndex = 3;
            this.score_text.Text = "Score";
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover.ForeColor = System.Drawing.Color.DarkOrange;
            this.gameover.Location = new System.Drawing.Point(243, 143);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(198, 50);
            this.gameover.TabIndex = 4;
            this.gameover.Text = "GAMEOVER!..";
            // 
            // enemy_1
            // 
            this.enemy_1.Image = ((System.Drawing.Image)(resources.GetObject("enemy_1.Image")));
            this.enemy_1.Location = new System.Drawing.Point(88, 277);
            this.enemy_1.Name = "enemy_1";
            this.enemy_1.Size = new System.Drawing.Size(64, 72);
            this.enemy_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy_1.TabIndex = 5;
            this.enemy_1.TabStop = false;
            // 
            // enemy_2
            // 
            this.enemy_2.Image = ((System.Drawing.Image)(resources.GetObject("enemy_2.Image")));
            this.enemy_2.Location = new System.Drawing.Point(485, 113);
            this.enemy_2.Name = "enemy_2";
            this.enemy_2.Size = new System.Drawing.Size(64, 72);
            this.enemy_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy_2.TabIndex = 6;
            this.enemy_2.TabStop = false;
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(340, 356);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(64, 72);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 7;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // speed_txt
            // 
            this.speed_txt.AutoSize = true;
            this.speed_txt.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_txt.ForeColor = System.Drawing.Color.YellowGreen;
            this.speed_txt.Location = new System.Drawing.Point(534, 9);
            this.speed_txt.Name = "speed_txt";
            this.speed_txt.Size = new System.Drawing.Size(58, 28);
            this.speed_txt.TabIndex = 8;
            this.speed_txt.Text = "Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(297, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Replay";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.SandyBrown;
            this.exit.Location = new System.Drawing.Point(297, 249);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(65, 35);
            this.exit.TabIndex = 10;
            this.exit.Text = "Close";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(701, 565);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speed_txt);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemy_2);
            this.Controls.Add(this.enemy_1);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.score_text);
            this.Controls.Add(this.track3);
            this.Controls.Add(this.track2);
            this.Controls.Add(this.track1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.track1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox track1;
        private System.Windows.Forms.PictureBox track2;
        private System.Windows.Forms.PictureBox track3;
        private System.Windows.Forms.Label score_text;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.PictureBox enemy_1;
        private System.Windows.Forms.PictureBox enemy_2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label speed_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exit;
    }
}

