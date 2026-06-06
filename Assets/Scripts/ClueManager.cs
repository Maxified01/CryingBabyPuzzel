using TMPro;
using UnityEngine;
using System.Collections;

public class ClueManager : MonoBehaviour
{
    public TMP_Text clueText;
    public TMP_Text clueCounterText;
    public TMP_Text objectiveText;
    public TMP_Text rejectText;
    public TMP_Text timerText;

    public GameObject milkBottle;

    private string[] clues = { "F", "O", "O", "D" };

    private int currentClue = 0;
    private string word = "";

    public void ShowRejectMessage()
    {
        StartCoroutine(RejectRoutine());
    }

    IEnumerator RejectRoutine()
    {
        rejectText.gameObject.SetActive(true);

        yield return new WaitForSeconds(2f);

        rejectText.gameObject.SetActive(false);
    }

    public void RevealClue()
    {
        if (currentClue >= clues.Length)
            return;

        word += clues[currentClue];

        currentClue++;

        clueText.gameObject.SetActive(true);

        clueText.text = "Clue: " + word;

        clueCounterText.text = currentClue + "/4";

        Debug.Log("Found clue: " + word);

        if (word == "FOOD")
        {
            objectiveText.text =
                "The clue says FOOD!\nMaybe the baby is hungry...";

            if (milkBottle != null)
            {
                milkBottle.SetActive(true);

                Debug.Log("Milk revealed!");
            }
        }
    }

    public void HideGameplayUI()
    {
        clueText.gameObject.SetActive(false);

        clueCounterText.gameObject.SetActive(false);

        objectiveText.gameObject.SetActive(false);

        timerText.gameObject.SetActive(false);

        rejectText.gameObject.SetActive(false);
    }
}