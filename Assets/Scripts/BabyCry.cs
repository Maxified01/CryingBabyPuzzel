using UnityEngine;

public class BabyCry : MonoBehaviour
{
    public bool isCrying = true;

    public void FeedBaby()
    {
        isCrying = false;
        Debug.Log("Baby has been fed!");
    }
}