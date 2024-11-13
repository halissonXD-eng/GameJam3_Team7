using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepet : MonoBehaviour
{
    [SerializeField] float Speed = 30;
    [SerializeField] float repeatWidth;
    Vector3 StartPos;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < StartPos.x + repeatWidth || transform.position.x > StartPos.x - repeatWidth )
        {
            transform.position = StartPos;
        }
        transform.Translate(Vector3.left * Time.deltaTime * Speed);
    }
}
