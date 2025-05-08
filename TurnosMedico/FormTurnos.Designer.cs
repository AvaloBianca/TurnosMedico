namespace TurnosMedico
{
    partial class FormTurnos
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblcelular = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.btagendar = new System.Windows.Forms.Button();
            this.btverlista = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.lbldia = new System.Windows.Forms.Label();
            this.lblturno = new System.Windows.Forms.Label();
            this.lblhorario = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.cbxdias = new System.Windows.Forms.ComboBox();
            this.cbxturno = new System.Windows.Forms.ComboBox();
            this.cbxhorarios = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(38, 48);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(38, 102);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(44, 13);
            this.lblapellido.TabIndex = 1;
            this.lblapellido.Text = "Apellido";
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Location = new System.Drawing.Point(43, 176);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(39, 13);
            this.lblcelular.TabIndex = 2;
            this.lblcelular.Text = "Celular";
            this.lblcelular.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Location = new System.Drawing.Point(44, 233);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(26, 13);
            this.lbldni.TabIndex = 3;
            this.lbldni.Text = "DNI";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(45, 69);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(180, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(46, 125);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(178, 20);
            this.txtapellido.TabIndex = 5;
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(49, 199);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(175, 20);
            this.txtcelular.TabIndex = 6;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(51, 266);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(172, 20);
            this.txtdni.TabIndex = 7;
            // 
            // btagendar
            // 
            this.btagendar.Location = new System.Drawing.Point(633, 68);
            this.btagendar.Name = "btagendar";
            this.btagendar.Size = new System.Drawing.Size(118, 20);
            this.btagendar.TabIndex = 8;
            this.btagendar.Text = "AGENDAR";
            this.btagendar.UseVisualStyleBackColor = true;
            this.btagendar.Click += new System.EventHandler(this.btagendar_Click);
            // 
            // btverlista
            // 
            this.btverlista.Location = new System.Drawing.Point(635, 120);
            this.btverlista.Name = "btverlista";
            this.btverlista.Size = new System.Drawing.Size(115, 24);
            this.btverlista.TabIndex = 9;
            this.btverlista.Text = "VER LISTA";
            this.btverlista.UseVisualStyleBackColor = true;
            this.btverlista.Click += new System.EventHandler(this.btverlista_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(640, 174);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(109, 25);
            this.bteliminar.TabIndex = 10;
            this.bteliminar.Text = "ELIMINAR";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Location = new System.Drawing.Point(367, 47);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(28, 13);
            this.lbldia.TabIndex = 11;
            this.lbldia.Text = "Dias";
            // 
            // lblturno
            // 
            this.lblturno.AutoSize = true;
            this.lblturno.Location = new System.Drawing.Point(366, 110);
            this.lblturno.Name = "lblturno";
            this.lblturno.Size = new System.Drawing.Size(35, 13);
            this.lblturno.TabIndex = 12;
            this.lblturno.Text = "Turno";
            // 
            // lblhorario
            // 
            this.lblhorario.AutoSize = true;
            this.lblhorario.Location = new System.Drawing.Point(359, 195);
            this.lblhorario.Name = "lblhorario";
            this.lblhorario.Size = new System.Drawing.Size(46, 13);
            this.lblhorario.TabIndex = 13;
            this.lblhorario.Text = "Horarios";
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(54, 318);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(389, 91);
            this.DGV.TabIndex = 17;
            // 
            // cbxdias
            // 
            this.cbxdias.FormattingEnabled = true;
            this.cbxdias.Location = new System.Drawing.Point(378, 67);
            this.cbxdias.Name = "cbxdias";
            this.cbxdias.Size = new System.Drawing.Size(186, 21);
            this.cbxdias.TabIndex = 18;
            // 
            // cbxturno
            // 
            this.cbxturno.FormattingEnabled = true;
            this.cbxturno.Location = new System.Drawing.Point(379, 135);
            this.cbxturno.Name = "cbxturno";
            this.cbxturno.Size = new System.Drawing.Size(184, 21);
            this.cbxturno.TabIndex = 19;
            // 
            // cbxhorarios
            // 
            this.cbxhorarios.FormattingEnabled = true;
            this.cbxhorarios.Location = new System.Drawing.Point(379, 225);
            this.cbxhorarios.Name = "cbxhorarios";
            this.cbxhorarios.Size = new System.Drawing.Size(185, 21);
            this.cbxhorarios.TabIndex = 20;
            // 
            // FormTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxhorarios);
            this.Controls.Add(this.cbxturno);
            this.Controls.Add(this.cbxdias);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.lblhorario);
            this.Controls.Add(this.lblturno);
            this.Controls.Add(this.lbldia);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.btverlista);
            this.Controls.Add(this.btagendar);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbldni);
            this.Controls.Add(this.lblcelular);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Name = "FormTurnos";
            this.Text = "FormTurnos";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Button btagendar;
        private System.Windows.Forms.Button btverlista;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Label lbldia;
        private System.Windows.Forms.Label lblturno;
        private System.Windows.Forms.Label lblhorario;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.ComboBox cbxdias;
        private System.Windows.Forms.ComboBox cbxturno;
        private System.Windows.Forms.ComboBox cbxhorarios;
    }
}