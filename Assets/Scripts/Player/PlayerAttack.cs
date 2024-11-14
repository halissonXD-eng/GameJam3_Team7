using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject Bullet;
    Transform Attach;
    Animator treeAnimator;
    public AudioClip clip;
    private void Start() 
    {
        treeAnimator = GameObject.Find("tree").GetComponent<Animator>();
        Attach = GameObject.Find("AttachFire").GetComponent<Transform>();    
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            treeAnimator.SetTrigger("Attack");
        }
    }
    public void Fire()
    {
        AudioManager.Instance.PlaySFX(clip);
        Instantiate(Bullet,Attach.position,Attach.rotation);
    }
}
