using UnityEngine;

public class flee : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange, visionRange;

    [SerializeField]
    float moveSpeed;

    [SerializeField]
    float walkRadius;

    Rigidbody rb;
    private float disToPlayer;
    private Vector3 randomDestination;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetRandomDestination();
    }

    void Update()
    {
        disToPlayer = Vector3.Distance(this.transform.position, player.transform.position);

        Vector3 directionToPlayer = player.transform.position - transform.position;
        directionToPlayer.y = 0;
        Vector3 directionNormalized = directionToPlayer.normalized;

        Debug.Log(disToPlayer);

        if (disToPlayer < visionRange)
        {
            if (disToPlayer < agroRange)
            {
                MoveInDirection(-directionNormalized);
                Debug.Log("Get The Hell Away From Me!");
            }
        }
        else
        {
            MoveToRandomDestination();
        }
    }

    void SetRandomDestination()
    {
        Vector3 randomDirection = UnityEngine.Random.insideUnitSphere * walkRadius;
        randomDirection.y = 0;
        randomDestination = transform.position + randomDirection;
    }

    void MoveToRandomDestination()
    {
        Vector3 directionToDestination = randomDestination - transform.position;
        directionToDestination.y = 0;

        if (Vector3.Distance(transform.position, randomDestination) < 0.5f)
        {
            SetRandomDestination();
        }
        else
        {
            MoveInDirection(directionToDestination.normalized);
        }
    }

    void MoveInDirection(Vector3 direction)
    {
        rb.transform.position += direction * (moveSpeed * Time.deltaTime);
        RotateTowardsDirection(direction);
    }

    void RotateTowardsDirection(Vector3 direction)
    {
        if (direction.sqrMagnitude > 0.01f)
        {
            Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, moveSpeed * Time.deltaTime * 100);
        }
    }
}