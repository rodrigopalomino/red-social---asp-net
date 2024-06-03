
namespace Red_Social
{
    partial class Frm_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.pnl_Chats = new System.Windows.Forms.Panel();
            this.pnl_buscar = new System.Windows.Forms.Panel();
            this.txt_buscarUseChat = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_InfoPer = new System.Windows.Forms.Panel();
            this.pic_FotoinfoPer = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.timerAbrir = new System.Windows.Forms.Timer(this.components);
            this.timerCerrar = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timerActualizarChats = new System.Windows.Forms.Timer(this.components);
            this.pnl_titulo.SuspendLayout();
            this.pnl_Chats.SuspendLayout();
            this.pnl_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_buscarUseChat)).BeginInit();
            this.pnl_InfoPer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FotoinfoPer)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_titulo.Controls.Add(this.label2);
            this.pnl_titulo.Controls.Add(this.gunaControlBox2);
            this.pnl_titulo.Controls.Add(this.gunaControlBox1);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1280, 30);
            this.pnl_titulo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Red Social MisofMava";
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1196, 1);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.DimGray;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1233, 1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.DimGray;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // pnl_Chats
            // 
            this.pnl_Chats.AutoScroll = true;
            this.pnl_Chats.BackColor = System.Drawing.Color.White;
            this.pnl_Chats.Controls.Add(this.pnl_buscar);
            this.pnl_Chats.Controls.Add(this.panel1);
            this.pnl_Chats.Controls.Add(this.pnl_InfoPer);
            this.pnl_Chats.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Chats.Location = new System.Drawing.Point(0, 30);
            this.pnl_Chats.Name = "pnl_Chats";
            this.pnl_Chats.Size = new System.Drawing.Size(320, 635);
            this.pnl_Chats.TabIndex = 1;
            // 
            // pnl_buscar
            // 
            this.pnl_buscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_buscar.Controls.Add(this.txt_buscarUseChat);
            this.pnl_buscar.Controls.Add(this.gunaSeparator2);
            this.pnl_buscar.Controls.Add(this.gunaSeparator1);
            this.pnl_buscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_buscar.Location = new System.Drawing.Point(0, 75);
            this.pnl_buscar.Name = "pnl_buscar";
            this.pnl_buscar.Size = new System.Drawing.Size(320, 51);
            this.pnl_buscar.TabIndex = 2;
            // 
            // txt_buscarUseChat
            // 
            this.txt_buscarUseChat.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_buscarUseChat.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.Gray;
            this.txt_buscarUseChat.CaptionStyle.CaptionSize = 0;
            this.txt_buscarUseChat.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_buscarUseChat.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_buscarUseChat.CaptionStyle.TextStyle.Text = "elEntryBox2";
            this.txt_buscarUseChat.EditBoxStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_buscarUseChat.EditBoxStyle.BorderStyle.GradientEndColor = System.Drawing.Color.WhiteSmoke;
            this.txt_buscarUseChat.EditBoxStyle.BorderStyle.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.txt_buscarUseChat.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.WhiteSmoke;
            this.txt_buscarUseChat.EditBoxStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarUseChat.EditBoxStyle.ForeColor = System.Drawing.Color.DimGray;
            this.txt_buscarUseChat.Location = new System.Drawing.Point(8, 9);
            this.txt_buscarUseChat.Name = "txt_buscarUseChat";
            this.txt_buscarUseChat.Size = new System.Drawing.Size(302, 31);
            this.txt_buscarUseChat.TabIndex = 1;
            this.txt_buscarUseChat.ValidationStyle.PasswordChar = '\0';
            this.txt_buscarUseChat.Value = "Buscar...";
            this.txt_buscarUseChat.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            this.txt_buscarUseChat.Enter += new System.EventHandler(this.txt_buscarUseChat_Enter);
            this.txt_buscarUseChat.Leave += new System.EventHandler(this.txt_buscarUseChat_Leave);
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaSeparator2.LineColor = System.Drawing.Color.LightGray;
            this.gunaSeparator2.Location = new System.Drawing.Point(0, 0);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(320, 10);
            this.gunaSeparator2.TabIndex = 11;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaSeparator1.LineColor = System.Drawing.Color.LightGray;
            this.gunaSeparator1.Location = new System.Drawing.Point(0, 41);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(320, 10);
            this.gunaSeparator1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 75);
            this.panel1.TabIndex = 1;
            // 
            // pnl_InfoPer
            // 
            this.pnl_InfoPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_InfoPer.Controls.Add(this.pic_FotoinfoPer);
            this.pnl_InfoPer.Controls.Add(this.label13);
            this.pnl_InfoPer.Controls.Add(this.panel7);
            this.pnl_InfoPer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_InfoPer.Location = new System.Drawing.Point(0, 0);
            this.pnl_InfoPer.Name = "pnl_InfoPer";
            this.pnl_InfoPer.Size = new System.Drawing.Size(0, 635);
            this.pnl_InfoPer.TabIndex = 0;
            // 
            // pic_FotoinfoPer
            // 
            this.pic_FotoinfoPer.BaseColor = System.Drawing.Color.White;
            this.pic_FotoinfoPer.Image = ((System.Drawing.Image)(resources.GetObject("pic_FotoinfoPer.Image")));
            this.pic_FotoinfoPer.Location = new System.Drawing.Point(33, 81);
            this.pic_FotoinfoPer.Name = "pic_FotoinfoPer";
            this.pic_FotoinfoPer.Size = new System.Drawing.Size(229, 229);
            this.pic_FotoinfoPer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_FotoinfoPer.TabIndex = 5;
            this.pic_FotoinfoPer.TabStop = false;
            this.pic_FotoinfoPer.UseTransfarantBackground = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(97, 331);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "Mi Perfil";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 75);
            this.panel7.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(8, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 28);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(111, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Mi Perfil";
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
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnl_titulo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timerActualizarChats
            // 
            this.timerActualizarChats.Enabled = true;
            this.timerActualizarChats.Interval = 5000;
            this.timerActualizarChats.Tick += new System.EventHandler(this.timerActualizarChats_Tick);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 665);
            this.Controls.Add(this.pnl_Chats);
            this.Controls.Add(this.pnl_titulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.pnl_Chats.ResumeLayout(false);
            this.pnl_buscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_buscarUseChat)).EndInit();
            this.pnl_InfoPer.ResumeLayout(false);
            this.pnl_InfoPer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FotoinfoPer)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titulo;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Panel pnl_Chats;
        private System.Windows.Forms.Panel pnl_InfoPer;
        private System.Windows.Forms.Panel pnl_buscar;
   
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timerAbrir;
        private System.Windows.Forms.Timer timerCerrar;
        private Guna.UI.WinForms.GunaCirclePictureBox pic_FotoinfoPer;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Timer timerActualizarChats;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_buscarUseChat;
    }
}

