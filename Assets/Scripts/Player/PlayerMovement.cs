using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;

    //debe parar el personaje? con este boleano lo hace
    public bool stop;
    Rigidbody2D Rigid2D;
    Animator animatorPlayer;
    Animator treeAnimator;

    void Start()
    {
        animatorPlayer = GetComponent<Animator>();
        Rigid2D = GetComponent<Rigidbody2D>();
        treeAnimator = GameObject.Find("tree").GetComponent<Animator>();
    }

    private void FixedUpdate() 
    {
        if(!stop)
        {
            treeAnimator.SetBool("isRuning",true);
            Rigid2D.AddForce(Vector2.right * Speed);
        }
        else
        {
            treeAnimator.SetBool("isRuning",false);
        }    
    }
}
