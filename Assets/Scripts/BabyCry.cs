using UnityEngine;

public class BabyCry : MonoBehaviour
{
    public bool isCrying = true;

    private Animator anim;
    private AudioSource audioSource;

    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        if (anim != null)
            anim.Play("Idle");
    }

    public void StopCrying()
    {
        isCrying = false;

        if (anim != null)
            anim.Play("Celebrates");

        if (audioSource != null)
            audioSource.Stop();
    }
}