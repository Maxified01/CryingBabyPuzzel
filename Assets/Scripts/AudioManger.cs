using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource audioSource;

    public AudioClip toyClip;
    public AudioClip milkClip;
    public AudioClip happyClip;

    void Awake()
    {
        Instance = this;
    }

    public void PlayToySound()
    {
        audioSource.PlayOneShot(toyClip);
    }

    public void PlayMilkSound()
    {
        audioSource.PlayOneShot(milkClip);
    }

    public void PlayHappySound()
    {
        if (happyClip == null)
            return;

        audioSource.Stop();

        audioSource.clip = happyClip;

        audioSource.loop = true;

        audioSource.Play();
    }
}