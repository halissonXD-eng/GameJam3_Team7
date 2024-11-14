using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource backgroundMusic;
    public AudioSource soundEffects;

    public AudioClip shootingSound;
    public AudioClip enemyDestroyedSound;
    
    
    private void Awake()
    {
       if (Instance == null)
       {
         Instance = this;
         DontDestroyOnLoad(gameObject);
       }

       else
       {
         Destroy(gameObject);
       }
    }

    
    public void PlayBackgroundMusic(AudioClip music)
    {
        backgroundMusic.Stop();
        backgroundMusic.clip = music;
        backgroundMusic.Play();
        backgroundMusic.loop = true;
       
    }
    public void PlaySFX(AudioClip clip)
    {
      soundEffects.PlayOneShot(clip);
    }

    public void StopBackgroundMusic()
    {
        backgroundMusic.Stop();
    }

    public void PlayShootingSound()
    {
        soundEffects.PlayOneShot(shootingSound);
    }

    public void PlayEnemyDestroyedSound()
    {
        soundEffects.PlayOneShot(enemyDestroyedSound);
    }
}
