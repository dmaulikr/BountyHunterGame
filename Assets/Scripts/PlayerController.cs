using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float health;
    public float damage;
    public float defense;
    public float speed;
	public GameObject arrow;
	private float fireRate = 0.1f;
	private float nextFire = 0;
	public static int direction = 1;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			direction = 0;
		}
		if (Input.GetKey (KeyCode.S)|| Input.GetKey (KeyCode.DownArrow)) {
			direction = 1;
		}
		if (Input.GetKey (KeyCode.A)|| Input.GetKey (KeyCode.LeftArrow)) {
			direction = 2;
		}
		if (Input.GetKey (KeyCode.D)|| Input.GetKey (KeyCode.RightArrow)) {
			direction = 3;
		}
		if (Input.GetKey(KeyCode.Return) && Time.time > nextFire){
			nextFire = Time.time + fireRate;
			Instantiate (arrow, transform.position, transform.rotation);
		}
	}
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "apple")
        {
            PlayerHealthManager.SetMaxHealth();
            Destroy(collision.gameObject);
        }
    }
}
