using UnityEngine;

public class audioTest : MonoBehaviour
{
    public AudioClip backgroundMusic;

    void Start()
    {
        if (audioPlayer.Instance != null)
        {
            audioPlayer.Instance.PlayBGMusic(backgroundMusic);
        }
    }
}
