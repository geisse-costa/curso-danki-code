using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetMouseButton também é reconhecido pelo touch do celular
        if(Input.GetMouseButton(0))
        {
            //mousePosition retorna a posição do mouse na cena
            Vector3 mousePos = Input.mousePosition; //mousePosition retorna um valor muito grande e o ScreenToWorldPoint converte esse valor para a posição que estamos vendo na cena
            mousePos.z = 10f; //Distancia que o objeto vai ter da camera, passou o valor no eixo z

            //Para o objeto seguir o mouse
            //ScreenToWorldPoint converte no espaço do mundo as coordenadas que forem passadas dentro do argumento, se não o mouse vai se mover em uma posição que não vamos ver na cena
            transform.position = Camera.main.ScreenToWorldPoint(mousePos);
        }

        //Detectar o mouse, 0 é o botão esquerdo e 1 é o direito
        //Detecta o clique em qualquer lugar da cena
        // if(Input.GetMouseButton(0))
        // {
        //     Debug.Log("Clicou");
        // }

        //Vai ser chamado uma vez, apenas quando clica, também sem precisar clicar no objeto necessariamente
        // if(Input.GetMouseButtonDown(0))
        // {
        //     Debug.Log("Clicou");
        // }
    }

    //Detectar o mouse
    private void OnMouseDown()
    {
        Debug.Log("Down");
    }

    private void OnMouseDrag()
    {
        Debug.Log("Drag");
    }

    private void OnMouseUp()
    {
       Debug.Log("Up"); 
    }

    private void OnMouseExit()
    {
        Debug.Log("Exit");
    }
}
