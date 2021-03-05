using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navegacion : MonoBehaviour
{   
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.obstacleAvoidanceType = ObstacleAvoidanceType.NoObstacleAvoidance;
    }

    // Update is called once per frame
    void Update()
    {
    
        if (Input.GetMouseButton(0)){
            RaycastHit info;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out info)) {
                NavMeshHit hit;
                if (NavMesh.SamplePosition(info.point, out hit, 2, NavMesh.AllAreas)){
                    agent.SetDestination(hit.position);
                }
            }
        }
    }

}
