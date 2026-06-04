using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    public Transform spawnPoint;
    public Transform ai1;
    public Transform ai2;
    public AIRacer ai1Script;
    public AIRacer ai2Script;

    private bool raceFinished = false;

    void Update()
    {
        if (raceFinished) return;

        if (player1.position.x >= transform.position.x)
        {
            raceFinished = true;
            Debug.Log("Player 1 wins!");
            Invoke(nameof(RestartRace), 2f);
        }
        else if (player2.position.x >= transform.position.x)
        {
            raceFinished = true;
            Debug.Log("Player 2 wins!");
            Invoke(nameof(RestartRace), 2f);
        }

        else if (ai1.position.x >= transform.position.x)
        {
            raceFinished = true;
            Debug.Log("AI 1 wins!");
            Invoke(nameof(RestartRace), 2f);
        }
        else if (ai2.position.x >= transform.position.x)
        {
            raceFinished = true;
            Debug.Log("AI 2 wins!");
            Invoke(nameof(RestartRace), 2f);
        }
    }

    void RestartRace()
    {
        player1.position = spawnPoint.position;
        player2.position = spawnPoint.position + Vector3.down * 2f;
        ai1.position = spawnPoint.position + Vector3.down * 1f;
        ai2.position = spawnPoint.position + Vector3.down * 2f;

        ai1Script.ResetSpeed();
        ai2Script.ResetSpeed();

        raceFinished = false;
    }
}