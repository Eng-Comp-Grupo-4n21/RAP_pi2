#include <arduino.h>
#include <ArduinoJson.h>
#include <Wire.h>
#include <LiquidCrystal_I2C.h>
String flag1, flag2, flag3, flag4;
int n;
int x = 0;
int t = 16;
int PORTAS_SAIDA[] = {13, 12, 14, 27, 26, 25, 33, 32, 35, 34, 39, 36};
int PORTAS_ENTRADA[] = {15, 18, 4, 19};
int BOTAO_PORTA = 15, BOTAO_MAQUINA_CHEIA = 18, BOTAO_COMPACTANDO = 4, BOTAO_ERRO = 19;
int LED_AZUL_STATUS = 13, LED_VERMELHO_ERRO = 12, LED_VERDE_PORTA_ABERTA = 14, LED_VERMELHO_PORTA_FECHADA = 27, LED_AMARELO_MAQUINA_CHEIA = 26, LED_VERDE_GARRAFA_ACEITA = 25, LED_VERMELHO_GARRAFA_RECUSADA = 33, LED_VERDE_COMPACTANDO = 32, LED_BOTAO_PORTA = 35, LED_BOTAO_MAQUINA_CHEIA = 34, LED_BOTAO_COMPACTANDO = 39, LED_BOTAO_ERRO = 36;
int NIVEL_TOTAL_GARRAFAS = 1 , PESO_TOTAL_GARRAFAS = 0;


LiquidCrystal_I2C lcd(0x27, 16, 2);

byte BARRA_CARREGAMENTO[8] = // Matriz do caracter especial
{
  0b11011,
  0b11011,
  0b11011,
  0b11011,
  0b11011,
  0b11011,
  0b11011,
  0b11011
};

void setup()
{
  Serial.begin(115200);
  Serial.println("INICIADO!!!");
  lcd.begin();
  lcd.backlight();
  lcd.createChar(1, BARRA_CARREGAMENTO); // criando o caracter especial 1
  Serial.print("INICIANDO PINOS DE SAIDAS LEDS: ");
  for (int i = 0; i < 12; i++)
  {
    pinMode(PORTAS_SAIDA[i], OUTPUT);
  }
  Serial.println("OK");

  Serial.print("INICIANDO PINOS DE ENTRADA: ");
  for (int i = 0; i < 4; i++)
  {
    pinMode(PORTAS_ENTRADA[i], INPUT_PULLUP);
  }
  Serial.println("OK");

  ROTINA_TESTE();

}

void ROTINA_TESTE()
{
  lcd.clear();
  Serial.print("COLOCANDO EM NIVEL LOGICO ALTO AS SAIDAS: ");
  for (int i = 0; i < 12; i++)
  {
    digitalWrite(PORTAS_SAIDA[i], HIGH);
    delay(100);
  }
  delay(500);
  for (int i = 0; i < 12; i++)
  {
    digitalWrite(PORTAS_SAIDA[i], LOW);
    delay(100);
  }
  Serial.println("OK");

  Serial.print("TESTE DO LCD: ");
    for (int i = 0; i <= t; i++)
    {
     lcd.setCursor(0, 0);
     lcd.print("TEMPO: ");
     lcd.setCursor(7, 0);
     lcd.print(i);
     lcd.setCursor(i, 1);
     lcd.write((byte)1); // imprimindo o carcter especial 1
     delay(200);
    }
    lcd.clear();
    Serial.println("OK");

    Serial.print("TESTE DOS LEDS: ");
    lcd.setCursor(0, 0);
    lcd.print("LED EM TESTE: ");
    for (int i = 0; i <=8; i++)
    {
     lcd.setCursor(13, 0);
     lcd.print(i);
     delay(200);
     digitalWrite(PORTAS_SAIDA[i], HIGH); // ativa o pino digital
     delay(100);                         // espera por um segundo
     digitalWrite(PORTAS_SAIDA[i], LOW);  // desativa o pino digital
     delay(100);                         // espera por um segundo
    }
    Serial.println("OK");

    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("!FIM DOS TESTES!");
    lcd.setCursor(0, 1);
    lcd.print("---SISTEMA OK---");
    delay(3000);  
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print(" INICIALIZANDO ");
    for (int i = 0; i <= 15; i++)
    {
     lcd.setCursor(i, 1);
     lcd.write((byte)1); // imprimindo o carcter especial 1
     delay(300);
    }
    lcd.clear();
}
//*****************função Json******************
void Json() {
  StaticJsonDocument<1024> doc;
  doc["BOTAO_PORTA"] = digitalRead(BOTAO_PORTA);
  doc["BOTAO_MAQUINA_CHEIA"] = digitalRead(BOTAO_MAQUINA_CHEIA);
  doc["BOTAO_COMPACTANDO"] = digitalRead(BOTAO_COMPACTANDO);
  doc["BOTAO_ERRO"] = digitalRead(BOTAO_ERRO);
  doc["LED_AZUL_STATUS"] = digitalRead(LED_AZUL_STATUS);
  doc["LED_VERMELHO_ERRO"] = digitalRead(LED_VERMELHO_ERRO);
  doc["LED_VERDE_PORTA_ABERTA"] = digitalRead(LED_VERDE_PORTA_ABERTA);
  doc["LED_VERMELHO_PORTA_FECHADA"] = digitalRead(LED_VERMELHO_PORTA_FECHADA);
  doc["LED_AMARELO_MAQUINA_CHEIA"] = digitalRead(LED_AMARELO_MAQUINA_CHEIA);
  doc["LED_VERDE_GARRAFA_ACEITA"] = digitalRead(LED_VERDE_GARRAFA_ACEITA);
  doc["LED_VERMELHO_GARRAFA_RECUSADA"] = digitalRead(LED_VERMELHO_GARRAFA_RECUSADA);
  doc["LED_VERDE_COMPACTANDO"] = digitalRead(LED_VERDE_COMPACTANDO);
  doc["LED_BOTAO_PORTA"] = digitalRead(BOTAO_PORTA);
  doc["LED_BOTAO_MAQUINA_CHEIA"] = digitalRead(BOTAO_MAQUINA_CHEIA);
  doc["LED_BOTAO_COMPACTANDO"] = digitalRead(BOTAO_COMPACTANDO);
  doc["LED_BOTAO_ERRO"] = digitalRead(BOTAO_ERRO);
  serializeJson(doc, Serial);
  Serial.println();
  //serializeJsonPretty(doc, Serial);
}
//*********************fim de função Json*******************

