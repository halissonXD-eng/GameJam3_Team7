using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public AudioClip music;
    
    public AudioClip Buttons;
    private void Start() 
    {
        AudioManager.Instance.PlayBackgroundMusic(music);
    }
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadScene(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
    public void PlaySFXButton()
    {
        AudioManager.Instance.PlaySFX(Buttons);
    }
    // Update is called once per frame
    public void OpenSettings()
    {
        Debug.Log("Loading...");
    }

    public void OpenCredits()
    {
        Debug.Log("Loading...");
    }
}
