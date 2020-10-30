using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PumpkinMovement : MonoBehaviour
{
    public DogLaugh dogLaugh2;
    public Animator animator;
    public GameOverMenu gameOver;
    public Witch WitchObj;

    float yVel;
    float xVel;
    int i = 1;

    // Pumpkins start after 11 seconds and repeates every 5 seconds.
    private void Start()
    {
       InvokeRepeating("PumpkinMove", 11f, 5f);
       WitchObj.InvokeRepeating("WitchMovement", 11f, 5f);

    }

    // Update is called once per frame
    void Update()
    {
        // After click score deduct 1 point. (0.5 for both pumpkins)
        if (Input.GetMouseButtonDown(0) && game.timer > 10)
        {
            Score.totalScore -= 0.5;
            //callDogLaugh();
        }


        // After set of 30 seconds, if 5 targets are shot, level increases.
        if(Targets.targetsLeft <= 0 && game.timer < 30 * i)
        {
            i++;
            Targets.targetsLeft = 5;
            Level.level++;
        }

        // If targets are not shot in time, gameover scene is loaded.
  /*      if (Targets.targetsLeft >= 0 && game.timer > 30 * i)
        {
            CancelInvoke();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }*/

    }

    // Pumpkins are positiones behind the ground and shot up with different velocties and some torque/
    // If pumkins are on the sides of the screen, the should have higher chance of shooting accross than
    // out of the screen. IsShot is also set to false to get unbrocken pumpkin animation.
    public void PumpkinMove()
    {
        float xPos = Random.Range(-7, 7);

        animator.SetBool("IsShot", false);

        yVel = Random.Range(7 + i, 12 + i);

        if (xPos < -3)
            xVel = Random.Range(0 - i, 2 + i);
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);

        if (xPos > 3)
            xVel = Random.Range(-2 - i, 0 + i);
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);

        this.transform.position = new Vector3(xPos, -5);
        this.GetComponent<Rigidbody2D>().AddTorque(3);
    }

    // (Not implemented yet)
    void callDogLaugh()
    {
        if(Input.GetMouseButtonDown(0))
        {
            dogLaugh2.animateDogLaugh();
        }
    }
    

    // When pumpkin is shot by collider detection, points are added to score, IsShot is set to true to get
    // broken pumpkin animation and targetsLeft is decreased.
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && animator.GetBool("IsShot") == false)
        {
            Score.totalScore += 4;
            animator.SetBool("IsShot", true);
            this.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<ParticleSystem>().Emit(25);
            Targets.targetsLeft--;

        }
       
    }
}




