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

namespace P2Grupo4N21
{
    public partial class UserControl1 : Form
    {   //varialvel global....
        int segundos;
        string dados_serial;
        long  codigodebarra=000000000;
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
        {   // função limpa trabalha junto com o timer1, para alterar o labelMensager.Text
            Editcpf1.Clear();
            Editcpf1.Visible = false; //some o edit1.cpf da tela
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
            
            string[] ports = SerialPort.GetPortNames();            // procura as port serial instalada no windows 
            foreach (string port in ports)                         //estrutura de de repetição para encontar as portas serial 
            {   // tem que formular ainda o array das portas ou fazer uma escolha da lista das portas presente, ainda a defenir
                if (ports==null )
                {// conferir esta lógica se vai funcionar 
                    Application.Exit();                             //fecha aplicação se não tem porta serial
                }// 
                else
                {
                    serialPort1.PortName = port;                       // conforme logica incompleta vai jogar no nome da porta a ultima da lista 
                    label1.Text = port;

                }

            }
            TXT_COD_BARRAS.Visible = false;                   // inicializa invisivel o textbox do codigo de barras
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
                LimpaCpf();//mantem 5 segundos  do texto cpf invalido e limpa o campo
                
            }
            else
            {
                if (PI24N21.ValidaCPF.IsCpf(cpf))
                {   // entra na função ValidaCPF e verifica se é valido ou não
                    labelMensager.Text = "O número do CPF é Válido !";
                    LimpaCpf();// limpa o campo                    
                    timer1.Stop();
                    timer2.Enabled = true;// habilita o segundo timer responsavel 2 segundos de texto na tela 
                    timer2.Interval = 2000;
                    timer2.Start();
                    segundos = 30;// inicialização da variavel de tempo
                    buttonconfirma.Visible = false; // desaparece com o button_confirma         
                }
                else
                {
                    labelMensager.Text = "O número do CPF é Inválido !";
                    LimpaCpf(); //mantem 5 segundos  do texto cpf invalido e limpa o campo

                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {   // timer 1 é responsavel do label para pedir o numero cpf
            labelMensager.Text = "Entre com o número do CPF";
            Editcpf1.Visible = true; //reaparece o editcpf1 na tela
            timer1.Stop();// para o timer1
            timer1.Enabled = false;// desabilita o timer1
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            labelMensager.Text = "  INSIRA SUA GARRAFA";
            timer3.Enabled = true;// habilita o timer3
            timer3.Interval = 1000;// set 1 segundo de atualização
            timer3.Start(); //inicia o timer 3           
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            timer2.Stop();                              // para o timer 2
            timer2.Enabled = false;                     // desabilita o timer2
            if (segundos == 0)
            {   // se não foi colocado a garrafa e zerou prepara para reiniciar o sistema
                timer3.Enabled = false;                             // desabilita o timer3
                segundos = 30 ;                                     // variavel segundo volta a receber valor
                labelMensager.ForeColor = Color.Black;              // mantem o labelMensager em preto
                labelMensager.Text = "Entre com o número do CPF";   //muda o texto para inicializar o pedido de cpf
                buttonconfirma.Visible = true;                      // retorna o button_confirma para visivel
                
                Editcpf1.Clear();                                   // chama a função limpa 
                Editcpf1.Visible = true;                            // aparece novamente o editcpf1
               
                // este comando abaixo pode sair futuramente, pois esta desta maneira pra testar até o microcontrolador estiver ok
                if (serialPort1.IsOpen == true)                     // verifica a serial se esta aberta para poder fechar
                {                        
                    serialPort1.Write("1");                         // envia um comando antes de fechar a serial
                    fecha_serial();                                 //  função de fechar serial                                      
                }

            }
            else
            {   // conta tempo de 30 segunsdos para inserir a garrafa
                segundos--;                                         // subtrai segundo por segundo
                labelMensager.ForeColor = labelMensager.ForeColor == Color.Red ? Color.Black : Color.Red;
                // linha acima fica alternando de cor a cada segundo                
                labelMensager.Text = "INSIRA SUA GARRAFA " + segundos; // atualização do label a cada segundo    
                if (serialPort1.IsOpen == false)                        // verifica para abrir a porta serial
                {
                    serialPort1.Open();                             // abre a porta serial
                    serialPort1.Write("1");                         // envia comando para serial
                }

                dados_serial= serialPort1.ReadExisting();           // verifica se tem retorno da serial      

                if (dados_serial == "1")                            // compara o sinal recebido da serial
                {   // executa a  função conforme o sinal de retorno
                    labelMensager.Text = "  GARRAFA RECEBIDA";      // confirma que a garrafa foi recebida
                    segundos = 30;                                  // se receber alguma garrafa reinicia o contador 
                    serialPort1.DiscardInBuffer();                  // limpa o buffer da serial para esperar o proximo comando de entrada
                    TXT_COD_BARRAS.Visible = true;                // entrada do codigo de barras

                }
                codigodebarra = Convert.ToInt32(TXT_COD_BARRAS.Text);
                label1.Text = Convert.ToString(codigodebarra);
                var url = "https://api.cosmos.bluesoft.com.br/gtins/" + TXT_COD_BARRAS.Text + ".json";
                CosmosWebClient wc = new CosmosWebClient();
                string RESPOSTA = wc.DownloadString(url);
                produto produtos = descricao_produto.JsonHelper.DeSerializar<produto>(RESPOSTA);
                
                //TXT_COD_BARRAS.Text = produtos.gtin;
                //TXT_DESCRICAO.Text = produtos.description;
                //TXT_IMAGEM_PRODUTO.Text = produtos.thumbnail;
                //TXT_PESO_BRUTO.Text = produtos.gross_weight;
                //TXT_PESO_LIQUIDO.Text = produtos.net_weight;
                //TXT_PESO_EMBALAGEM.Text = Convert.ToString(Math.Abs(Convert.ToInt32(produtos.gross_weight) - Convert.ToInt32(produtos.net_weight)));

            }
        }
        private void UserControl1_FormClosed(object sender, FormClosedEventArgs e)
        {
            fecha_serial();                                         // fecha a serial se for fechar o formulario
        }

       
    }
}
