using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class AulaInstantiateDestroy : MonoBehaviour
{
    //Depois prreciso criar uma variável local, pois não posso mexer nessa
    public GameObject cubo;
    // Start is called before the first frame update
    void Start()
    {
        //Esse método cria a cópia de um objeto
        //Necessita de 3 argumentos para funcionar bem (o próprio objeto,posição,rotação)
        //Não posso distruir a variável, então precisa criar uma variável local
        //GameObject copiaCubo = Instantiate(cubo, new Vector3(1f,1f,1f), transform.rotation);
        //                                      posição obj c/ script, rotação obj c/ script
        GameObject copiaCubo = Instantiate(cubo, transform.position, transform.rotation);
        //Atenção para o g minúsculo e colocar um timer 2s (float)
        Destroy(copiaCubo.gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
