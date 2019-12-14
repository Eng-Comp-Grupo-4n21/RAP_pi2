using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Threading;

namespace P2Grupo4N21
{
    public partial class UserControl1 : Form
    {   //varialvel global....
        int Segundos;
        string Dados_Serial;
        //int  CodigoBarra;
        //string texto="0";

        public class CosmosWebClient : WebClient
        {
            protected override WebRequest GetWebRequest(Uri address)
            {
                HttpWebRequest request = (HttpWebRequest)base.GetWebRequest(address);
                request.Headers["X-Cosmos-Token"] = "tiqMV7TwS-IkRooqiE3NgQ";
                base.Encoding = System.Text.Encoding.UTF8;
                return request;
            }
        }

        private void Limpar(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o controle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }

                //Se o controle for um PictureBox...
                if (ctrl is PictureBox)
                {
                    ((PictureBox)(ctrl)).Image = null;
                }


            }
        }

        private void AtualizaListaCOMs()//VOID PARA ATUALIZAR LISTA DE SERIAIS NA COMBOBOX 
        {
            int i;
            bool quantDiferente; //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (SerialPort.GetPortNames().Length == 0)
            {
                MessageBox.Show("Porta Serial não encontrada!!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();                             //fecha aplicação se não tem porta serial
                return;
            }
            else
            {
                if (CB_SERIAL.Items.Count == SerialPort.GetPortNames().Length)
                {
                    foreach (string s in SerialPort.GetPortNames())
                    {
                        if (CB_SERIAL.Items[i++].Equals(s) == false)
                        {
                            quantDiferente = true;
                        }
                    }
                }
                else
                {
                    quantDiferente = true;
                }

                //Se não foi detectado diferença
                if (quantDiferente == false)
                {
                    return;                     //retorna
                }

                //limpa comboBox
                CB_SERIAL.Items.Clear();

                //adiciona todas as COM diponíveis na lista
                foreach (string s in SerialPort.GetPortNames())
                {
                    CB_SERIAL.Items.Add(s);
                    label1.Text = s;
                }
                //seleciona a primeira posição da lista
                CB_SERIAL.SelectedIndex = 0;
                serialPort1.PortName = label1.Text;
                TMR_SERIAL.Enabled = false;
            }
        }

        public void Fecha_Serial() // fecha porta serial
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.BreakState = true;
                serialPort1.DiscardInBuffer();
                serialPort1.Close();
            }
        }
        public void LimpaCpf()
        {   // função limpa trabalha junto com o timer1, para alterar o labelMensager.Text
            MTB_CPF.Clear();
            MTB_CPF.Visible = false; //some o edit1.cpf da tela
            timer1.Enabled = true;
            timer1.Start();
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            AtualizaListaCOMs(); //Chama Função para atualizar e verificar se com exixtem e adiciona a serialPort1
            TXT_COD_BARRAS.Visible = false;                   // inicializa invisivel o textbox do codigo de barras
            labelMensager.Text = "Entre com o número do CPF";
            
        }

        private void Buttonconfirma_Click(object sender, EventArgs e)
        {
            labelMensager.Text = "Entre com o número do CPF";
            string cpf= MTB_CPF.Text;
                if (PI24N21.ValidaCPF.IsCpf(cpf))
                {   // entra na função ValidaCPF e verifica se é valido ou não
                    labelMensager.Text = "O número do CPF é Válido !";
                    LimpaCpf();// limpa o campo                    
                    timer1.Stop();
                    timer2.Enabled = true;// habilita o segundo timer responsavel 2 segundos de texto na tela 
                    timer2.Start();
                    Segundos = 30;// inicialização da variavel de tempo
                    BTN_CONFIRMA.Visible = false; // desaparece com o button_confirma         
                }
                else
                {
                    labelMensager.Text = "O número do CPF é Inválido !";
                    LimpaCpf(); //mantem 5 segundos  do texto cpf invalido e limpa o campo
                }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {   // timer 1 é responsavel do label para pedir o numero cpf
            labelMensager.Text = "Entre com o número do CPF";
            MTB_CPF.Visible = true; //reaparece o editcpf1 na tela
            timer1.Stop();// para o timer1
            timer1.Enabled = false;// desabilita o timer1
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            labelMensager.Text = "INSIRA SUA GARRAFA";
            timer3.Enabled = true;// habilita o timer3
            //timer3.Interval = 1000;// set 1 segundo de atualização
            timer3.Start(); //inicia o timer 3           
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            timer2.Stop();                              // para o timer 2
            timer2.Enabled = false;                     // desabilita o timer2
            if (Segundos == 0)
            {   // se não foi colocado a garrafa e zerou prepara para reiniciar o sistema
                timer3.Enabled = false;                             // desabilita o timer3
                Segundos = 30;                                     // variavel segundo volta a receber valor
                labelMensager.ForeColor = Color.Black;              // mantem o labelMensager em preto
                labelMensager.Text = "Entre com o número do CPF";   //muda o texto para inicializar o pedido de cpf
                BTN_CONFIRMA.Visible = true;                      // retorna o button_confirma para visivel

                MTB_CPF.Clear();                                   // chama a função limpa 
                MTB_CPF.Visible = true;                            // aparece novamente o editcpf1
            }
            else
            {   // conta tempo de 30 segunsdos para inserir a garrafa
                GPB_INFO_GARRAFA.Visible = true;
                Segundos--;                                         // subtrai segundo por segundo
                labelMensager.ForeColor = labelMensager.ForeColor == Color.Red ? Color.Black : Color.Red;
                // linha acima fica alternando de cor a cada segundo                
                labelMensager.Text = "  INSIRA SUA GARRAFA  " + Segundos; // atualização do label a cada segundo    

                if (SerialPort.GetPortNames().Length == 0)
                {
                    timer3.Enabled = false;
                    MessageBox.Show("Porta Serial não encontrada!!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();                             //fecha aplicação se não tem porta serial
                    return;
                }
                else
                {
                    if (serialPort1.IsOpen == false)                    // verifica para abrir a porta serial
                    {
                        serialPort1.Open();                             // abre a porta serial
                        serialPort1.Write("C");                         // envia comando para serial
                    }
                    else
                    {
                        serialPort1.Write("C");                         // envia um comando antes de fechar a serial
                        //Fecha_Serial();                                 //  função de fechar serial                                      
                    }

                }
                if (serialPort1.ReadExisting() != "")
                {
                    //Dados_Serial = serialPort1.ReadExisting();           // verifica se tem retorno da serial
                    Dados_Serial = serialPort1.ReadLine();
                    serialPort1.DiscardInBuffer();                  // limpa o buffer da serial para esperar o proximo comando de entrada
                    
                    if (Dados_Serial != "")                            // compara o sinal recebido da serial
                    {   // executa a  função conforme o sinal de retorno
                        JSON_RAP RAP_RETORNO = Descricao_Produto.JsonHelper.DeSerializar<JSON_RAP>(Dados_Serial);

                        TXT_JSON_RAP.Text = RAP_RETORNO.BOTAO_PORTA;
                        TXT_JSON_RAP.Text += "\n";
                        TXT_JSON_RAP.Text += RAP_RETORNO.BOTAO_MAQUINA_CHEIA;
                        TXT_JSON_RAP.Text += "/n";
                        TXT_JSON_RAP.Text += RAP_RETORNO.BOTAO_COMPACTANDO;
                        TXT_JSON_RAP.Text += "\n";
                        TXT_JSON_RAP.Text += RAP_RETORNO.BOTAO_ERRO;
                        TXT_JSON_RAP.Text += "\n";
                        TXT_JSON_RAP.Text += RAP_RETORNO.LED_AZUL_STATUS;
                        TXT_JSON_RAP.Text += "\n";
                        TXT_JSON_RAP.Text += RAP_RETORNO.LED_VERMELHO_ERRO;
                        TXT_JSON_RAP.Text += "\r";
                        TXT_JSON_RAP.Text += RAP_RETORNO.LED_VERDE_PORTA_ABERTA;
                        TXT_JSON_RAP.Text += "\r";
                        TXT_JSON_RAP.Text += RAP_RETORNO.LED_VERMELHO_PORTA_FECHADA;
                        TXT_JSON_RAP.Text += "/r";
                        TXT_JSON_RAP.Text += RAP_RETORNO.LED_AMARELO_MAQUINA_CHEIA ;
                        TXT_JSON_RAP.Text += "/r";

                       /* switch (Dados_Serial)
                        {
                            case "1":
                                labelMensager.Text = "  DEPOSITE A GARRAFA  ";
                                break;

                            case "2":
                                labelMensager.Text = "  MAQUINA CHEIA  ";
                                break;
                                
                            case "3":
                                labelMensager.Text = "  COMPACTANDO  ";
                                break;

                            case "4":
                                labelMensager.Text = "  ERRO INTERNO  ";
                                break;

                            default:
                                labelMensager.Text = "  AGUARDANDO GARRAFA  ";
                                break;

                        }*/

                        if (Dados_Serial != "")
                        {
                            labelMensager.Text = "  GARRAFA RECEBIDA  ";      // confirma que a garrafa foi recebida
                        }
                        timer3.Enabled = false;
                        timer2.Enabled = true;
                        Segundos = 30;                                  // se receber alguma garrafa reinicia o contador 
                        serialPort1.DiscardInBuffer();                  // limpa o buffer da serial para esperar o proximo comando de entrada
                        TXT_COD_BARRAS.Visible = true;                // entrada do codigo de barras
                    }
                    if (TXT_COD_BARRAS.Visible == true)
                    {
                        label1.Text = TXT_COD_BARRAS.Text;//Convert.ToString(CodigoBarra);
                        if (TXT_COD_BARRAS.Text != "")
                        {
                            try
                            {
                                var url = "https://api.cosmos.bluesoft.com.br/gtins/" + TXT_COD_BARRAS.Text + ".json";
                                CosmosWebClient wc = new CosmosWebClient();
                                string RESPOSTA = wc.DownloadString(url);
                                Produto Produtos = Descricao_Produto.JsonHelper.DeSerializar<Produto>(RESPOSTA);
                                TXT_COD_BARRAS1.Text = Produtos.gtin;
                                TXT_DESCRICAO.Text = Produtos.description;
                                PCB_CODIGO_BARRAS.Load(Produtos.barcode_image);
                                PCB_FOTO_PET.LoadAsync(Produtos.thumbnail);
                                TXT_PESO_BRUTO.Text = Produtos.gross_weight;
                                TXT_PESO_LIQUIDO.Text = Produtos.net_weight;
                                TXT_PESO_EMBALAGEM.Text = Convert.ToString(Math.Abs(Convert.ToInt32(Produtos.gross_weight) - Convert.ToInt32(Produtos.net_weight)));
                                TXT_COD_BARRAS.Text = "";
                                TXT_COD_BARRAS.Focus();
                                Thread.Sleep(10000);
                                TXT_COD_BARRAS.Text = "7894900680508";

                            }
                            catch
                            {
                                return;
                            }
                        }
                        else 
                        {
                            return; 
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }
        private void UserControl1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fecha_Serial();                                         // fecha a serial se for fechar o formulario
        }

        private void PCB_FOTO_PET_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LBL_IMAGEM_PROGRESSO.BackColor = Color.Transparent;
            PGB_IMAGEM_PROGRESSO.Value = e.ProgressPercentage;
            LBL_IMAGEM_PROGRESSO.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (TXT_JSON_RAP.Visible == false)
            {
                TXT_JSON_RAP.Visible = true;
            }
            else
            {
                TXT_JSON_RAP.Visible = false;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (GPB_INFO_GARRAFA.Visible == false)
            {
                GPB_INFO_GARRAFA.Visible = true;
            }
            else
            {
                GPB_INFO_GARRAFA.Visible = false;
            }
        }
    }
}
