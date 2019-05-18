namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ball = new System.Windows.Forms.PictureBox();
            this.slide = new System.Windows.Forms.PictureBox();
            this.vert = new System.Windows.Forms.Timer(this.components);
            this.horz = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.key_watch = new System.Windows.Forms.Timer(this.components);
            this.pblpaused = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pblpaused.SuspendLayout();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(2, 1);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(51, 50);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // slide
            // 
            this.slide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.slide.BackColor = System.Drawing.SystemColors.HotTrack;
            this.slide.Location = new System.Drawing.Point(255, 440);
            this.slide.Name = "slide";
            this.slide.Size = new System.Drawing.Size(155, 13);
            this.slide.TabIndex = 1;
            this.slide.TabStop = false;
            // 
            // vert
            // 
            this.vert.Enabled = true;
            this.vert.Interval = 1;
            this.vert.Tick += new System.EventHandler(this.vert_Tick);
            // 
            // horz
            // 
            this.horz.Enabled = true;
            this.horz.Interval = 1;
            this.horz.Tick += new System.EventHandler(this.horz_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(764, 417);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // key_watch
            // 
            this.key_watch.Enabled = true;
            this.key_watch.Tick += new System.EventHandler(this.key_watch_Tick);
            // 
            // pblpaused
            // 
            this.pblpaused.Controls.Add(this.label1);
            this.pblpaused.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblpaused.Location = new System.Drawing.Point(0, 0);
            this.pblpaused.Name = "pblpaused";
            this.pblpaused.Size = new System.Drawing.Size(800, 51);
            this.pblpaused.TabIndex = 3;
            this.pblpaused.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Paused";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pblpaused);
            this.Controls.Add(this.slide);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "pic";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pblpaused.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox slide;
        private System.Windows.Forms.Timer vert;
        private System.Windows.Forms.Timer horz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer key_watch;
        private System.Windows.Forms.Panel pblpaused;
        private System.Windows.Forms.Label label1;
    }
}

