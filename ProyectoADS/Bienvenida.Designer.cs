namespace Proyecto
{
    partial class Bienvenida
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
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            pcbUDB = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbUDB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.FromArgb(208, 240, 239);
            progressBar1.ForeColor = Color.FromArgb(52, 44, 130);
            progressBar1.Location = new Point(36, 232);
            progressBar1.Margin = new Padding(4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(433, 26);
            progressBar1.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(207, 272);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 16);
            label5.TabIndex = 8;
            label5.Text = "Cargando...";
            // 
            // pcbUDB
            // 
            pcbUDB.BackColor = Color.Transparent;
            pcbUDB.Image = ProyectoADS.Properties.Resources.udb;
            pcbUDB.Location = new Point(409, 12);
            pcbUDB.Margin = new Padding(4);
            pcbUDB.Name = "pcbUDB";
            pcbUDB.Size = new Size(105, 110);
            pcbUDB.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUDB.TabIndex = 11;
            pcbUDB.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Enabled = false;
            pictureBox1.Image = ProyectoADS.Properties.Resources.logo;
            pictureBox1.Location = new Point(11, 3);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 44, 130);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(528, 313);
            Controls.Add(pictureBox1);
            Controls.Add(pcbUDB);
            Controls.Add(label5);
            Controls.Add(progressBar1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Bienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenida";
            Load += Bienvenida_Load;
            ((System.ComponentModel.ISupportInitialize)pcbUDB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label5;
        private PictureBox pcbUDB;
        private PictureBox pictureBox1;
    }
}