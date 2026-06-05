using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinishLine : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    public Transform ai1;
    public Transform ai2;

    public TextMeshProUGUI winnerText;

    private bool raceFinished = false;

    void Start()
    {
        winnerText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (raceFinished) return;

        if (player1.position.x >= transform.position.x)
        {
            EndRace("Pikachu wins!");
        }
        else if (player2.position.x >= transform.position.x)
        {
            EndRace("Meowth wins!");
        }
        else if (ai1.position.x >= transform.position.x)
        {
            EndRace("Reshiram wins!");
        }
        else if (ai2.position.x >= transform.position.x)
        {
            EndRace("Sylveon wins!");
        }
    }

    void GoToMainMenu()
    {
        Debug.Log("GOING TO MAIN MENU");
        SceneManager.LoadScene("MainMenu");
    }

    void EndRace(string message)
    {
        Debug.Log("FINISHLINE END RACE: " + message);

        raceFinished = true;

        winnerText.gameObject.SetActive(true);
        winnerText.text = message;

        Invoke(nameof(GoToMainMenu), 3f);
    }
}