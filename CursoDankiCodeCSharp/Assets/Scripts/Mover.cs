using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Translate é utilizado para movimentar um objeto sem Rigidbody
        //Até pode ser utilizado com Rigidbody, mas não é uma boa prática
        //Executar a movimentação a cada frame
        //                          posição
        //transform.Translate(Vector3.left);
        //Multiplicar posição por time.deltaTime (tempo relativo no jogo, deixa fluído) e multiplicar por uma velocidade
        //Pode trocar esse tempo por uma variável pública --> Modificar direto na Unity
        //                              Esquerda é negativo e direira é positivo
        //transform.Translate(new Vector3(-1f,0f,0f) * Time.deltaTime * velocidade);
        
        //Para mover pra frente forward (0,0,1) --> Mexe no Z
        //transform.Translate(Vector3.forward * Time.deltaTime * velocidade);
        //Para mover pra trás -Vector3.forward --> -Z
        //transform.Translate(-Vector3.forward * Time.deltaTime * velocidade);

        //Para mover para todos os lados
        //transform.Translate(new Vector3(1,1,1) * Time.deltaTime * velocidade);

        //Para rotacionar
        //Space.Self indica se ele vai rotacionar no próprio eixo ou Space.World no eixo global
        //Ele vai somando 10 a cada frame, até que chegue 360 e ele retorne do início
        transform.Rotate(0f,0f,10f, Space.Self);

    }
}
