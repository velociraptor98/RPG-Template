using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class RayCastLogic : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent agent;
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            RayCastCameraToMouse();
        }
    }
    void RayCastCameraToMouse()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray,out hit,100.0f))
        {
            Debug.Log("Ray hit");
            agent.SetDestination(hit.point);
        }
    }
}
