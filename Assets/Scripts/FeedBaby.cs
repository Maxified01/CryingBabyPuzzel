using UnityEngine;

public class FeedBaby : MonoBehaviour
{
    public BabyCry baby;
    public PickupMilk player;

    public GameObject door;

    public GameObject endText;

    private BabyAnimator babyAnimator;
    private AudioSource babyAudio;

    void Start()
    {
        babyAnimator =
            baby.GetComponentInChildren<BabyAnimator>();

        babyAudio =
            baby.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") &&
            player.hasMilk)
        {
            baby.isCrying = false;

            if (babyAudio != null)
            {
                babyAudio.Stop();
            }

            AudioManager.Instance.PlayHappySound();

            babyAnimator.Celebrate();

            ClueManager clueManager =
                FindFirstObjectByType<ClueManager>();

            if (clueManager != null)
            {
                clueManager.HideGameplayUI();
            }

            if (door != null)
            {
                door.SetActive(false);
            }

            if (endText != null)
            {
                endText.SetActive(true);
            }

            Debug.Log("Baby Fed!");
        }
    }
}