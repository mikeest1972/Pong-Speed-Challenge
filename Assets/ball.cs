using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    public Rigidbody2D ballPhysics;
    public Transform ballT;

    private float speed = 3;
    private float upperBound = 5.15f;
    private float lowerBound = -5.15f;

    private float pScoreBound = 7f;
    private float eScoreBound = -7f;

    public bool playerScored;
    public bool enemyScored;
    // Start is called before the first frame update
    void Start()
    {
        initialPush();
        playerScored = false;
        enemyScored = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        checkIfOutsideOfScene();
        checkIfAnyoneScored();
    }

    private void initialPush()
    {
        Vector2 v = new Vector2(1,1);
        ballPhysics.velocity = speed * v;
    }

    private void checkIfOutsideOfScene()
    {
        float y = ballT.position.y;
        if((y > upperBound) || (y < lowerBound))
        {
            ballPhysics.velocity = new Vector2(ballPhysics.velocity.x, -1* ballPhysics.velocity.y);

        }
        

    }
    public void gameOver()
    {
        Destroy(this);
    }
    private void checkIfAnyoneScored()
    {
        if(pScoreBound < ballT.position.x)
        {
            // player scored
            print("Player scored");
            playerScored = true;
            enemyScored = false;
        }
        else if(eScoreBound > ballT.position.x)
        {
            print("Enemy Scored");
            enemyScored = true;
            playerScored = false;
        }

    }

    public void resetBall()
    {
        enemyScored = false;
        playerScored = false;
        ballT.SetPositionAndRotation(new Vector3(0,0,0),ballT.rotation);
        initialPush();
    }
}
