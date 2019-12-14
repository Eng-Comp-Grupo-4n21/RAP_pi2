using System.Runtime.Serialization;
using System;

namespace P2Grupo4N21
{
    [DataContract]
    public class JSON_RAP
    {

        /*
         
            RETORNO JSON DO SERVIDOR
         
         {
    "BOTAO_PORTA":"ATIVO",
    "BOTAO_MAQUINA_CHEIA":"ATIVO",
    "BOTAO_COMPACTANDO":"ATIVO",
    "BOTAO_ERRO":"ATIVO",
    "LED_AZUL_STATUS":"ATIVO",
    "LED_VERMELHO_ERRO":"ATIVO",
    "LED_VERDE_PORTA_ABERTA":"ATIVO",
    "LED_VERMELHO_PORTA_FECHADA":"ATIVO",
    "LED_AMARELO_MAQUINA_CHEIA":"ATIVO",
    "LED_VERDE_GARRAFA_ACEITA":"ATIVO",
    "LED_VERMELHO_GARRAFA_RECUSADA":"ATIVO",
    "LED_VERDE_COMPACTANDO":"ATIVO",
    "LED_BOTAO_PORTA":"ATIVO",
    "LED_BOTAO_MAQUINA_CHEIA":"ATIVO",
    "LED_BOTAO_COMPACTANDO":"ATIVO",
    "LED_BOTAO_ERRO":"ATIVO"

    }
      
            FIM DO RETORNO JSON DO SERVIDOR
             */


        public JSON_RAP(string STATUS_PORTA, string STATUS_MAQUINA, string STATUS_COMPACTANDO, string STATUS_ERRO, string STATUS_LED_AZUL,
            string STATUS_LED_VERMELHO_ERRO, string STATUS_LED_VERDE_PORTA_ABERTA, string STATUS_LED_VERMELHO_PORTA_FECHADA,
            string STATUS_LED_AMARELO_MAQUINA_CHEIA, string STATUS_LED_VERDE_GARRAFA_ACEITA,
            string STATUS_LED_VERMELHO_GARRAFA_RECUSADA, string STATUS_LED_VERDE_COMPACTANDO, string STATUS_LED_BOTAO_PORTA,
            string STATUS_LED_BOTAO_MAQUINA_CHEIA, string STATUS_LED_BOTAO_COMPACTANDO, string STATUS_LED_BOTAO_ERRO)
        {
            BOTAO_PORTA = STATUS_PORTA;
            BOTAO_MAQUINA_CHEIA = STATUS_MAQUINA;
            BOTAO_COMPACTANDO = STATUS_COMPACTANDO;
            BOTAO_ERRO = STATUS_ERRO;
            LED_AZUL_STATUS = STATUS_LED_AZUL;
            LED_VERMELHO_ERRO = STATUS_LED_VERMELHO_ERRO;
            LED_VERDE_PORTA_ABERTA = STATUS_LED_VERDE_PORTA_ABERTA;
            LED_VERMELHO_PORTA_FECHADA = STATUS_LED_VERMELHO_PORTA_FECHADA;
            LED_AMARELO_MAQUINA_CHEIA = STATUS_LED_AMARELO_MAQUINA_CHEIA;
            LED_VERDE_GARRAFA_ACEITA = STATUS_LED_VERDE_GARRAFA_ACEITA;
            LED_VERMELHO_GARRAFA_RECUSADA = STATUS_LED_VERMELHO_GARRAFA_RECUSADA;
            LED_VERDE_COMPACTANDO = STATUS_LED_VERDE_COMPACTANDO;
            LED_BOTAO_PORTA = STATUS_LED_BOTAO_PORTA;
            LED_BOTAO_MAQUINA_CHEIA = STATUS_LED_BOTAO_MAQUINA_CHEIA;
            LED_BOTAO_COMPACTANDO = STATUS_LED_BOTAO_COMPACTANDO;
            LED_BOTAO_ERRO = STATUS_LED_BOTAO_ERRO;

        }

        [DataMember]
        public string BOTAO_PORTA { get; set; }

        [DataMember]
        public string BOTAO_MAQUINA_CHEIA { get; set; }

        [DataMember]
        public string BOTAO_COMPACTANDO { get; set; }

        [DataMember]
        public string BOTAO_ERRO { get; set; }

        [DataMember]
        public string LED_AZUL_STATUS { get; set; }

        [DataMember]
        public string LED_VERMELHO_ERRO { get; set; }

        [DataMember]
        public string LED_VERDE_PORTA_ABERTA { get; set; }

        [DataMember]
        public string LED_VERMELHO_PORTA_FECHADA { get; set; }

        [DataMember]
        public string LED_AMARELO_MAQUINA_CHEIA { get; set; }

        [DataMember]
        public string LED_VERDE_GARRAFA_ACEITA { get; set; }

        [DataMember]
        public string LED_VERMELHO_GARRAFA_RECUSADA { get; set; }

        [DataMember]
        public string LED_VERDE_COMPACTANDO { get; set; }

        [DataMember]
        public string LED_BOTAO_PORTA { get; set; }

        [DataMember]
        public string LED_BOTAO_MAQUINA_CHEIA { get; set; }

        [DataMember]
        public string LED_BOTAO_COMPACTANDO { get; set; }

        [DataMember]
        public string LED_BOTAO_ERRO { get; set; }

    }
}