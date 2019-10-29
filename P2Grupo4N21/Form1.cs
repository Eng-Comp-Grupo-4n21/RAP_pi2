using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2Grupo4N21
{
    public partial class UserControl1 : Form
    {
        int segundos;
        string dados_serial;
        //string texto="0";
        
        public void fecha_serial() // fecha porta serial
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.BreakState = true;
                serialPort1.DiscardInBuffer();
                serialPort1.Close();
            }
        }
        public void LimpaCpf()
        {
            Editcpf1.Clear();
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Start();
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            serialPort1.PortName ="COM3";
            labelMensager.Text = "Entre com o número do CPF";
            labelTop.Text = "RECICLANDO";
            buttonconfirma.Text = "CONFIRMAR";
        }

        private void Buttonconfirma_Click(object sender, EventArgs e)
        {
            labelMensager.Text = "Entre com o número do CPF";
            string cpf= Editcpf1.Text;
            string ncpf = cpf;
            
            if (cpf == "111.111.111-11" || cpf == "222.222.222-22" || cpf == "333.333.333-33" || cpf == "444.444.444-44" || cpf == "555.555.555-55" || cpf == "666.666.666-66" || cpf == "777.777.777-77" || cpf == "888.888.888-88" || cpf == "999.999.999-99")
            {
                labelMensager.Text = "O número do CPF é Inválido !";                
                LimpaCpf();
            }
            else
            {
                if (PI24N21.ValidaCPF.IsCpf(cpf))
                {
                    labelMensager.Text = "O número do CPF é Válido !";
                    LimpaCpf();                   
                    Editcpf1.Visible = false;
                    timer1.Stop();
                    timer2.Enabled = true;
                    timer2.Interval = 2000;
                    timer2.Start();
                    segundos = 30;
                    buttonconfirma.Visible = false;          
                }
                else
                {
                    labelMensager.Text = "O número do CPF é Inválido !";
                    LimpaCpf();

                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            labelMensager.Text = "Entre com o número do CPF";
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            labelMensager.Text = "  INSIRA SUA GARRAFA";
            timer3.Enabled = true;
            timer3.Interval = 1000;
            timer3.Start();            
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer2.Enabled = false;
            if (segundos == 0)
            {

                timer3.Enabled = false;
                segundos = 30;
                labelMensager.ForeColor = Color.Black;
                labelMensager.Text = "Entre com o número do CPF";
                buttonconfirma.Visible = true;
                
                Editcpf1.Clear();
                Editcpf1.Visible = true;
               
                
                if (serialPort1.IsOpen == true)
                {                        
                    serialPort1.Write("1");
                    fecha_serial();                                        
                }

            }
            else
            {
                segundos--;
                labelMensager.ForeColor = labelMensager.ForeColor == Color.Red ? Color.Black : Color.Red;
                //labelMensager.ForeColor = Color.Black; 
                labelMensager.Text = "INSIRA SUA GARRAFA " + segundos;     
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.Open();
                    serialPort1.Write("2");
                }

                dados_serial= serialPort1.ReadExisting();       

                if (dados_serial == "2")
                {
                    labelMensager.Text = "  GARRAFA RECEBIDA";
                    segundos = 30;
                }             
            }
        }
        private void UserControl1_FormClosed(object sender, FormClosedEventArgs e)
        {
            fecha_serial();
        }        
    }
}
