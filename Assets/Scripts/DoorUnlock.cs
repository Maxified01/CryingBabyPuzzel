using UnityEngine;

public class DoorUnlock : MonoBehaviour
{
    public void UnlockDoor()
    {
        Destroy(GetComponent<Collider>());

        transform.Rotate(0, 90, 0);
    }
}