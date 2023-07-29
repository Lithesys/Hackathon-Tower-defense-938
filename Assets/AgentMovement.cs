using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentMovement : MonoBehaviour
{
    [SerializeField] public Transform startPoint;
    [SerializeField]public Transform endPoint;
    private UnityEngine.AI.NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        // agent.updateRotation = false;
        // agent.updateUpAxis = false;
        if (startPoint != null)
        {
            transform.position = startPoint.position;
        }
        MoveToDestination();
    }

    private void MoveToDestination()
    {
        agent.SetDestination(endPoint.position);
    }

    private void Update()
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            agent.isStopped = true;
            Debug.Log("Đã đến điểm đích!");
            // gameObject.SetActive(false);
        }
    }
}
