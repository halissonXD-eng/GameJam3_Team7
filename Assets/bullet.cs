using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    public float life = 20f;
    public float Damage;
    public float timeLife;
    
    Rigidbody2D BulletRb;
    private void Start() 
    {
        BulletRb = GetComponent<Rigidbody2D>();
    }
    private void Update() 
    {
        BulletRb.AddForce(transform.right * speed);
        timeLife += Time.deltaTime;
        
        if(timeLife >= life)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
