using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{   
    public GameObject GoalScreen;
    // Start is called before the first frame update
    void Start()
    {
        GoalScreen.SetActive(false);
    }

    void OnTriggerEnter (Collider collider){
        if (collider.gameObject.CompareTag("Player")){
            GoalScreen.SetActive(true);
            Time.timeScale = GoalScreen.activeSelf ? 0.0f: 1.0f;
        }
    }
}
