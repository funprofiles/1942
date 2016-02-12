using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GObject : MonoBehaviour {

    protected Vector3 direction;
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public virtual void Update () {
        transform.position += direction * speed * Time.deltaTime;
	
	}
}
