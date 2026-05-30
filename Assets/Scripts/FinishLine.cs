using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public Transform player;

    private bool finished = false;

    void Update()
    {
        if (!finished && player.position.x >= transform.position.x)
        {
            finished = true;
            Debug.Log("You finished!");
        }
    }
}
