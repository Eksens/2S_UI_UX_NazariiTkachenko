using UnityEngine;

public class ButtonClickSound : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip   clickSound;

    public static ButtonClickSound Instance { get; private set; }

    void Awake()
    {
        Instance = this;
    }

    public void PlayClickSound()
    {
        if (audioSource != null && clickSound != null)
            audioSource.PlayOneShot(clickSound);
    }

    public static void Play()
    {
        Instance?.PlayClickSound();
    }
}
