using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaClassPlayer : MonoBehaviour
{
       public class Arma
    {
        //Atributos da classe
        string nome;
        string tipo;
        
        //Construtor da classe
        //Adicionar um contrutor a classe, com o mesmo nome dela
        public Arma(string armaNome, string armaTipo)
        {
            nome = armaNome;
            tipo = armaTipo;
        }

        //getSet --> Função para ter acesso ao atributo da classe que está privado
        public string getNome()
        {
            return nome;
        }

        public string setNome(string Nome)
        {
            return nome = Nome;
        }
    }
    
    int vida;
    int velocidade;
    //ObjetoTipoArma nome --> Variável
    //Para deixar acessível por toda classe --> Arma espada;

    // Start is called before the first frame update
    void Start()
    {
        //Declarar objeto da classe arma
        //espada = new Arma("Minha Espada", "Espada");
        //Declarar objeto da classe arma --> Acessível apenas nessa função
        Arma espada = new Arma("Minha Espada", "Espada");
        Debug.Log(espada.getNome());

        //Utilizar o set para alterar o valor
        espada.setNome("Agulha");
        Debug.Log(espada.getNome());
    }

    void Atacar()
    {

    }

    void Pular()
    {

    }

    
    


    

    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
