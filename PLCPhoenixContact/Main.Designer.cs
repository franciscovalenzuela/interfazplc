namespace PLCPhoenixContact
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtvalor2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvar2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.runit32 = new System.Windows.Forms.RadioButton();
            this.ruint16 = new System.Windows.Forms.RadioButton();
            this.rint32 = new System.Windows.Forms.RadioButton();
            this.rbool = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvar1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.Escribir = new System.Windows.Forms.Button();
            this.Leer = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.txtvalor2);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.txtvar2);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.Escribir);
            this.groupBox8.Controls.Add(this.runit32);
            this.groupBox8.Controls.Add(this.ruint16);
            this.groupBox8.Controls.Add(this.rint32);
            this.groupBox8.Controls.Add(this.rbool);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(12, 378);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(415, 232);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Set";
            // 
            // txtvalor2
            // 
            this.txtvalor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor2.Location = new System.Drawing.Point(136, 60);
            this.txtvalor2.Name = "txtvalor2";
            this.txtvalor2.Size = new System.Drawing.Size(243, 29);
            this.txtvalor2.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Valor:";
            // 
            // txtvar2
            // 
            this.txtvar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvar2.Location = new System.Drawing.Point(136, 25);
            this.txtvar2.Name = "txtvar2";
            this.txtvar2.Size = new System.Drawing.Size(243, 29);
            this.txtvar2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Variable:";
            // 
            // runit32
            // 
            this.runit32.AutoSize = true;
            this.runit32.Location = new System.Drawing.Point(301, 125);
            this.runit32.Name = "runit32";
            this.runit32.Size = new System.Drawing.Size(78, 24);
            this.runit32.TabIndex = 12;
            this.runit32.TabStop = true;
            this.runit32.Text = "Uint 32";
            this.runit32.UseVisualStyleBackColor = true;
            // 
            // ruint16
            // 
            this.ruint16.AutoSize = true;
            this.ruint16.Location = new System.Drawing.Point(136, 125);
            this.ruint16.Name = "ruint16";
            this.ruint16.Size = new System.Drawing.Size(78, 24);
            this.ruint16.TabIndex = 11;
            this.ruint16.TabStop = true;
            this.ruint16.Text = "Uint 16";
            this.ruint16.UseVisualStyleBackColor = true;
            // 
            // rint32
            // 
            this.rint32.AutoSize = true;
            this.rint32.Location = new System.Drawing.Point(301, 95);
            this.rint32.Name = "rint32";
            this.rint32.Size = new System.Drawing.Size(68, 24);
            this.rint32.TabIndex = 10;
            this.rint32.TabStop = true;
            this.rint32.Text = "Int 32";
            this.rint32.UseVisualStyleBackColor = true;
            // 
            // rbool
            // 
            this.rbool.AutoSize = true;
            this.rbool.Checked = true;
            this.rbool.Location = new System.Drawing.Point(136, 95);
            this.rbool.Name = "rbool";
            this.rbool.Size = new System.Drawing.Size(59, 24);
            this.rbool.TabIndex = 9;
            this.rbool.TabStop = true;
            this.rbool.Text = "Bool";
            this.rbool.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.txttipo);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.txtvalor1);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.Leer);
            this.groupBox7.Controls.Add(this.txtvar1);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(12, 139);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(415, 233);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Get";
            // 
            // txttipo
            // 
            this.txttipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo.Location = new System.Drawing.Point(136, 107);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(243, 29);
            this.txttipo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo:";
            // 
            // txtvalor1
            // 
            this.txtvalor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor1.Location = new System.Drawing.Point(136, 67);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(243, 29);
            this.txtvalor1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Valor:";
            // 
            // txtvar1
            // 
            this.txtvar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvar1.Location = new System.Drawing.Point(136, 25);
            this.txtvar1.Name = "txtvar1";
            this.txtvar1.Size = new System.Drawing.Size(243, 29);
            this.txtvar1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Variable:";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(128, 15);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(243, 29);
            this.txtIP.TabIndex = 4;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado PLC:";
            // 
            // txtestado
            // 
            this.txtestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestado.Location = new System.Drawing.Point(128, 63);
            this.txtestado.Name = "txtestado";
            this.txtestado.ReadOnly = true;
            this.txtestado.Size = new System.Drawing.Size(243, 29);
            this.txtestado.TabIndex = 6;
            // 
            // btnstop
            // 
            this.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.ForeColor = System.Drawing.Color.White;
            this.btnstop.Image = global::PLCPhoenixContact.Properties.Resources.cancelar2;
            this.btnstop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstop.Location = new System.Drawing.Point(270, 98);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(101, 35);
            this.btnstop.TabIndex = 12;
            this.btnstop.Text = "Stop";
            this.btnstop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnstart
            // 
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.Color.White;
            this.btnstart.Image = global::PLCPhoenixContact.Properties.Resources.aceptar3;
            this.btnstart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstart.Location = new System.Drawing.Point(128, 98);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(98, 35);
            this.btnstart.TabIndex = 11;
            this.btnstart.Text = "Start";
            this.btnstart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // Escribir
            // 
            this.Escribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Escribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Escribir.ForeColor = System.Drawing.Color.White;
            this.Escribir.Image = global::PLCPhoenixContact.Properties.Resources.up_arrow;
            this.Escribir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Escribir.Location = new System.Drawing.Point(136, 155);
            this.Escribir.Name = "Escribir";
            this.Escribir.Size = new System.Drawing.Size(243, 59);
            this.Escribir.TabIndex = 13;
            this.Escribir.Text = "Subir Cambios";
            this.Escribir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Escribir.UseVisualStyleBackColor = true;
            this.Escribir.Click += new System.EventHandler(this.Escribir_Click);
            // 
            // Leer
            // 
            this.Leer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Leer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leer.ForeColor = System.Drawing.Color.White;
            this.Leer.Image = global::PLCPhoenixContact.Properties.Resources.down_arrow;
            this.Leer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Leer.Location = new System.Drawing.Point(136, 155);
            this.Leer.Name = "Leer";
            this.Leer.Size = new System.Drawing.Size(243, 59);
            this.Leer.TabIndex = 6;
            this.Leer.Text = "Bajar Cambios";
            this.Leer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Leer.UseVisualStyleBackColor = true;
            this.Leer.Click += new System.EventHandler(this.Leer_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(439, 618);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Phoenix Contact";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtvalor2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvar2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Escribir;
        private System.Windows.Forms.RadioButton runit32;
        private System.Windows.Forms.RadioButton ruint16;
        private System.Windows.Forms.RadioButton rint32;
        private System.Windows.Forms.RadioButton rbool;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Leer;
        private System.Windows.Forms.TextBox txtvar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

