namespace Proyecto
{
    partial class Programador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOnButtonPosition = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btncaso = new System.Windows.Forms.Button();
            this.bitacora = new System.Windows.Forms.Button();
            this.lblAcercaDe = new System.Windows.Forms.Label();
            this.panelCaso = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.actualizar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDcasos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelbitacora = new System.Windows.Forms.Panel();
            this.gbBitacoras = new System.Windows.Forms.GroupBox();
            this.dgvBitacoras = new System.Windows.Forms.DataGridView();
            this.lblEstadobitacora = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Enviar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.refrescar = new System.Windows.Forms.Button();
            this.cbxbitacoraid = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panelCaso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelbitacora.SuspendLayout();
            this.gbBitacoras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoras)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.pnlOnButtonPosition);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.btncaso);
            this.panel1.Controls.Add(this.bitacora);
            this.panel1.Controls.Add(this.lblAcercaDe);
            this.panel1.Location = new System.Drawing.Point(1, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 660);
            this.panel1.TabIndex = 0;
            // 
            // pnlOnButtonPosition
            // 
            this.pnlOnButtonPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(87)))));
            this.pnlOnButtonPosition.Location = new System.Drawing.Point(0, 134);
            this.pnlOnButtonPosition.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOnButtonPosition.Name = "pnlOnButtonPosition";
            this.pnlOnButtonPosition.Size = new System.Drawing.Size(17, 65);
            this.pnlOnButtonPosition.TabIndex = 4;
            // 
            // btncerrar
            // 
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btncerrar.Location = new System.Drawing.Point(11, 340);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(148, 52);
            this.btncerrar.TabIndex = 3;
            this.btncerrar.Text = "Cerrar Sesión";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btncaso
            // 
            this.btncaso.FlatAppearance.BorderSize = 0;
            this.btncaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btncaso.Location = new System.Drawing.Point(4, 134);
            this.btncaso.Margin = new System.Windows.Forms.Padding(4);
            this.btncaso.Name = "btncaso";
            this.btncaso.Size = new System.Drawing.Size(155, 65);
            this.btncaso.TabIndex = 2;
            this.btncaso.Text = "Caso";
            this.btncaso.UseVisualStyleBackColor = true;
            this.btncaso.Click += new System.EventHandler(this.btncaso_Click);
            // 
            // bitacora
            // 
            this.bitacora.FlatAppearance.BorderSize = 0;
            this.bitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitacora.Location = new System.Drawing.Point(4, 236);
            this.bitacora.Margin = new System.Windows.Forms.Padding(4);
            this.bitacora.Name = "bitacora";
            this.bitacora.Size = new System.Drawing.Size(155, 57);
            this.bitacora.TabIndex = 1;
            this.bitacora.Text = "Bitácora";
            this.bitacora.UseVisualStyleBackColor = true;
            this.bitacora.Click += new System.EventHandler(this.bitacora_Click);
            // 
            // lblAcercaDe
            // 
            this.lblAcercaDe.AutoSize = true;
            this.lblAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcercaDe.Location = new System.Drawing.Point(15, 626);
            this.lblAcercaDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcercaDe.Name = "lblAcercaDe";
            this.lblAcercaDe.Size = new System.Drawing.Size(89, 20);
            this.lblAcercaDe.TabIndex = 0;
            this.lblAcercaDe.Text = "Versión 1.0";
            this.lblAcercaDe.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelCaso
            // 
            this.panelCaso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(87)))));
            this.panelCaso.Controls.Add(this.lblEstado);
            this.panelCaso.Controls.Add(this.label10);
            this.panelCaso.Controls.Add(this.actualizar);
            this.panelCaso.Controls.Add(this.numericUpDown1);
            this.panelCaso.Controls.Add(this.label8);
            this.panelCaso.Controls.Add(this.groupBox2);
            this.panelCaso.Controls.Add(this.label6);
            this.panelCaso.Controls.Add(this.groupBox1);
            this.panelCaso.Controls.Add(this.dateTimePicker1);
            this.panelCaso.Controls.Add(this.progressBar1);
            this.panelCaso.Controls.Add(this.label7);
            this.panelCaso.Controls.Add(this.label5);
            this.panelCaso.Controls.Add(this.label3);
            this.panelCaso.Controls.Add(this.IDcasos);
            this.panelCaso.Controls.Add(this.label2);
            this.panelCaso.Location = new System.Drawing.Point(168, 13);
            this.panelCaso.Margin = new System.Windows.Forms.Padding(4);
            this.panelCaso.Name = "panelCaso";
            this.panelCaso.Size = new System.Drawing.Size(592, 654);
            this.panelCaso.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(113, 610);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 18);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "label12";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(24, 610);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Estado:";
            // 
            // actualizar
            // 
            this.actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(206)))));
            this.actualizar.FlatAppearance.BorderSize = 0;
            this.actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar.ForeColor = System.Drawing.Color.White;
            this.actualizar.Location = new System.Drawing.Point(449, 256);
            this.actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(100, 28);
            this.actualizar.TabIndex = 4;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = false;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(261, 257);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(347, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "%";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(28, 116);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(521, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(504, 100);
            this.label4.TabIndex = 3;
            this.label4.Text = "Label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(157, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(28, 341);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(521, 199);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observaciones";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(497, 167);
            this.label11.TabIndex = 11;
            this.label11.Text = "label11";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 569);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 293);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(523, 28);
            this.progressBar1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 569);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha límite:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Porcentaje de avance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Solicitud:";
            // 
            // IDcasos
            // 
            this.IDcasos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDcasos.FormattingEnabled = true;
            this.IDcasos.Location = new System.Drawing.Point(161, 31);
            this.IDcasos.Margin = new System.Windows.Forms.Padding(4);
            this.IDcasos.Name = "IDcasos";
            this.IDcasos.Size = new System.Drawing.Size(189, 24);
            this.IDcasos.TabIndex = 0;
            this.IDcasos.SelectedIndexChanged += new System.EventHandler(this.IDcasos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Caso";
            // 
            // panelbitacora
            // 
            this.panelbitacora.Controls.Add(this.gbBitacoras);
            this.panelbitacora.Controls.Add(this.lblEstadobitacora);
            this.panelbitacora.Controls.Add(this.label13);
            this.panelbitacora.Controls.Add(this.Enviar);
            this.panelbitacora.Controls.Add(this.groupBox3);
            this.panelbitacora.Controls.Add(this.refrescar);
            this.panelbitacora.Controls.Add(this.cbxbitacoraid);
            this.panelbitacora.Controls.Add(this.label9);
            this.panelbitacora.Location = new System.Drawing.Point(176, 7);
            this.panelbitacora.Margin = new System.Windows.Forms.Padding(4);
            this.panelbitacora.Name = "panelbitacora";
            this.panelbitacora.Size = new System.Drawing.Size(569, 644);
            this.panelbitacora.TabIndex = 4;
            // 
            // gbBitacoras
            // 
            this.gbBitacoras.Controls.Add(this.dgvBitacoras);
            this.gbBitacoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBitacoras.ForeColor = System.Drawing.Color.White;
            this.gbBitacoras.Location = new System.Drawing.Point(19, 128);
            this.gbBitacoras.Margin = new System.Windows.Forms.Padding(4);
            this.gbBitacoras.Name = "gbBitacoras";
            this.gbBitacoras.Padding = new System.Windows.Forms.Padding(4);
            this.gbBitacoras.Size = new System.Drawing.Size(533, 254);
            this.gbBitacoras.TabIndex = 27;
            this.gbBitacoras.TabStop = false;
            this.gbBitacoras.Text = "Bitácoras";
            // 
            // dgvBitacoras
            // 
            this.dgvBitacoras.AllowUserToAddRows = false;
            this.dgvBitacoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBitacoras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBitacoras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(87)))));
            this.dgvBitacoras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBitacoras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBitacoras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBitacoras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBitacoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacoras.EnableHeadersVisualStyles = false;
            this.dgvBitacoras.Location = new System.Drawing.Point(8, 22);
            this.dgvBitacoras.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBitacoras.Name = "dgvBitacoras";
            this.dgvBitacoras.ReadOnly = true;
            this.dgvBitacoras.RowHeadersVisible = false;
            this.dgvBitacoras.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(130)))));
            this.dgvBitacoras.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBitacoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacoras.Size = new System.Drawing.Size(516, 224);
            this.dgvBitacoras.TabIndex = 26;
            // 
            // lblEstadobitacora
            // 
            this.lblEstadobitacora.AutoSize = true;
            this.lblEstadobitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadobitacora.ForeColor = System.Drawing.Color.White;
            this.lblEstadobitacora.Location = new System.Drawing.Point(104, 86);
            this.lblEstadobitacora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadobitacora.Name = "lblEstadobitacora";
            this.lblEstadobitacora.Size = new System.Drawing.Size(54, 18);
            this.lblEstadobitacora.TabIndex = 25;
            this.lblEstadobitacora.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(15, 86);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Estado:";
            // 
            // Enviar
            // 
            this.Enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(206)))));
            this.Enviar.FlatAppearance.BorderSize = 0;
            this.Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enviar.ForeColor = System.Drawing.Color.White;
            this.Enviar.Location = new System.Drawing.Point(447, 599);
            this.Enviar.Margin = new System.Windows.Forms.Padding(4);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(104, 41);
            this.Enviar.TabIndex = 9;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = false;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(17, 389);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(533, 203);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actualizar bitácora:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(87)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(9, 25);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(492, 171);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.Text = "Ingrese una descripción ...";
            this.txtDescripcion.Click += new System.EventHandler(this.txtDescripcion_Click);
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbdescripcion_KeyPress);
            // 
            // refrescar
            // 
            this.refrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(206)))));
            this.refrescar.FlatAppearance.BorderSize = 0;
            this.refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refrescar.ForeColor = System.Drawing.Color.White;
            this.refrescar.Location = new System.Drawing.Point(307, 9);
            this.refrescar.Margin = new System.Windows.Forms.Padding(4);
            this.refrescar.Name = "refrescar";
            this.refrescar.Size = new System.Drawing.Size(100, 28);
            this.refrescar.TabIndex = 7;
            this.refrescar.Text = "Refrescar";
            this.refrescar.UseVisualStyleBackColor = false;
            this.refrescar.Visible = false;
            // 
            // cbxbitacoraid
            // 
            this.cbxbitacoraid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxbitacoraid.FormattingEnabled = true;
            this.cbxbitacoraid.Location = new System.Drawing.Point(105, 30);
            this.cbxbitacoraid.Margin = new System.Windows.Forms.Padding(4);
            this.cbxbitacoraid.Name = "cbxbitacoraid";
            this.cbxbitacoraid.Size = new System.Drawing.Size(160, 24);
            this.cbxbitacoraid.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "ID Caso:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Programador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(764, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCaso);
            this.Controls.Add(this.panelbitacora);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Programador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCaso.ResumeLayout(false);
            this.panelCaso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panelbitacora.ResumeLayout(false);
            this.panelbitacora.PerformLayout();
            this.gbBitacoras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoras)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAcercaDe;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btncaso;
        private System.Windows.Forms.Button bitacora;
        private System.Windows.Forms.Panel panelCaso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IDcasos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelbitacora;
        private System.Windows.Forms.ComboBox cbxbitacoraid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button refrescar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button Enviar;
        internal System.Windows.Forms.Panel pnlOnButtonPosition;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblEstadobitacora;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvBitacoras;
        private System.Windows.Forms.GroupBox gbBitacoras;
    }
}