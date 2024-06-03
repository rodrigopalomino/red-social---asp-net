
namespace Red_Social
{
    partial class Frm_Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Chat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_nombrecon = new System.Windows.Forms.Label();
            this.pnl_infoChats = new System.Windows.Forms.Panel();
            this.pic_FotoinfoPerac = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lblnomcontacinfo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_cerrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_escribirMensaje = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timerAbrir = new System.Windows.Forms.Timer(this.components);
            this.timerCerrar = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerCargarChats = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pnl_infoChats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FotoinfoPerac)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_escribirMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_nombrecon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 75);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(930, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 28);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(889, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 28);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_nombrecon
            // 
            this.lbl_nombrecon.AutoSize = true;
            this.lbl_nombrecon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombrecon.ForeColor = System.Drawing.Color.White;
            this.lbl_nombrecon.Location = new System.Drawing.Point(90, 28);
            this.lbl_nombrecon.Name = "lbl_nombrecon";
            this.lbl_nombrecon.Size = new System.Drawing.Size(51, 20);
            this.lbl_nombrecon.TabIndex = 2;
            this.lbl_nombrecon.Text = "Amor";
            this.lbl_nombrecon.Click += new System.EventHandler(this.lbl_nombrecon_Click);
            // 
            // pnl_infoChats
            // 
            this.pnl_infoChats.BackColor = System.Drawing.Color.White;
            this.pnl_infoChats.Controls.Add(this.pic_FotoinfoPerac);
            this.pnl_infoChats.Controls.Add(this.lblnomcontacinfo);
            this.pnl_infoChats.Controls.Add(this.panel4);
            this.pnl_infoChats.Controls.Add(this.gunaSeparator1);
            this.pnl_infoChats.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_infoChats.Location = new System.Drawing.Point(960, 0);
            this.pnl_infoChats.Name = "pnl_infoChats";
            this.pnl_infoChats.Size = new System.Drawing.Size(0, 635);
            this.pnl_infoChats.TabIndex = 1;
            // 
            // pic_FotoinfoPerac
            // 
            this.pic_FotoinfoPerac.BaseColor = System.Drawing.Color.White;
            this.pic_FotoinfoPerac.Image = ((System.Drawing.Image)(resources.GetObject("pic_FotoinfoPerac.Image")));
            this.pic_FotoinfoPerac.Location = new System.Drawing.Point(31, 81);
            this.pic_FotoinfoPerac.Name = "pic_FotoinfoPerac";
            this.pic_FotoinfoPerac.Size = new System.Drawing.Size(229, 229);
            this.pic_FotoinfoPerac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_FotoinfoPerac.TabIndex = 7;
            this.pic_FotoinfoPerac.TabStop = false;
            this.pic_FotoinfoPerac.UseTransfarantBackground = false;
            // 
            // lblnomcontacinfo
            // 
            this.lblnomcontacinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomcontacinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblnomcontacinfo.Location = new System.Drawing.Point(9, 321);
            this.lblnomcontacinfo.Name = "lblnomcontacinfo";
            this.lblnomcontacinfo.Size = new System.Drawing.Size(267, 30);
            this.lblnomcontacinfo.TabIndex = 6;
            this.lblnomcontacinfo.Text = "Info del Contacto";
            this.lblnomcontacinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.bt_cerrar);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 75);
            this.panel4.TabIndex = 0;
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cerrar.FlatAppearance.BorderSize = 0;
            this.bt_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.bt_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("bt_cerrar.Image")));
            this.bt_cerrar.Location = new System.Drawing.Point(6, 28);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(38, 28);
            this.bt_cerrar.TabIndex = 5;
            this.bt_cerrar.UseVisualStyleBackColor = true;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(59, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "Info del Contacto";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(1, 314);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(275, 10);
            this.gunaSeparator1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.txt_escribirMensaje);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 589);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 46);
            this.panel3.TabIndex = 2;
            // 
            // txt_escribirMensaje
            // 
            this.txt_escribirMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_escribirMensaje.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_escribirMensaje.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.WhiteSmoke;
            this.txt_escribirMensaje.CaptionStyle.CaptionSize = 0;
            this.txt_escribirMensaje.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_escribirMensaje.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_escribirMensaje.CaptionStyle.TextStyle.Text = "elEntryBox2";
            this.txt_escribirMensaje.EditBoxStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_escribirMensaje.EditBoxStyle.BorderStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_escribirMensaje.EditBoxStyle.BorderStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_escribirMensaje.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_escribirMensaje.EditBoxStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_escribirMensaje.EditBoxStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_escribirMensaje.Location = new System.Drawing.Point(103, 9);
            this.txt_escribirMensaje.Name = "txt_escribirMensaje";
            this.txt_escribirMensaje.Size = new System.Drawing.Size(800, 31);
            this.txt_escribirMensaje.TabIndex = 13;
            this.txt_escribirMensaje.ValidationStyle.PasswordChar = '\0';
            this.txt_escribirMensaje.Value = "Escribir Mensaje...";
            this.txt_escribirMensaje.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            this.txt_escribirMensaje.Enter += new System.EventHandler(this.txt_escribirMensaje_Enter);
            this.txt_escribirMensaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_escribirMensaje_KeyPress);
            this.txt_escribirMensaje.Leave += new System.EventHandler(this.txt_escribirMensaje_Leave);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(922, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 35);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(59, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 28);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(12, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 28);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // timerAbrir
            // 
            this.timerAbrir.Interval = 10;
            this.timerAbrir.Tick += new System.EventHandler(this.timerAbrir_Tick);
            // 
            // timerCerrar
            // 
            this.timerCerrar.Interval = 10;
            this.timerCerrar.Tick += new System.EventHandler(this.timerCerrar_Tick);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 514);
            this.panel2.TabIndex = 3;
            // 
            // timerCargarChats
            // 
            this.timerCargarChats.Interval = 5000;
            this.timerCargarChats.Tick += new System.EventHandler(this.timerActualizarChats_Tick);
            // 
            // Frm_Chats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_infoChats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_Chats";
            this.Text = "Frm_Chats";
            this.Load += new System.EventHandler(this.Frm_Chats_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_infoChats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_FotoinfoPerac)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_escribirMensaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_infoChats;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        
        private System.Windows.Forms.Button bt_cerrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblnomcontacinfo;
        
        private System.Windows.Forms.Timer timerAbrir;
        private System.Windows.Forms.Timer timerCerrar;
        public System.Windows.Forms.Label lbl_nombrecon;
        private Guna.UI.WinForms.GunaCirclePictureBox pic_FotoinfoPerac;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Panel panel2;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_escribirMensaje;
        private System.Windows.Forms.Timer timerCargarChats;
    }
}