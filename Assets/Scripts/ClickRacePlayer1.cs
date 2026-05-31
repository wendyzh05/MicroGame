using UnityEngine;
using UnityEngine.InputSystem;

public class ClickRacePlayer1 : MonoBehaviour
{
    public float baseSpeed = 2f;
    public float clickBoost = 0.7f;
    public float maxSpeed = 10f;
    public float slowdownRate = 3f;

    private float currentSpeed;

    void Start()
    {
        currentSpeed = baseSpeed;
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            currentSpeed += clickBoost;
            currentSpeed = Mathf.Clamp(currentSpeed, baseSpeed, maxSpeed);
        }

        currentSpeed = Mathf.MoveTowards(currentSpeed, baseSpeed, slowdownRate * Time.deltaTime);

        transform.position += Vector3.right * currentSpeed * Time.deltaTime;
    }
}
