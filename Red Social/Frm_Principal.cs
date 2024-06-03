using Red_Social.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Red_Social
{
    public partial class Frm_Principal : Form
    {
        private Form chatactual;
        DataMensajes mensajes = new DataMensajes();
        public Frm_Principal()
        {
            InitializeComponent();
        }
        private void abrirChat(Frm_Chats chat, Image imagen, string titulo)
        {
            if(chatactual != null)
            {
                chatactual.Close();
            }
            chat.pic_fotoChatsAc.Image = imagen;
            chat.lbl_nombrecon.Text = titulo;
            chatactual = chat;
            chat.TopLevel = false;
            formHijo.Controls.Add(chat);
            formHijo.Tag = chat;
            chat.BringToFront();
            chat.Show();
        }
        private void timerAbrir_Tick(object sender, EventArgs e)
        {
            if(pnl_InfoPer.Width<320)
            {
                pnl_InfoPer.Width = pnl_InfoPer.Width + 20;
            }
            else
            {
                timerAbrir.Stop();
            }
        }

        private void timerCerrar_Tick(object sender, EventArgs e)
        {
            if (pnl_InfoPer.Width >0)
            {
                pnl_InfoPer.Width = pnl_InfoPer.Width - 20;
            }
            else
            {
               timerCerrar.Stop();
            }
        }

        private void pic_fotoChats_Click(object sender, EventArgs e)
        {
            timerAbrir.Start();
            pic_FotoinfoPer.Image = pic_fotoChats.Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //pnl_InfoPer.Width = 0;
            //pnl_Chats.Width = 320;
            timerCerrar.Start();
        }

       
       
        private void pic_fotoChats_Click_1(object sender, EventArgs e)
        {
            timerAbrir.Start();
        }
        private void CrearChat(string usuario,string msg,byte[]imge,int emisor)
        {
            //crear panel
            Panel panel = new Panel();
            panel.Dock = DockStyle.Top;
            panel.Height = 75;
            panel.BorderStyle = BorderStyle.None;
            panel.Cursor = Cursors.Hand;
            pnl_Chats.Controls.Add(panel);
            panel.BringToFront();

            //crear separdor
          
            Guna.UI.WinForms.GunaSeparator se = new Guna.UI.WinForms.GunaSeparator();
            se.LineColor = Color.LightGray;
            panel.Controls.Add(se);
            se.Dock=DockStyle.Bottom;

            //crear imagen
            MemoryStream ms = new MemoryStream(imge);
            Guna.UI.WinForms.GunaCirclePictureBox img = new Guna.UI.WinForms.GunaCirclePictureBox();
            img.Width = 65;
            img.Height = 65;
            img.Image = Image.FromStream(ms);
            panel.Controls.Add(img);
            img.Location = new Point(10, 1);

            //crear label titulo
            Label titulo = new Label();
            titulo.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            titulo.Size = new Size(160, 17);
            titulo.Text = usuario;
            titulo.ForeColor = Color.Black;
            panel.Controls.Add(titulo);
            titulo.Location = new Point(96, 19);

            //crear label message
            Label message = new Label();
            message.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            message.Size = new Size(160, 17);
            if(emisor==Cache.id_usuario)
            {
                message.Text = "Tu: " + msg;
            }
            else
            {
                message.Text = usuario + ": " + msg;
            }
          
            message.ForeColor = Color.DimGray;
            panel.Controls.Add(message);
            message.Location = new Point(96, 41);

            //crear eventos
            panel.Click += panel_Click;
            panel.MouseEnter += panel_MouseEnter;
            panel.MouseLeave += panel_MouseLeave;
            //panel.MouseHover += panel.MouseHover;
        }
        //private void panel_MouseHover(object sender, EventArgs e)
        //{
        //    ((Panel)sender).BackColor = Color.Black;
        //}
        private void panel_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.White;
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.LightGray;
        }

        private void panel_Click(object sender, EventArgs e)
        {
            //((Panel)sender).BackColor = Color.LightGray;
            Image imagen = null;
            string titulo = "";
            foreach(var control in((Panel)sender).Controls)
            {
                if(control is Guna.UI.WinForms.GunaCirclePictureBox)
                {
                    imagen = ((Guna.UI.WinForms.GunaCirclePictureBox)control).Image;
                }
                else if(control is Label)
                {
                    if(((Label)control).ForeColor==Color.Black)
                    {
                        titulo = ((Label)control).Text;
                    }
                   
                }
               ;
            }
            Frm_Chats.usuario = titulo;
           
            abrirChat(new Frm_Chats(),imagen,titulo);
            
            

        }
        private void bt_mensajes_Click(object sender, EventArgs e)
        {
            
        }
        private void ActualizarChats()
        {
            var lis = new List<DataMensajes>();
            lis = mensajes.UsrMje();
            foreach(DataMensajes item in lis)
            {
                CrearChat(item.Usuario, item.Mensaje, item.Perfil, item.Id_usrEmisor);
            }
        }
        private void limpiarChats()
        {
            while(pnl_Chats.Controls.Count>3)
            {
                foreach(Panel item in pnl_Chats.Controls)
                {
                    if(item.Name != "panel1" && item.Name != "pnl_InfoPer" && item.Name != "pnl_buscar")
                    {
                        pnl_Chats.Controls.Remove(item);
                    }
                }
            }
        }
        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            ActualizarChats();

        }

        private void timerActualizarChats_Tick(object sender, EventArgs e)
        {
            //limpiarChats();
            //ActualizarChats();
        }

        private void txt_buscarUseChat_Enter(object sender, EventArgs e)
        {
            if (txt_buscarUseChat.Text == "Buscar...")
            {
               txt_buscarUseChat.Text = "";
            }
        }

        private void txt_buscarUseChat_Leave(object sender, EventArgs e)
        {
            if (txt_buscarUseChat.Text == "")
            {
                txt_buscarUseChat.Text = "Buscar...";
            }
        }
    }
}
