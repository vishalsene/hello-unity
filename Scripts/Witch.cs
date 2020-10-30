using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Witch : MonoBehaviour
{
    public Animator animator2;

    // If witch is on one end of the screen, it will move it back to an initial position. Velocity is computed
    // with random number in a range.
    public void WitchMovement()
    {
        float yVel;
        float xVel;

        if (this.transform.position.x < -12 || this.transform.position.x > 11)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            this.GetComponent<Rigidbody2D>().position = new Vector2(-10, 3);
        }
        yVel = Random.Range(-2, 2);
        xVel = Random.Range(2, 6);
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);

    }

    // When witch collider is detected and mouse is clicked, 5 points is added.
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Score.totalScore += 5;
            this.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<ParticleSystem>().Emit(25);
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(10, -20);
            //Destroy(gameObject);
        }


    }
}