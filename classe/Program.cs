void NomeMetodo()  //void quando nao tem retorno
{
    Console.WriteLine("ola");
}

NomeMetodo(); //chamando o metodo


void SomarDoisValores(int a, int b) {

  
    int somar = a + b;
    Console.WriteLine($"{a}+{b}={somar}");
    
}

int SolicitarValorInteiro()
{
    Console.Write("digite numero: ");
    string texto = Console.ReadLine();
    int num1 = 10;
    bool textoOk = int.TryParse(texto, out num1); //verifica se o texto é um numero
    if (textoOk == false) { 
    Console.WriteLine("valor invalido");
    }
    
    return num1;
}

void SolicitarSoma()
{
    int valor1 = SolicitarValorInteiro();
    int valor2 = SolicitarValorInteiro();
    SomarDoisValores(valor1, valor2);
}

void DividirDoisValores(float a, float b)
{


    float dividir = a / b;
    Console.WriteLine($"{a}/{b}={dividir}");

}

float SolicitarValorFloat()
{
    Console.Write("digite numero: ");
    string texto = Console.ReadLine();
    float num1 = 10f;
    bool textoOk = float.TryParse(texto, out num1); //verifica se o texto é um numero
    if (textoOk == false)
    {
        Console.WriteLine("valor invalido");
    }

    return num1;
}

void SolicitarDivisao()
{
    float valor1 = SolicitarValorFloat();
    float valor2 = SolicitarValorFloat();
    DividirDoisValores(valor1, valor2);
}   
﻿
