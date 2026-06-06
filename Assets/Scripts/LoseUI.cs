using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoseUI : MonoBehaviour
{
    public GameObject losePanel;

    public TMP_Text loseText;

    void Start()
    {
        losePanel.SetActive(false);

        loseText.gameObject.SetActive(false);
    }

    public void ShowLoseScreen()
    {
        losePanel.SetActive(true);

        loseText.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }
}