using UnityEngine;

public class ToyInventory : MonoBehaviour
{
    public static string currentToy = "";

    public static GameObject currentToyObject;

    public void PickToy(string toyName, GameObject toyObject)
    {
        currentToy = toyName;

        currentToyObject = toyObject;

        Debug.Log("Picked up: " + toyName);
    }

    public void ClearToy()
    {
        currentToy = "";

        currentToyObject = null;
    }
}