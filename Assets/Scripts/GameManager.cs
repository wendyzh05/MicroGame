using System.Collections;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text countdownText;

    public static bool raceStarted = false;

    void Start()
    {
        raceStarted = false;
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        countdownText.gameObject.SetActive(true);

        // ready
        countdownText.text = "READY?";
        yield return new WaitForSeconds(1.5f);

        // countdown
        countdownText.text = "3";
        yield return new WaitForSeconds(1f);

        countdownText.text = "2";
        yield return new WaitForSeconds(1f);

        countdownText.text = "1";
        yield return new WaitForSeconds(1f);

        // go 
        countdownText.text = "GO!";
        raceStarted = true;

        yield return new WaitForSeconds(1f);

        countdownText.gameObject.SetActive(false);
    }
}