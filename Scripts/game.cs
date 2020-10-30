using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    public PumpkinMovement Pumpkin;
    public PumpkinMovement Pumpkin2;
    public DogLaugh dogLaugh;

    // Update is called once per frame
    public static float timer = 0f;
    void Update()
    {
        // Records time in game.
        timer += Time.deltaTime;
        print(timer);

        // If Key Pressed Variant Mode activated for 3 seconds. (Not done implementing)
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
        }

      
    }
 
}