using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum AIState
{
    Idle,
    Patrol,
    Attacking
}

public class Monster : MonoBehaviour
{
    [Header("Stats")]
    public int health;
    public float walkSpeed;
    public float runSpeed;

    [Header("AI")]
    private NavMeshAgent agent;
    public float detectDistance;
    private AIState aiState;

    private float playerDistance;

    public Transform patrolStartPosition;
    public Transform patrolEndPosition;

    bool isToStartPosition;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        aiState = AIState.Idle;
        isToStartPosition = true;
        agent.SetDestination(patrolEndPosition.position);
    }

    // Update is called once per frame
    void Update()
    {
        playerDistance = Vector3.Distance(transform.position, GameManager.Instance.playerController.transform.position);
    }

    public void ToggleDestination()
    {
        if (isToStartPosition)
        {
            isToStartPosition = false;
            agent.SetDestination(patrolEndPosition.position);
        }
        else
        {
            isToStartPosition = true;
            agent.SetDestination(patrolStartPosition.position);
        }
    }
}
