using TMPro;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public float timeRemaining = 300f;

    public TMP_Text timerText;

    public BabyCry baby;

    public LoseUI loseUI;

    bool gameEnded = false;

    void Update()
    {
        if (gameEnded)
            return;

        if (!baby.isCrying)
            return;

        timeRemaining -= Time.deltaTime;

        int minutes =
            Mathf.FloorToInt(timeRemaining / 60);

        int seconds =
            Mathf.FloorToInt(timeRemaining % 60);

        timerText.text =
            minutes.ToString("00") +
            ":" +
            seconds.ToString("00");

        if (timeRemaining <= 0)
        {
            LoseGame();
        }
    }

    void LoseGame()
    {
        gameEnded = true;

        Time.timeScale = 0f;

        loseUI.ShowLoseScreen();
    }
}