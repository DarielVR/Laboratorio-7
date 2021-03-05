using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Patrullaje : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent agent;
    public GameObject WayPoints;
    List<Vector3> waypoints;
    public int currentnWP;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        waypoints = new List<Vector3>();

        if(WayPoints) {
            foreach( Transform child in WayPoints.transform){
                waypoints.Add(child.position);
            }
        }

        agent.obstacleAvoidanceType = ObstacleAvoidanceType.NoObstacleAvoidance;
    }

    // Update is called once per frame
    void Update()
    {
        if (agent) {
            if (agent.remainingDistance < 0.5f) {
                currentnWP++;
                currentnWP = currentnWP % waypoints.Count;
                agent.SetDestination(waypoints[currentnWP]);
            }
        }
    }

    void OnTriggerEnter (Collider collider){
        if (collider.gameObject.CompareTag("Player")){
            Destroy(collider.gameObject); 
        }
    }
}
