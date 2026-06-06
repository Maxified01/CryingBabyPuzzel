using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BabyCry baby;

    public TMP_Text winText;

    private bool won = false;

    void Start()
    {
        winText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (!won && !baby.isCrying)
        {
            won = true;

            winText.gameObject.SetActive(true);

            Debug.Log("YOU WIN!");
        }
    }
}