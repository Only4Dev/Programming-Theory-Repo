using UnityEngine;
using System.Collections;

public class GameMusicPlayer : MonoBehaviour
{
    [SerializeField] public  AudioSource audioSource;
    private static GameMusicPlayer instance = null;

    public static GameMusicPlayer Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
            PlayMusic();
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void PlayMusic()
    {
        if (audioSource.isPlaying)
        {
            // nothing
        }
        else
        {
            audioSource.Play();
        }
    }
}
