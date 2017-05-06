using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private int damage = 10;
	public int health = 100;
	private float range;
	private float minDistance = 10.0f;
	public GameObject bullet;
	private float fireRate = 1.0f;
	private float nextFire = 0;
	public static int direction = 1;
	public Transform target;
	private float speed = 1.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		range = Vector2.Distance(transform.position, target.position);
		if (Time.time > nextFire && range < minDistance){
			nextFire = Time.time + fireRate;
			Debug.Log ("bullet");
			Instantiate(bullet, transform.position, transform.rotation);
		}
	}

	public void takeDamage(int damage)
	{
		health -= damage;
		Debug.Log (health);
		GameObject.Find("lb").GetComponent<EnemyHealth>().updateHealthDamage();
		if (health <= 0) {
			Destroy(gameObject);
		}
	}
}
