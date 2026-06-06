using UnityEngine;

public class BabyAnimator : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Celebrate()
    {
        anim.Play("Celebrates");
    }

    public void Cry()
    {
        anim.Play("Idle");
    }
}