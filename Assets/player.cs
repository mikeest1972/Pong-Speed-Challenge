using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Transform playerT;


    private float deltaMove = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.W))
        {
            // go up
            Vector3 pos = new Vector3(playerT.position.x,playerT.position.y + deltaMove*Time.deltaTime,playerT.position.z);
            playerT.SetPositionAndRotation(pos, playerT.rotation);

        }
        else if(Input.GetKey(KeyCode.S))
        {
            // goes down
            Vector3 pos = new Vector3(playerT.position.x,playerT.position.y - deltaMove*Time.deltaTime,playerT.position.z);
            playerT.SetPositionAndRotation(pos, playerT.rotation);
        }
        
    }
}
