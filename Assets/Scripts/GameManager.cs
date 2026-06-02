using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BabyCry baby;

    void Update()
    {
        if (baby == null)
            return;

        if (!baby.isCrying)
        {
            Debug.Log("YOU WIN!");
        }
    }
}