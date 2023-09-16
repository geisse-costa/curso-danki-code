using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaFunction : MonoBehaviour
{
    public string nome;
    public int vida;
    int velocidade;
    int focaPulo;
    // Start is called before the first frame update
    void Start()
    {
        Atacar();
        DefinirNome();
        DefinirVida();
    }

    void Atacar()
    {
        Debug.Log("Olá mundo!");
    }

    string DefinirNome()
    {
        return nome = "Player One";
    }

    int DefinirVida()
    {
        return vida = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
