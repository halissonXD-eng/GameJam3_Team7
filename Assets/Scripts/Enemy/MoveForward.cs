using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;
    public Animator attack;

    private void Start() 
    {
        attack = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D (Collision2D other) 
    {
        if(other.collider.CompareTag("Player"))
        {
            attack.SetBool("Colision_player", true);
        }
    }
}
