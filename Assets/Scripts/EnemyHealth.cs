using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public int health;
	Enemy parent;

	// Use this for initialization
	void Start () {
		parent = transform.parent.GetComponent<Enemy>();
		health = parent.health;
	}

	public void updateHealth (){
		health = parent.health;
		Vector3 newPosition = transform.position;
		newPosition.x -= 0.05F;
		transform.position = newPosition;
		transform.localScale += new Vector3(-0.1F, 0, 0);
	}

	public void updateHealthDamage (){
		health = parent.health;
		Debug.Log ("Health" + health);
		Vector3 newPosition = transform.position;
		newPosition.x -= 0.03F;
		transform.position = newPosition;
		transform.localScale += new Vector3(-0.36F, 0, 0);
	}
}

