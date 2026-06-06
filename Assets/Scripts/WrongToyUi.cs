using UnityEngine;

public class WrongToyUI : MonoBehaviour
{
    public static WrongToyUI Instance;

    public GameObject panel;

    void Awake()
    {
        Instance = this;

        panel.SetActive(false);
    }

    public void Show()
    {
        panel.SetActive(true);
    }

    public void Retry()
    {
        if (ToyInventory.currentToyObject != null)
        {
            ToyInventory.currentToyObject.SetActive(true);
        }

        ToyInventory.currentToy = "";
        ToyInventory.currentToyObject = null;

        panel.SetActive(false);
    }
}