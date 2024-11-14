using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onDestroy : MonoBehaviour
{
    public GameObject objectToSpawn; // El GameObject que quieres que aparezca
    public Transform spawnPoint; // El punto exacto donde quieres que aparezca el nuevo objeto


    [SerializeField] private GameObject dieEffect;
    [SerializeField] private HealthBar healthBar;
    [SerializeField] private float maxHealth;
    private float health;
    private SpriteRenderer spriteRender;
    PlayerMovement playerMovement;

    private void Start() 
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        health = maxHealth;
        spriteRender = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            StartCoroutine(GetDamage());
        }
    }


    IEnumerator GetDamage()
    {
        float damageDuration = 0.1f;
        float damage = Random.Range(1f, 2f);
        health -= damage;
        healthBar.UpdateHealthBar(maxHealth, health);

        if (health >0)
        {
            spriteRender.color = Color.red;
            yield return new WaitForSeconds (damageDuration);
            spriteRender.color = Color.white;
        }

        else 
        {
            playerMovement.stop = false;
            Instantiate (dieEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
        }
    }
   
}
