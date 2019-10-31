using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //USADA PARA ACESSO A FUNCIONALIDADES DE PROCESSOS DO WINDOWS.

namespace P2Grupo4N21
{    
static class Program
    {        
    /// <summary>
    /// Ponto de entrada principal para o aplicativo.
    /// </summary>
    [STAThread]
        static void Main()
        {
            // INICIO DO ALGORITIMO DE VERIFICAÇÃO DE EXISTENCIA NO PROCESSO DO WINDOWS
            Process aProcess = Process.GetCurrentProcess(); //cria um novo objeto sobre o processo do windows 
            string aProcName = aProcess.ProcessName; //cria uma string com o nome do programa para comparação na lista de execulções do windows
            if (Process.GetProcessesByName(aProcName).Length > 1)  //Verifica a existência do processo ja ativo e toma a descição
            {
                MessageBox.Show("O programa já está em execução!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error); //Apresenta a mensagem para o usuario informando que o mesmo ja foi solicitado e esta em processo de abertura
                return; //Retorna ao processo principal de abertura do software primario.
            }
            // FIM DO ALGORITIMO DE VERIFICAÇÃO DE EXISTENCIA NO PROCESSO DO WINDOWS

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserControl1());

            
        }
    }
}
