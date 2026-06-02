using UnityEngine;

public class FeedBaby : MonoBehaviour
{
    public BabyCry baby;
    public PickupMilk player;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");

        if (baby == null)
            Debug.Log("Baby reference missing!");

        if (player == null)
            Debug.Log("Player reference missing!");

        if (other.CompareTag("Player") && player != null && player.hasMilk)
        {
            baby.isCrying = false;
            Debug.Log("Baby Fed!");
        }
    }
}