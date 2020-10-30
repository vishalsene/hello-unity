using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public static double level = 1;
    private Text Levels;

    // Start is called before the first frame update
    // Assigns Text to Levels variable.
    void Start()
    {
        Levels = gameObject.GetComponent<Text>();

    }

    // Update is called once per frame
    // Prints message with level number when condition is met.
    void Update()
    {
        Levels.text = "Level: " + level;

    }
}
