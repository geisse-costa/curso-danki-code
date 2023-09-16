using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaList : MonoBehaviour
{
    public List<string> tiposInimigos = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        tiposInimigos.Add("Orc");
        tiposInimigos.Add("Elfo");
        tiposInimigos.Add("Anões");

        // tiposInimigos.Clear();

        // if(tiposInimigos.Contains("Orc"))
        // {
        //     Debug.Log("Existe um Orc!");
        // }

        tiposInimigos.Insert(0, "Lobos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
