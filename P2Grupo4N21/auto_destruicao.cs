using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace P2Grupo4N21
{
    public partial class auto_destruicao : Form
    {
        int TEMPO = 10;
        public auto_destruicao()
        {
            InitializeComponent();
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.ForeColor = label3.ForeColor == Color.Red ? Color.Orange : Color.Red;
            if (TEMPO == 0)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                Thread.Sleep(10000);
                UserControl1 ajustes = new UserControl1();
                ajustes.Show();
                this.Close();
            } 
            else
            {
                TEMPO--;
                label3.Text = Convert.ToString(TEMPO);
            }
            
        }
    }
}