//**************fim de setup********************************
void INFO_DISPLAY()
{
  lcd.setCursor(0, 0);
  lcd.print("NIVEL:");
  if (NIVEL_TOTAL_GARRAFAS >= 11) {
    for (int i = 0 ; i <= (NIVEL_TOTAL_GARRAFAS / 11); i++)
    {
      lcd.setCursor(i + 6, 0);
      lcd.write((byte)1); // imprimindo o carcter especial 1
      delay(500);
    }
  }

  lcd.setCursor(0, 1);
  lcd.print("TOTAL:");
  lcd.setCursor(6, 1);
  if (PESO_TOTAL_GARRAFAS <= 99999)
  {
    lcd.print(PESO_TOTAL_GARRAFAS);
  }
  lcd.setCursor(14, 1);
  lcd.print("KG");

}


void caracter()
{
  n = Serial.read();
}

void leitura_serial() {

  while (Serial.available()) {
    caracter();
    switch (n) {
      case 'A':
        Json();// quando soltar o Json desbarrar aqui
        x = 0;
        break;

      case 'B'://EM CASO DE ERRO LIGAR LED
        digitalWrite(LED_VERMELHO_ERRO, HIGH); //liga led de porta aberta para pedir que ligue o botão da porta
        x = 0;
        break;

      case 'b'://EM CASO DE ERRO DESLIGAR LED
        digitalWrite(LED_VERMELHO_ERRO, LOW); //liga led de porta aberta para pedir que ligue o botão da porta
        x = 0;
        break;

      case 'C'://EM CASO DE PORTA ABERTA LIGA LED
        digitalWrite(LED_VERDE_PORTA_ABERTA, HIGH); //liga led de porta aberta para pedir que ligue o botão da porta
        x = 0;
        break;

      case 'c'://EM CASO DE PORTA ABERTA DESLIGAR LED
        digitalWrite(LED_VERDE_PORTA_ABERTA, LOW); //liga led de porta aberta para pedir que ligue o botão da porta
        x = 0;
        break;

      case 'D'://EM CASO DE PORTA FECHADA LIGA LED
        digitalWrite(LED_VERMELHO_PORTA_FECHADA, HIGH); //liga led de porta aberta para pedir que ligue o botão da porta
        x = 0;
        break;

      case 'd'://EM CASO DE PORTA FECHADA DESLIGAR LED
        digitalWrite(LED_VERMELHO_PORTA_FECHADA, LOW); //liga led de porta aberta para pedir que ligue o botão da porta
        x = 0;
        break;

      case 'E'://EM CASO DE MAQUINA CHEIA LIGA LED
        digitalWrite(LED_AMARELO_MAQUINA_CHEIA, HIGH); //liga led de porta aberta para pedir que ligue o botão da porta
        x = 0;
        break;

      case 'e'://EM CASO DE MAQUINA CHEIA DESLIGAR LED
        digitalWrite(LED_AMARELO_MAQUINA_CHEIA, LOW); //liga led de porta aberta para pedir que ligue o botão da porta
        x = 0;
        break;

      case 'F'://EM CASO DE GARRAFA ACEITA LIGA LED
        digitalWrite(LED_VERDE_GARRAFA_ACEITA, HIGH); //liga led de porta aberta para pedir que ligue o botão da porta
        x = 0;
        break;

      case 'f'://EM CASO DE GARRAFA ACEITA DESLIGAR LED
        digitalWrite(LED_VERDE_GARRAFA_ACEITA, LOW); //liga led de porta aberta para pedir que ligue o botão da porta
        x = 0;
        break;

      case 'G'://EM CASO DE GARRAFA RECUSADA LIGA LED
        digitalWrite(LED_VERMELHO_GARRAFA_RECUSADA, HIGH); //liga led de porta aberta para pedir que ligue o botão da porta
        x = 0;
        break;

      case 'g'://EM CASO DE GARRAFA RECUSADA DESLIGAR LED
        digitalWrite(LED_VERMELHO_GARRAFA_RECUSADA, LOW); //liga led de porta aberta para pedir que ligue o botão da porta
        x = 0;
        break;

      case 'H'://EM CASO DE MAQUINA COMPACTANDO LIGA LED
        digitalWrite(LED_VERDE_COMPACTANDO, HIGH); //liga led de porta aberta para pedir que ligue o botão da porta
        x = 0;
        break;

      case 'h'://EM CASO DE MAQUINA COMPACTANDO DESLIGAR LED
        digitalWrite(LED_VERDE_COMPACTANDO, LOW); //liga led de porta aberta para pedir que ligue o botão da porta
        x = 0;
        break;

      case 'T'://EM CASO DE MAQUINA COMPACTANDO DESLIGAR LED
        NIVEL_TOTAL_GARRAFAS += 1;
        x = 0;
        break;

      case 't'://EM CASO DE MAQUINA COMPACTANDO DESLIGAR LED
        PESO_TOTAL_GARRAFAS += 1;
        x = 0;
        break;

      default:
        {
          //Serial.println("x");
        }
        // se nada mais encaixa, fazer o padrão
    }
  }
}
//***************fim de função da leitura serial*******************


