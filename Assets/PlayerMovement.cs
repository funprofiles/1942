using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : GObject {
    Rigidbody2D rb;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    public override void Update()
    {
        direction = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction.x = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction.x = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction.y = -1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction.y = 1;
        }

        base.Update();
    }

   
}
