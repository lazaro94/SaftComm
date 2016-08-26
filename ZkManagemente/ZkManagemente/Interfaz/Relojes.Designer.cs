﻿namespace ZkManagement.Interfaz
{
    partial class Relojes
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
            this.dgvRelojes = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantRegis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbxRutinas = new System.Windows.Forms.GroupBox();
            this.btnRutinaHora = new System.Windows.Forms.Button();
            this.btnRutinaBajar = new System.Windows.Forms.Button();
            this.groupManuales = new System.Windows.Forms.GroupBox();
            this.btnHora = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.groupABM = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnInicializar = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.groupAvanzadas = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelojes)).BeginInit();
            this.gpbxRutinas.SuspendLayout();
            this.groupManuales.SuspendLayout();
            this.groupABM.SuspendLayout();
            this.groupAvanzadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvRelojes
            // 
            this.dgvRelojes.AllowUserToAddRows = false;
            this.dgvRelojes.AllowUserToOrderColumns = true;
            this.dgvRelojes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelojes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre,
            this.IP,
            this.Puerto,
            this.Estado,
            this.CantRegis,
            this.Modelo,
            this.Mac,
            this.DNS,
            this.Id,
            this.Clave});
            this.dgvRelojes.Location = new System.Drawing.Point(24, 126);
            this.dgvRelojes.MultiSelect = false;
            this.dgvRelojes.Name = "dgvRelojes";
            this.dgvRelojes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelojes.Size = new System.Drawing.Size(839, 215);
            this.dgvRelojes.TabIndex = 0;
            this.dgvRelojes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRelojes_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 80;
            // 
            // IP
            // 
            this.IP.HeaderText = "IP V4";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            this.IP.Width = 80;
            // 
            // Puerto
            // 
            this.Puerto.HeaderText = "Puerto";
            this.Puerto.Name = "Puerto";
            this.Puerto.ReadOnly = true;
            this.Puerto.Width = 50;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // CantRegis
            // 
            this.CantRegis.HeaderText = "Cantidad Registros";
            this.CantRegis.Name = "CantRegis";
            this.CantRegis.ReadOnly = true;
            this.CantRegis.Width = 55;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Mac
            // 
            this.Mac.HeaderText = "Mac Address";
            this.Mac.Name = "Mac";
            this.Mac.ReadOnly = true;
            // 
            // DNS
            // 
            this.DNS.HeaderText = "DNS";
            this.DNS.Name = "DNS";
            this.DNS.Width = 180;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            // 
            // gpbxRutinas
            // 
            this.gpbxRutinas.Controls.Add(this.btnRutinaHora);
            this.gpbxRutinas.Controls.Add(this.btnRutinaBajar);
            this.gpbxRutinas.Location = new System.Drawing.Point(47, 64);
            this.gpbxRutinas.Name = "gpbxRutinas";
            this.gpbxRutinas.Size = new System.Drawing.Size(212, 55);
            this.gpbxRutinas.TabIndex = 1;
            this.gpbxRutinas.TabStop = false;
            this.gpbxRutinas.Text = "Rutinas";
            // 
            // btnRutinaHora
            // 
            this.btnRutinaHora.Location = new System.Drawing.Point(105, 19);
            this.btnRutinaHora.Name = "btnRutinaHora";
            this.btnRutinaHora.Size = new System.Drawing.Size(92, 23);
            this.btnRutinaHora.TabIndex = 1;
            this.btnRutinaHora.Text = "Sinc. Hora";
            this.btnRutinaHora.UseVisualStyleBackColor = true;
            this.btnRutinaHora.Click += new System.EventHandler(this.btnRutinaHora_Click);
            // 
            // btnRutinaBajar
            // 
            this.btnRutinaBajar.Location = new System.Drawing.Point(7, 20);
            this.btnRutinaBajar.Name = "btnRutinaBajar";
            this.btnRutinaBajar.Size = new System.Drawing.Size(92, 23);
            this.btnRutinaBajar.TabIndex = 0;
            this.btnRutinaBajar.Text = "Bajar Registros";
            this.btnRutinaBajar.UseVisualStyleBackColor = true;
            this.btnRutinaBajar.Click += new System.EventHandler(this.btnRutinaBajar_Click);
            // 
            // groupManuales
            // 
            this.groupManuales.Controls.Add(this.btnHora);
            this.groupManuales.Controls.Add(this.btnBorrar);
            this.groupManuales.Controls.Add(this.btnDescargar);
            this.groupManuales.Location = new System.Drawing.Point(537, 64);
            this.groupManuales.Name = "groupManuales";
            this.groupManuales.Size = new System.Drawing.Size(313, 55);
            this.groupManuales.TabIndex = 3;
            this.groupManuales.TabStop = false;
            this.groupManuales.Text = "Operaciones Manuales";
            // 
            // btnHora
            // 
            this.btnHora.Image = global::ZkManagement.Properties.Resources.sinc;
            this.btnHora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHora.Location = new System.Drawing.Point(217, 19);
            this.btnHora.Name = "btnHora";
            this.btnHora.Size = new System.Drawing.Size(83, 23);
            this.btnHora.TabIndex = 2;
            this.btnHora.Text = "Sinc. Hora";
            this.btnHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHora.UseVisualStyleBackColor = true;
            this.btnHora.Click += new System.EventHandler(this.btnHora_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Image = global::ZkManagement.Properties.Resources.basura;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(114, 20);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(86, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar Regs";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Image = global::ZkManagement.Properties.Resources.download;
            this.btnDescargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescargar.Location = new System.Drawing.Point(18, 20);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(83, 23);
            this.btnDescargar.TabIndex = 0;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Image = global::ZkManagement.Properties.Resources.poweron;
            this.btnConectar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConectar.Location = new System.Drawing.Point(300, 75);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(98, 45);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Image = global::ZkManagement.Properties.Resources.poweroff;
            this.btnDesconectar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDesconectar.Location = new System.Drawing.Point(422, 75);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(98, 45);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // groupABM
            // 
            this.groupABM.Controls.Add(this.btnEliminar);
            this.groupABM.Controls.Add(this.btnEditar);
            this.groupABM.Controls.Add(this.btnAgregar);
            this.groupABM.Enabled = false;
            this.groupABM.Location = new System.Drawing.Point(560, 347);
            this.groupABM.Name = "groupABM";
            this.groupABM.Size = new System.Drawing.Size(290, 47);
            this.groupABM.TabIndex = 4;
            this.groupABM.TabStop = false;
            this.groupABM.Text = "Editar Equipos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ZkManagement.Properties.Resources.delete;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(200, 17);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::ZkManagement.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(108, 17);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::ZkManagement.Properties.Resources._new;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(6, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(21, 16);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(116, 23);
            this.btnReiniciar.TabIndex = 8;
            this.btnReiniciar.Text = "Reiniciar Dispositivo";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnInicializar
            // 
            this.btnInicializar.Location = new System.Drawing.Point(179, 16);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(115, 23);
            this.btnInicializar.TabIndex = 9;
            this.btnInicializar.Text = "Inicializar Dispositivo";
            this.btnInicializar.UseVisualStyleBackColor = true;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(332, 16);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(109, 23);
            this.btnAdmin.TabIndex = 10;
            this.btnAdmin.Text = "Eliminar Admins.";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // groupAvanzadas
            // 
            this.groupAvanzadas.Controls.Add(this.btnReiniciar);
            this.groupAvanzadas.Controls.Add(this.btnAdmin);
            this.groupAvanzadas.Controls.Add(this.btnInicializar);
            this.groupAvanzadas.Enabled = false;
            this.groupAvanzadas.Location = new System.Drawing.Point(54, 347);
            this.groupAvanzadas.Name = "groupAvanzadas";
            this.groupAvanzadas.Size = new System.Drawing.Size(457, 47);
            this.groupAvanzadas.TabIndex = 11;
            this.groupAvanzadas.TabStop = false;
            this.groupAvanzadas.Text = "Avanzadas";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(197, 407);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(485, 134);
            this.rtbLog.TabIndex = 12;
            this.rtbLog.Text = "";
            // 
            // Relojes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 550);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.groupAvanzadas);
            this.Controls.Add(this.groupABM);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.groupManuales);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.gpbxRutinas);
            this.Controls.Add(this.dgvRelojes);
            this.Name = "Relojes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relojes";
            this.Load += new System.EventHandler(this.Relojes_Load);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.dgvRelojes, 0);
            this.Controls.SetChildIndex(this.gpbxRutinas, 0);
            this.Controls.SetChildIndex(this.btnConectar, 0);
            this.Controls.SetChildIndex(this.groupManuales, 0);
            this.Controls.SetChildIndex(this.btnDesconectar, 0);
            this.Controls.SetChildIndex(this.groupABM, 0);
            this.Controls.SetChildIndex(this.groupAvanzadas, 0);
            this.Controls.SetChildIndex(this.rtbLog, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelojes)).EndInit();
            this.gpbxRutinas.ResumeLayout(false);
            this.groupManuales.ResumeLayout(false);
            this.groupABM.ResumeLayout(false);
            this.groupAvanzadas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelojes;
        private System.Windows.Forms.GroupBox gpbxRutinas;
        private System.Windows.Forms.Button btnRutinaHora;
        private System.Windows.Forms.Button btnRutinaBajar;
        private System.Windows.Forms.GroupBox groupManuales;
        private System.Windows.Forms.Button btnHora;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.GroupBox groupABM;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantRegis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mac;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnInicializar;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.GroupBox groupAvanzadas;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}