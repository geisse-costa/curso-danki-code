using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaArray : MonoBehaviour
{
    // public string[] inimigo;
    public string[] meusInimigos = new string[] {"Orc","Elfo","Anões"};
    public GameObject[] inimigos;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(meusInimigos[2]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