//***************inicio de função saida de sinais ******************
void saida_sinal()
{

  if (digitalRead(BOTAO_PORTA) == LOW)
  {
    digitalWrite(LED_VERMELHO_PORTA_FECHADA, LOW);
    digitalWrite(LED_VERDE_PORTA_ABERTA, HIGH);
    flag1 = ("1");
    if (x == 0)
    {
      x += 1;
    }
  }
  else
  {
    flag1 = ("0");
    digitalWrite(LED_VERDE_PORTA_ABERTA, LOW);
    digitalWrite(LED_VERMELHO_PORTA_FECHADA, HIGH);
  }

  if (digitalRead(BOTAO_MAQUINA_CHEIA) == LOW)
  {
    digitalWrite(LED_VERMELHO_ERRO, HIGH);
    digitalWrite(LED_AMARELO_MAQUINA_CHEIA, HIGH);
    flag2 = ("1");
    if (x == 0)
    {
      x += 1;
    }
  }
  else
  {
    flag2 = ("0");
    digitalWrite(LED_VERMELHO_ERRO, LOW);
    digitalWrite(LED_AMARELO_MAQUINA_CHEIA, LOW);
  }

  if (digitalRead(BOTAO_COMPACTANDO) == LOW)
  {
    flag3 = ("1");
    digitalWrite(LED_VERDE_COMPACTANDO, HIGH);
    if (x == 0)
    {
      x += 1;
    }
  }
  else
  {
    flag3 = ("0");
    digitalWrite(LED_VERDE_COMPACTANDO, LOW);
  }

  if (digitalRead(BOTAO_ERRO) == LOW)
  {
    flag4 = ("1");
    digitalWrite(LED_VERMELHO_ERRO, HIGH);
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("OCORREU UM ERRO!");
    lcd.setCursor(0, 1);
    lcd.print("!!! TESTANDO !!!");
    delay(3000);
    ROTINA_TESTE();
    if (x == 0)
    {
      x += 1;
    }
  }
  else
  {
    flag4 = ("0");
    digitalWrite(LED_VERMELHO_ERRO, LOW);
  }

}
//*********************fim de função de saida de sinal************************


void loop() {
                     
  digitalWrite(LED_AZUL_STATUS, LOW);   // ativa o pino digital
  delay(50);                            // espera por um segundo
  INFO_DISPLAY();
  leitura_serial();
  saida_sinal();
  //digitalWrite(LED_AZUL_STATUS, HIGH);  // desativa o pino digital
  //delay(50);                            // espera por um segundo
}