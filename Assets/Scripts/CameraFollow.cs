using UnityEngine;

public class CameraFollowRace : MonoBehaviour
{
    public Transform player1;
    public Transform player2;

    public float followSpeed = 5f;

    void LateUpdate()
    {
        float midpointX = (player1.position.x + player2.position.x) / 2f;

        Vector3 targetPosition = new Vector3(
            midpointX,
            transform.position.y,
            transform.position.z
        );

        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            followSpeed * Time.deltaTime
        );
    }
}
