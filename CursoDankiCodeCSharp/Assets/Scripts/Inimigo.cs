using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    //Criar variável estática
    //Variável estática é compartilhada com todas as instâncias da classe
    // public static int contadorInimigos;

    public int vida;
    public static Inimigo meuInimigo;

    //Contrutor
    // public Inimigo()
    // {
    //     contadorInimigos++;
    // }

    //Método estático, só chama o que é estático
    //Um método estático pode ser chamado de outra classe sem um objeto
    // public static int Adicionar(int num1, int num2)
    // {
    //     return num1 + num2;
    // }

    // Start is called before the first frame update
    void Start()
    {
        //this é uma auto referência ao objeto
        //meuInimigo recebe a própria classe
        meuInimigo = this;  
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
