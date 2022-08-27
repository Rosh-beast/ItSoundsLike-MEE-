
using UnityEngine;
using UnityEngine.AI;

public class EnemyAIBehaviour : MonoBehaviour
{
    public NavMeshAgent agent ;
    public Transform player;

    private float distance;

    public float playerInSightRange;
    

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        distance = Vector3.Distance(player.position,transform.position);
        if (distance <= playerInSightRange)
        {
            transform.LookAt(player);
            ChasePlayer();

        }
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }
    
}
