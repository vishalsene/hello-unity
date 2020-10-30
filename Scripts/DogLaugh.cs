using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogLaugh : MonoBehaviour
{

    public Animator animator3;
    public GameObject dogLaugh;
	private Vector2 position;

	// Start is called before the first frame update
	void Start()
    {
        // Initial position of object
        dogLaugh.transform.position = new Vector2(-1, -4);
    }



	public void animateDogLaugh()
	{

        // Not done implementing.
        if (this.transform.position.y < -1.5)
        {
            dogLaugh.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 3);

            if (this.transform.position.y > 7)
            {
                dogLaugh.transform.position = new Vector2(-1, -4);

            }

        }


    }
}
