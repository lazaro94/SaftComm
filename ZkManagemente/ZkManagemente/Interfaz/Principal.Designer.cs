﻿namespace ZkManagement.Interfaz
{
    partial class btnEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnEmpleados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnRelojes = new System.Windows.Forms.Button();
            this.iconoBandeja = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 78);
            this.panel1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(778, 33);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(779, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnConfig);
            this.panelMenu.Controls.Add(this.btnRelojes);
            this.panelMenu.Location = new System.Drawing.Point(153, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(587, 77);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Empleados";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(58, 16);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(84, 47);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "Configuracion";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnRelojes
            // 
            this.btnRelojes.Location = new System.Drawing.Point(196, 16);
            this.btnRelojes.Name = "btnRelojes";
            this.btnRelojes.Size = new System.Drawing.Size(84, 47);
            this.btnRelojes.TabIndex = 0;
            this.btnRelojes.Text = "Relojes";
            this.btnRelojes.UseVisualStyleBackColor = true;
            this.btnRelojes.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconoBandeja
            // 
            this.iconoBandeja.Icon = ((System.Drawing.Icon)(resources.GetObject("iconoBandeja.Icon")));
            this.iconoBandeja.Text = "notifyIcon1";
            this.iconoBandeja.Visible = true;
            // 
            // btnEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 668);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "btnEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnRelojes;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon iconoBandeja;
    }
}