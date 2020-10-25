using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysicsController : MonoBehaviour
{

    public Vector2 movementVector;
    public float velocity = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Move()
    {
        if (movementVector.x != 0 || movementVector.y != 0)
        {
            transform.Translate(new Vector3(movementVector.x * Time.deltaTime * velocity, movementVector.y * Time.deltaTime * velocity, 0));
        }
    }
}
