using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int score;
    public static GameController controller;
    // Start is called before the first frame update
    void Start()
    {
        // Inimigo inimigo1 = new Inimigo();
        // Inimigo inimigo2 = new Inimigo();
        // Inimigo inimigo3 = new Inimigo();

        // Debug.Log(Inimigo.Adicionar(5,5));

        // Debug.Log(Inimigo.meuInimigo.vida);
        controller = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
