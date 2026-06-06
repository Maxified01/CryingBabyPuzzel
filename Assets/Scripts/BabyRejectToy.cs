using UnityEngine;

public class BabyRejectToy : MonoBehaviour
{
    public ClueManager clueManager;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        string toy = ToyInventory.currentToy;

        if (toy == "")
            return;

        bool correct =
            WrongOrderManager.Instance.CheckToy(toy);

        if (!correct)
        {
            return;
        }

        clueManager.RevealClue();

        clueManager.ShowRejectMessage();

        FindFirstObjectByType<ToyInventory>().ClearToy();

        Debug.Log("Baby rejected: " + toy);
    }
}