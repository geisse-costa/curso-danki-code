using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    private Rigidbody rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
    }

    //Quando está trabalhando com Rigibody, é preciso utilizar o método FixedUpdate, pois ele trabalha com a física da Unity e pode ou não ser chamado a cada frame
    //Ele evita problemas na taxa de frames, por ter vários utilizando o Update, e o FixedUpdage é otimizado para física
    private void FixedUpdate()
    {
        //Chamado a cada frame enquanto pressionar o botão W do teclado
        //get.KeyDown --> Chama apenas uma vez, quando pressionasse o botão
        //get.KeyUp --> Chamado quando pressionasse o botão e tirasse o dedo do botão
        //get.Key --> A cada frame
        if(Input.GetKey(KeyCode.D)) //Pra direita
        {
            rig.velocity = new Vector3(1f,0f,0f);
        }

        if(Input.GetKey(KeyCode.A)) //Pra esquerda
        {
            rig.velocity = new Vector3(-1f,0f,0f);
        }

        if(Input.GetKey(KeyCode.W)) //Pra frente
        {
            rig.velocity = new Vector3(0f,0f,1f);
        }

        if(Input.GetKey(KeyCode.S)) //Pra trás
        {
            rig.velocity = new Vector3(0f,0f,-1f);
        }

        if(Input.GetKey(KeyCode.Space)) //Pra cima
        {
            rig.velocity = new Vector3(0f,1f,0f);
        }
    }

    //Um tem que ter Rigidbody e os outros precisam ter colisores
    //Detecta colisão no primeiro toque do objeto
    // private void OnCollisionEnter(Collision collision)
    // {
    //     Debug.Log("Enter");
    // }

    // //É chamado ao parar de colidir com um outro objeto
    // private void OnCollisionExit(Collision collision)
    // {
    //     Debug.Log("Exit");
    // }

    // //É chamado enquando o objeto colide com outro
    // private void OnCollisionStay(Collision collision)
    // {
    //     Debug.Log("Stay");
    // }
}