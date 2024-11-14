using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource fxSource;
    public Slider musicSlider;
    public Slider fxSlider;
    
   
    private bool isMusicMuted = false;
    private bool isFxMuted = false;
    
    // Start is called before the first frame update
    void Start()
    {
        musicSlider.value = musicSource.volume;
        fxSlider.value = fxSource.volume;

        musicSlider.onValueChanged.AddListener(SetMusicVolume);
        fxSlider.onValueChanged.AddListener(SetFxVolume);
    }

    // Update is called once per frame
    public void SetMusicVolume(float volume)
    {
       AudioManager.Instance.backgroundMusic.volume = isMusicMuted ? 0 : volume; 
    }

    public void SetFxVolume(float volume)
    {
        AudioManager.Instance.soundEffects.volume = isFxMuted ? 0 : volume;
    }

}
