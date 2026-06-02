using UnityEngine;

public class PickupMilk : MonoBehaviour
{
    public bool hasMilk = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Milk"))
        {
            hasMilk = true;

            Destroy(other.gameObject);

            Debug.Log("Milk Picked Up!");
        }
    }
}