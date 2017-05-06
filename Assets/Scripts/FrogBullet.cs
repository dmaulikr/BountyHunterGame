using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogBullet : MonoBehaviour {

	public Transform target;
	private Vector2 direction;
	private Vector2 forward;
	private float speed = 10.0f;
	private float lifetime = 1.0f;
	private int damage = 10;


	// Use this for initialization
	void Start () {
		Destroy(gameObject, lifetime);
		target = GameObject.FindWithTag("Player").GetComponent<Transform>();
		direction = target.position;
		forward = target.forward;
	}

	// Update is called once per frame
	void Update () {
		//transform.Translate(forward * Time.deltaTime * speed, Space.Self);
		transform.position = Vector2.MoveTowards(transform.position, direction, speed * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			col.gameObject.GetComponent<PlayerHealthManager> ().HurtPlayer (damage);
		}
		Destroy(gameObject);
	}
}
