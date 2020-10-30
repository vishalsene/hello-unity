using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // Transforms camera to world space and assigns position of mouse to crosshair.
        Vector3 pos = this.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);

        var target = GameObject.Find("crosshair");
        target.transform.position = new Vector3 (pos.x, pos.y, -9);
        print(this.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition));
         
        // Turning off cursor visibility to only view crosshair.
        Cursor.visible = false;
    }
}
