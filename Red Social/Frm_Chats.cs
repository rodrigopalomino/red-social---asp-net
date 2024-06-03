using Red_Social.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Red_Social
{
    public partial class Frm_Chats : Form
    {
        DataMensajes objetoMsg = new DataMensajes();
        public static string usuario = "";

        public Frm_Chats()
        {
            InitializeComponent();
        }
        private void mensajeUser(string mensaje)
        {
            Panel msjUser = new Panel();
            msjUser.Height = 59;
            msjUser.AutoScroll = true;
            panel2.Controls.Add(msjUser);
            msjUser.Dock = DockStyle.Bottom;

            Klik.Windows.Forms.v1.EntryLib.ELLabel txt = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            txt.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            txt.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            txt.BackgroundStyle.SolidColor = Color.HotPink;
            txt.BorderStyle.SolidColor = Color.HotPink;

            txt.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            txt.ForeColor = Color.White;
            txt.Text = mensaje;
            txt.Size = new Size(400, 45);
            msjUser.Controls.Add(txt);
            txt.Location = new Point(69, 7);

        }
    
        private void mensajeMio(string mensaje)
        {
            
            Panel msjUser = new Panel();
            msjUser.Height = 59;
            msjUser.AutoScroll = true;
            panel2.Controls.Add(msjUser);
            msjUser.Dock = DockStyle.Bottom;

            Klik.Windows.Forms.v1.EntryLib.ELLabel txt = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            txt.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            txt.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            txt.BackgroundStyle.SolidColor = Color.MediumSlateBlue;
            txt.BorderStyle.SolidColor = Color.MediumSlateBlue;

            txt.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            txt.ForeColor = Color.White;
            txt.Text = mensaje;
            txt.Size = new Size(400, 45);
            txt.Anchor = AnchorStyles.Right;
            msjUser.Controls.Add(txt);
            txt.Location = new Point(472, 7);

        }
        private void timerAbrir_Tick(object sender, EventArgs e)
        {
            if (pnl_infoChats.Width < 275)
            {
                pnl_infoChats.Width = pnl_infoChats.Width + 20;
            }
            else
            {
                timerAbrir.Stop();
            }
        }

        private void timerCerrar_Tick(object sender, EventArgs e)
        {
            if (pnl_infoChats.Width > 0)
            {
                pnl_infoChats.Width = pnl_infoChats.Width - 20;
            }
            else
            {
                timerCerrar.Stop();
            }
        }

       
        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            timerCerrar.Start();
        }

        private void pic_fotoChats_Click_1(object sender, EventArgs e)
        {
             pic_FotoinfoPerac.Image = pic_fotoChatsAc.Image;
            lblnomcontacinfo.Text= lbl_nombrecon.Text;
            timerAbrir.Start();
        }

        private void Frm_Chats_Load(object sender, EventArgs e)
        {
            CargarMensajes();
        }
        private void CargarMensajes()
        {
            var list = new List<DataMensajes>();
            list = objetoMsg.MensajeUser(usuario);
            foreach (DataMensajes item in list)
            {
                if (item.Id_usrEmisor == Cache.id_usuario)
                {
                    mensajeMio(item.Mensaje);
                }
                else
                {
                    mensajeUser(item.Mensaje);
                }
            }
        }
        private void txt_escribirMensaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                objetoMsg.Mensaje = txt_escribirMensaje.Text;
                objetoMsg.NuevoMensaje(usuario);
                txt_escribirMensaje.Text = "";
                limpiarPanel();
                CargarMensajes();
                //timerCargarChats.Start();
            }
        }
        private void limpiarPanel()
        {
            while(panel2.Controls.Count>0)
            {
                foreach(Panel item in panel2.Controls)
                {
                    panel2.Controls.Remove(item);
                }
            }
        }

       private void txt_escribirMensaje_Enter(object sender, EventArgs e)
        {
            if (txt_escribirMensaje.Text == "Escribir Mensaje...")
            {
                txt_escribirMensaje.Text = "";
                //timerCargarChats.Stop();
            }
        }

        private void txt_escribirMensaje_Leave(object sender, EventArgs e)
        {
            if (txt_escribirMensaje.Text == "")
            {
                //timerCargarChats.Start();
                txt_escribirMensaje.Text = "Escribir Mensaje...";
            }
        }

        private void timerActualizarChats_Tick(object sender, EventArgs e)
        {
            limpiarPanel();
            CargarMensajes();
        }
    }
}
