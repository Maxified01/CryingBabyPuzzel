using UnityEngine;

public class ToyClue : MonoBehaviour
{
    public string toyName;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        ToyInventory inventory =
            FindFirstObjectByType<ToyInventory>();

        if (inventory != null)
        {
            inventory.PickToy(toyName, gameObject);

            AudioManager.Instance.PlayToySound();

            gameObject.SetActive(false);
        }

        Debug.Log("Picked toy: " + toyName);
    }
}