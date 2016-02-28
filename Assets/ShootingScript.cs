using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootingScript : MonoBehaviour {


	public GameObject bulletPrefab;



	// Use this for initialization
	void Start () {



	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("space")){

			print ("Fire");

			FireBullet();

		}

	}




	public void FireBullet(){
		
		GameObject Clone;

		Clone = (Instantiate(bulletPrefab, transform.position,transform.rotation)) as GameObject;
		Debug.Log ("Bullet is found");

		Clone.GetComponent<Rigidbody>().AddForce(0,1000,0);

		Debug.Log ("Force is added");

	}







}