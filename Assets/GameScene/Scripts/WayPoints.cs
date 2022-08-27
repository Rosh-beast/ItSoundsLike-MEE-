
using UnityEngine;
using UnityEngine.AI;

public class WayPoints : MonoBehaviour
{
    public Transform[] waypoint;
    NavMeshAgent agent;
    int waypointIndex;
    Vector3 target;
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


    }

    void updateDestination()
    {
        target = waypoint[waypointIndex].position;
        agent.SetDestination(target);

    }
    void iterateWaypoint()
    {
        waypointIndex++;
        if (waypointIndex == waypoint.Length)
        {
            waypointIndex = 0;
        }
    }
}
