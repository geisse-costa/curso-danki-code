using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileDo : MonoBehaviour
{
    int vida = 5;
    // Start is called before the first frame update
    void Start()
    {
        // while(vida <10)
        // {
        //     vida++;
        // }
        
        // Debug.Log(vida);

        do
        {
            Debug.Log(vida);
            vida++;
        } while(vida < 10);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
