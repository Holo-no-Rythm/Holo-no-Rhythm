using UnityEngine;

public class audioPlayer: MonoBehaviour
{
    public static audioPlayer Instance { get; private set; }
    private AudioSource audioSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = gameObject.AddComponent<AudioSource>();
            Debug.Log("MusicManager Initialized");
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayBGMusic(AudioClip clip, double startTime= 0.0)
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        audioSource.clip = clip;
        if (startTime > 0.0)
        {
            audioSource.PlayScheduled(AudioSettings.dspTime + startTime);
        }
        else{
            audioSource.Play();
        }
    }

    public void StopMusic()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
