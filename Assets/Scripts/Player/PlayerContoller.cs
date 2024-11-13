using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public float Life;
    public float Speed;

    //debe parar el personaje? con este boleano lo hace
    public bool stop;
    Rigidbody2D Rigid2D;
    Animator animatorPlayer;
    [SerializeField] Animator animatorRino;

    void Start()
    {
        animatorPlayer = GetComponent<Animator>();
        Rigid2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() 
    {
        if(!stop)
        {
            animatorRino.SetBool("isRuning",true);
            Rigid2D.AddForce(Vector2.right * Speed);
        }
        else
        {
            animatorRino.SetBool("isRuning",false);
        }    
    }
}
