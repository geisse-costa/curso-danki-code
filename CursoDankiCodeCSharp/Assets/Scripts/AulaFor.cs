using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaFor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int contador;
        //for(comando de inicialização; condição; operador de incremento/decremento){}
        for(contador = 0; contador < 10; contador++)
        {
            Debug.Log(contador);
        }
        
        Debug.Log("O valor final do contador é: " + contador);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
