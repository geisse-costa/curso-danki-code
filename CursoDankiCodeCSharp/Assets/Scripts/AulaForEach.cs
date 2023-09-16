using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaForEach : MonoBehaviour
{
    public string[] nomesNPC = new string[3];
    public List<string> nomesInimigos = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        nomesNPC[0] = "Mark";
        nomesNPC[1] = "Robb";
        nomesNPC[2] = "Julia";

        nomesInimigos.Add("Duratan");
        nomesInimigos.Add("Sauron");
        nomesInimigos.Add("Peter");

        // Tipo de item da coleção in coleção --> Ele percorre coleções
        foreach(string elemento in nomesNPC)
        {
            Debug.Log(elemento);
        }

        //Se for Array
        // for (int i = 0; i < nomesNPC.Length; i++)
        // {
        //     Debug.Log(nomesNPC[i]);
        // }

        //Se for Lista
        // for (int i = 0; i < nomesInimigos.Count; i++)
        // {
        //     Debug.Log(nomesInimigos[i]);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
