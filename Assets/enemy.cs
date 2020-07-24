using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform ballT;
    public Transform enemyT;

    private float velocity = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        goToBall();
        
    }

    private void goToBall()
    {
        Vector3 ballP = ballT.position;
        Vector3 enemyP = enemyT.position;

        Vector3 deltaVector = ballP - enemyP;
        Vector3 unitVector;
        if(deltaVector.y == 0)
        {
            unitVector = new Vector3(0,(deltaVector.y)/(1),0);

        }
        else
        {
            unitVector = new Vector3(0,(deltaVector.y)/(Mathf.Abs(deltaVector.y)),0);
        }
        Vector3 goTo = new Vector3(enemyP.x,velocity*unitVector.y*Time.deltaTime + enemyP.y,enemyP.z);
        enemyT.SetPositionAndRotation(goTo, enemyT.rotation);


    }
}
