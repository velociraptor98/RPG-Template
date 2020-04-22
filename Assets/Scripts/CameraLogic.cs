using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLogic : MonoBehaviour
{
    // Start is called before the first frame update
    private float offset = 0.1f;
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCameraPosition();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CenterToPlayer();
        }
    }
    void CenterToPlayer()
    {
        transform.position = new Vector3(player.transform.position.x,transform.position.y,player.transform.position.z-5.0f);
    }
    void UpdateCameraPosition()
    {
        if(Input.mousePosition.x >= Screen.width)
        {
            // On right Side
            transform.position = new Vector3(transform.position.x + offset, transform.position.y, transform.position.z); 
        }
        else if(Input.mousePosition.x <= 0.0f)
        {
            // On left Side
            transform.position = new Vector3(transform.position.x - offset, transform.position.y, transform.position.z);
        }
        if(Input.mousePosition.y >= Screen.height)
        {
            // On top
            transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z + offset);
        }    
        else if(Input.mousePosition.y<=0.0f)
        {
            //On Bottom
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - offset);
        }
    }
}
