using UnityEngine;

public class PickupMilk : MonoBehaviour
{
    public bool hasMilk = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Milk"))
        {
            hasMilk = true;

            AudioManager.Instance.PlayMilkSound();

            Debug.Log("Milk Picked Up!");

            Destroy(other.gameObject);
        }
    }
}