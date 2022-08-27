
using UnityEngine;
using UnityEngine.AI;

public class EnemyAIBehaviour : MonoBehaviour
{
    public NavMeshAgent agent ;
    public Transform player;

    WayPoints EnemyProperties;

    private float distance;

    public float playerInSightRange;
    public float playerNotInRange;
    

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
