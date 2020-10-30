using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Targets : MonoBehaviour
{

    public static double targetsLeft = 5;
    private Text targets_Left;

    // Start is called before the first frame update
    // Sets text to variable.
    void Start()
    {
        targets_Left = gameObject.GetComponent<Text>();

    }

    // Update is called once per frame
    // Prints message with amount of targets left.
    void Update()
    {
        targets_Left.text = "Targets Left: " + targetsLeft;

    }
}
