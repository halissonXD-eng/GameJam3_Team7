using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public GameObject winMessage;
    public GameObject loseMessage;


    public void ShowWinMessage()
    {
        winMessage.SetActive(true);
        loseMessage.SetActive(false);
    }

   
     public void ShowLoseMessage()
    {
       loseMessage.SetActive(true);
        winMessage.SetActive(false);  
    }
}
