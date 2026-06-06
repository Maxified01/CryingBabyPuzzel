using UnityEngine;
using UnityEngine.SceneManagement;

public class WrongOrderManager : MonoBehaviour
{
    public static WrongOrderManager Instance;

    private string[] correctOrder =
    {
        "Car",
        "Teddy",
        "Train",
        "Purple Bear"
    };

    private int currentStep = 0;

    void Awake()
    {
        Instance = this;
    }

    public bool CheckToy(string toyName)
    {
        if (toyName == correctOrder[currentStep])
        {
            currentStep++;

            return true;
        }

        LoseGame();

        return false;
    }

    void LoseGame()
    {
        Debug.Log("Wrong Toy!");

        WrongToyUI.Instance.Show();
    }
}