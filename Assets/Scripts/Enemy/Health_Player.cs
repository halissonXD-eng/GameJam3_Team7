using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Player : MonoBehaviour
{
    /*[SerializeField] private GameObject dieEffect;*/
    [SerializeField] private HealthBar healthBar;
    [SerializeField] private float maxHealth;
    private float health;
    private SpriteRenderer spriteRender;

    [SerializeField] GameObject LoseUI;
    
    private void Start() 
    {
        health = maxHealth;
        spriteRender = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Chicken"))
        {
            StartCoroutine(GetDamage());
        }
    }

    IEnumerator GetDamage()
    {
        float damageDuration = 0.1f;
        float damage = Random.Range(1f, 2f);
        health -= damage;
        healthBar.UpdateHealthBar(maxHealth, health);

        if (health > 0)
        {
            spriteRender.color = Color.red;
            yield return new WaitForSeconds (damageDuration);
            spriteRender.color = Color.white;
        }
        else 
        {
            Time.timeScale = 0f; 
            LoseUI.SetActive(true);
        }
    }

    
}
