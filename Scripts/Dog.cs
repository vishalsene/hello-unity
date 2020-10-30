using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public Animator animator3;
    Rigidbody2D mRigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        mRigidBody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // Initial dog animation is using x velocity and then dog jumps at certain x position
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0);
        if(this.transform.position.x > -1)
        {
            mRigidBody2D.AddForce(Vector2.up * 10);

            animator3.SetBool("PosToJump", true);

        }

        // After Dog jumps, object is destroyed.
        if(this.transform.position.y > -2.8)
        {
            Destroy(gameObject);
        }
    }
}
