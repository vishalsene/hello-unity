using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static double totalScore = 0;
    private Text scoreText;

    // Start is called before the first frame update
    // Assigns Text to variable.
    void Start()
    {
        scoreText = gameObject.GetComponent<Text>();

    }

    // Update is called once per frame
    // Sets message with the total score count.
    void Update()
    {
        scoreText.text = "Score: " + totalScore;
    }
}
