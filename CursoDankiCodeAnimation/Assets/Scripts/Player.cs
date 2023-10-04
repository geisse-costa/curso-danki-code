using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rig;
    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Atacar
        if(Input.GetKeyDown(KeyCode.X))
        {
            anim.SetBool("isAtack", true);
        }

        if(Input.GetKeyUp(KeyCode.X))
        {
            anim.SetBool("isAtack", false);
        }

        //Correr
        if(Input.GetKey(KeyCode.D)) //GetKey é a cada frame
        {
            rig.velocity = Vector2.right * speed;
            anim.SetBool("isRun", true);
            transform.eulerAngles = new Vector2(0f, 180f);
        }

        else if(Input.GetKey(KeyCode.A))
        {
            rig.velocity = Vector2.left * speed;
            anim.SetBool("isRun", true);
            transform.eulerAngles = new Vector2(0f, 0f);
        }
        else
        {
            anim.SetBool("isRun", false);
        }


    }

}
