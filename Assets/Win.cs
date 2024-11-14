using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] GameObject win;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            win.SetActive(true);

        }    
    }
}
