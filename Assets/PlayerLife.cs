using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public float MaxLife;
    [HideInInspector] public float life;


    private void Start() 
    {
        life = MaxLife;
    }
    private void Update() 
    {
        if(life <=0)
        Muerte();
    }

    public void RecoverLife()
    {
        life = MaxLife;
    }

    public void Muerte()
    {
        //aqui se muere el personaje o se destruye cualquier cosa
    }
}
