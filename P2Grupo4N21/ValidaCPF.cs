using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI24N21
{
    public static class ValidaCPF
    {
        public static bool IsCpf(string cpf)
        {   //VARIÁVEIS 
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();                                                       //Remove possiveis espaços em branco da string
            cpf = cpf.Replace(".", "").Replace("-", "");                            //Busca por caracteres '.' e '-' e remove da string
            if (cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333333" || cpf == "44444444444" || cpf == "55555555555" || cpf == "66666666666" || cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999")
            {
                return false;
            }
            if (cpf.Length != 11)                                                   //Verifica se a string esta com os 11 caracteres 
                return false;                                                       //Caso esteja faltando caracter retorna como falso
            tempCpf = cpf.Substring(0, 9);                                          //Seleciona os primeiros 9 digitos da string
            soma = 0;                                                               //Limpa a variavel

            for (int i = 0; i < 9; i++)                                             //Conta variavel inteira de 0 a 9 e incrementa de 1 e 1 para fazer o calculo primario do CPF
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];       //Faz a conversão do numero para 32bits 1 a 1 e multiplica ele pela matriz 'multiplicador1' e soma na variavel 'soma'
            resto = soma % 11;                                                      //Verifica o resto
            if (resto < 2)                                                          //Verifica se o resto da conta é menor que 2 
                resto = 0;                                                          //Caso seja ele retorna o resto como 0
            else
                resto = 11 - resto;                                                 //Caso contrario ele condiciona o resto para a segunda parte da conta de validação de CPF
            digito = resto.ToString();                                              //Caso contrario ele condiciona o resto para a segunda parte da conta de validação de CPF
            tempCpf = tempCpf + digito;                                             //Concatena a string digito e resto 
            soma = 0;                                                               //Resetqa a variavel soma para 0
            for (int i = 0; i < 10; i++)                                            //Conta variavel inteira de 0 a 10 e incrementa de 1 e 1 para fazer o calculo primario do CPF
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];       //Faz a conversão do numero para 32bits 1 a 1 e multiplica ele pela matriz 'multiplicador2' e soma na variavel 'soma'
            resto = soma % 11;                                                      //Verifica o resto
            if (resto < 2)                                                          //Verifica se o resto da conta é menor que 2 
                resto = 0;                                                          //Caso seja ele retorna o resto como 0
            else
                resto = 11 - resto;                                                 //Caso contrario ele condiciona o resto para a segunda parte da conta de validação de CPF
            digito = digito + resto.ToString();                                     //Concatena a string digito e resto 
            return cpf.EndsWith(digito);                                            //Faz a verificação do digito para ver se realmente o CPF é real ou falso
        }

        internal static bool IsCpf(char valor)          
        {
            throw new NotImplementedException();                                    //Inicia uma nova instacia para a classe em modo normal
        }
    }
}
