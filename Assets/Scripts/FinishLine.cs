using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
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
        }
        else if (player2.position.x >= transform.position.x)
        {
            raceFinished = true;
            Debug.Log("Player 2 wins!");
        }

        else if (ai1.position.x >= transform.position.x)
        {
            raceFinished = true;
            Debug.Log("AI 1 wins!");
        }
        else if (ai2.position.x >= transform.position.x)
        {
            raceFinished = true;
            Debug.Log("AI 2 wins!");
        }
    }

}