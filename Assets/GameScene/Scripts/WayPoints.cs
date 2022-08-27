
using UnityEngine;
using UnityEngine.AI;

public class WayPoints : MonoBehaviour
{
    public Transform[] waypoint;
    NavMeshAgent agent;
    int waypointIndex;
    Vector3 target;
    public Transform player2;
    public float Space;
    //public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //anim = GetComponent<Animator>();
        updateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1)
        {
            updateDestination();
            iterateWaypoint();
            //anim.Play("Walking");
            
        }
        Space = Vector3.Distance(transform.position, player2.position);
        if (Space >10)
        {
            updateDestination();
        }
    }

    public void updateDestination()
    {
        target = waypoint[waypointIndex].position;
        agent.SetDestination(target);

    }
    public void iterateWaypoint()
    {
        waypointIndex++;
        if (waypointIndex == waypoint.Length)
        {
            waypointIndex = 0;
        }
    }
}
