using UnityEngine;

public class AIRacer : MonoBehaviour
{
    public float baseSpeed = 2f;
    public float clickBoost = 0.7f;
    public float maxSpeed = 10f;
    public float slowdownRate = 3f;

    public float mashInterval = 0.35f;
    public float randomness = 0.15f;

    private float currentSpeed;
    private float nextMashTime;

    void Start()
    {
        currentSpeed = baseSpeed;
        SetNextMashTime();
    }

    void Update()
    {
        if (!GameManager.raceStarted)
            return;
        if (Time.time >= nextMashTime)
        {
            float randomBoost = Random.Range(clickBoost * 0.5f, clickBoost * 1.5f);
            currentSpeed += randomBoost;
            currentSpeed = Mathf.Clamp(currentSpeed, baseSpeed, maxSpeed);

            SetNextMashTime();
        }

        currentSpeed = Mathf.MoveTowards(
            currentSpeed,
            baseSpeed,
            slowdownRate * Time.deltaTime
        );

        if (Random.value < 0.003f)
        {
            currentSpeed *= 0.5f;
        }

        if (Random.value < 0.003f)
        {
            currentSpeed += 2f;
        }

        transform.position += Vector3.right * currentSpeed * Time.deltaTime;
    }

    void SetNextMashTime()
    {
        nextMashTime = Time.time + Random.Range(
            mashInterval * 0.5f,
            mashInterval * 1.5f
        );
    }

    public void ResetSpeed()
    {
        currentSpeed = baseSpeed;
        SetNextMashTime();
    }
}
