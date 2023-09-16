using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaVectors : MonoBehaviour
{
    //Usado em jogos 2D
    public Vector2 pos;
    //Usado em jogos 2D
    public Vector3 pos2;

    // Start is called before the first frame update
    void Start()
    {
        //                  x,y,z
        pos2 = new Vector3(1f,1f,1f);

        //Move o objeto para uma direção
        transform.position = pos2;
        //Acessar uma posição individual do vector
        pos2.z = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
