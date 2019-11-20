#include <Arduino.h>

long inChar;
long n;
void setup()
{
  Serial.begin(115200);
  Serial2.begin(115200);

  pinMode(2, OUTPUT); // led placa
  pinMode(4, OUTPUT); // abre porta sinal do esp
  pinMode(5, OUTPUT); //garrafa aceita
  pinMode(13, INPUT); //sinal da porta aberta para colocar garrafa
  pinMode(12, INPUT); //sinal de maquina cheia

  digitalWrite(2, HIGH);
  digitalWrite(4, HIGH);
  digitalWrite(5, HIGH);
  Serial.println("INICIALIZANDO");
}
//função carecter
void caracter()
{
  inChar = Serial.parseInt();
  n = inChar;
}

void serialEvent()
{
  while (Serial.available())
  {
    caracter();
    switch (n)
    {
    case 1:
      digitalWrite(4, LOW); // abre porta
      delay(100);
      break;
    case 2:
      digitalWrite(5, LOW); //garrafa aceita
      delay(100);
      //Serial.print("2");
      break;
    case 0:

      Serial.println(inChar);
      break;
      /*case 4:
        
        Serial.println(inChar);     
        break;
      case 5:
        
        Serial.println(inChar);       
        break;*/

    default:
    {
      Serial.println("x");
    }
      // se nada mais encaixa, fazer o padrão
    }
  }
}
void saidas_sinal()
{
  if (digitalRead(13) == HIGH) // saida de sinal de porta aberta
  {
  }

  if (digitalRead(12) == HIGH) // saida de sinal de maquina cheia
  {
  }
}
void loop()
{
  serialEvent();
  saidas_sinal();
}