using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaIfElse : MonoBehaviour
{
    public float vida;
    // Start is called before the first frame update
    void Start()
    {
        if (vida <= 1)
        {
            Debug.Log("Game Over!");
        }
        else
        {
            Debug.Log("Vivo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
