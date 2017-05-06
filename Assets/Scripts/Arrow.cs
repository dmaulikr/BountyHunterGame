using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {
	private float lifetime = 1.0f;
	private float bulletSpeed = 500.0f;
	private int damage = 10;
	private int direction;

	// Use this for initialization
	void Start () {
		direction = PlayerController.direction;
		switch (direction) {
		case 0:
			gameObject.GetComponent<Rigidbody2D> ().AddForce (transform.up * bulletSpeed);
			break;
		case 1:
			gameObject.GetComponent<Rigidbody2D> ().AddForce (-transform.up * bulletSpeed);
			break;
		case 2:
			gameObject.GetComponent<Rigidbody2D> ().AddForce (-transform.right * bulletSpeed);
			break;
		case 3:
			gameObject.GetComponent<Rigidbody2D> ().AddForce (transform.right * bulletSpeed);
			break;
		}
		Destroy(gameObject, lifetime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Enemy")
		{
			col.gameObject.GetComponent<Enemy> ().takeDamage (damage);
		}
		Destroy(gameObject);
	}
}
