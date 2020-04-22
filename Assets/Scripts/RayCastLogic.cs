using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class RayCastLogic : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent agent;
    [SerializeField]
    private GameObject clickSphere;
    private float clickSize;
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
        if(clickSize>0.0f)
        {
            clickSize -= Time.deltaTime;
            clickSphere.transform.localScale = clickSize * Vector3.one;
        }
    }
    void RayCastCameraToMouse()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray,out hit,100.0f))
        {
            agent.SetDestination(hit.point);
            DisplayClick(hit.point);
        }
    }
    void DisplayClick(Vector3 hitPos)
    {
        clickSize = 1.0f;
        clickSphere.transform.localScale = Vector3.one;
        clickSphere.transform.position = hitPos;
    }
}
