#include <arduino.h>
#include <Wire.h>
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27, 16, 2);
int t = 16;
int PORTAS_SAIDA[] = {13, 12, 14, 27, 26, 25, 33, 32, 35, 34, 39, 36};
int PORTAS_ENTRADA[] = {15, 2, 4, 5};
int BOTAO_PORTA = 15, BOTAO_MAQUINA_CHEIA = 2, BOTAO_COMPACTANDO = 4, BOTAO_ERRO = 5;

LiquidCrystal_I2C lcd(0x27, 16,2);

byte BARRA_CARREGAMENTO[8] = // Matriz do caracter especial
    {
        0b11011,
        0b11011,
        0b11011,
        0b11011,
        0b11011,
        0b11011,
        0b11011,
        0b11011};

void setup()
{
    lcd.init();
    lcd.backlight();
    lcd.createChar(1, BARRA_CARREGAMENTO); // criando o caracter especial 1
    Serial.Begin(115200);

    for (int i = 0; i < 12; i++)
    {
        pinMode(PORTAS_SAIDA[i], OUTPUT);
    }

    for (int i = 0; i < 4; i++)
    {
        pinMode(PORTAS_ENTRADA[i], INPUT);
    }

    for (int i = 0; i < 8; i++)
    {
        digitalWrite(PORTAS_SAIDA[i], HIGH);
    }

    for (int i = 0; i <= t; i++)
        {
            lcd.clear();
            lcd.print("CRONOMETRO");
            lcd.setCursor(0, 1);
            lcd.print("TEMPO: ");
            lcd.setCursor(7, 1);
            lcd.print(i);
            lcd.setCursor(i, 2);
            lcd.write((byte)1); // imprimindo o carcter especial 1
            delay(1000);
        }

    for (int i = 0; i < 12; i++)
        {
            lcd.clear();
            lcd.print("LED EM TESTE: " + i);
            digitalWrite(PORTAS_SAIDA[i], HIGH); // ativa o pino digital 13
            delay(1000);                         // espera por um segundo
            digitalWrite(PORTAS_SAIDA[i], LOW);  // desativa o pino digital 13
            delay(1000);                         // espera por um segundo
        }

        lcd.clear();
        lcd.print("Fim!");
}

void loop() {
    lcd.clear();
    lcd.setCursor(0, 1);
    lcd.print("B_1 B_2 B_3 B_4");
    if (digitalRead(BOTAO_PORTA)==1)
    {
        lcd.setCursor(1, 2);
        lcd.print("#");
    }
    else
    {
        lcd.setCursor(1, 2);
        lcd.print(" ");
    }

    if (digitalRead(BOTAO_MAQUINA_CHEIA) == 1)
    {
        lcd.setCursor(5, 2);
        lcd.print("#");
    }
    else
    {
        lcd.setCursor(5, 2);
        lcd.print(" ");
    }

    if (digitalRead(BOTAO_COMPACTANDO) == 1)
    {
        lcd.setCursor(9, 2);
        lcd.print("#");
    }
    else
    {
        lcd.setCursor(9, 2);
        lcd.print(" ");
    }

    if (digitalRead(BOTAO_ERRO) == 1)
    {
        lcd.setCursor(13, 2);
        lcd.print("#");
    }
    else
    {
        lcd.setCursor(13, 2);
        lcd.print(" ");
    }
}