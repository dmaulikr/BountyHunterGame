using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	#region Member Variables
	/// <summary>
	/// Player movement speed
	/// </summary>
	private float movementSpeed = 3.0f;

	/// <summary>
	/// Animation state machine local reference
	/// </summary>
	private Animator animator;

	/// <summary>
	/// The last position of the player in previous frame
	/// </summary>
	private Vector3 lastPosition;

	/// <summary>
	/// The last checkpoint position that we have saved
	/// </summary>
	private Vector3 CheckPointPosition;

	/// <summary>
	/// Is the player dead?
	/// </summary>
	private bool isDead = false;

    /// <summary>
	/// Player rigidbody
	/// </summary>
	private Rigidbody2D rbody;
    #endregion

    // Use this for initialization
    void Start ()
	{
		// get the local reference
		animator = GetComponent<Animator>();

        // get the rigidbody
        rbody = GetComponent<Rigidbody2D>();

		// set initial position
		lastPosition = transform.position;
		CheckPointPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
        // get the input this frame
        Vector2 movement_vector = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);

		// if there is no input then stop the animation
		if((movement_vector.x == 0.0f) && (movement_vector.y == 0.0f))
		{
			animator.speed = 0.0f;
		}

		// horizontal movement, left or right, set animation type and speed 
		if (movement_vector.x > 0)
		{
			animator.SetInteger("Direction", 1);
			animator.speed = 0.5f;
		}
		else if (movement_vector.x < 0)
		{
			animator.SetInteger("Direction", 3);
			animator.speed = 0.5f;
		}

		// vertical movement, up or down, set animation type and speed 
		if (movement_vector.y > 0)
		{
			animator.SetInteger("Direction", 0);
			animator.speed = 0.35f;
		}
		else if (movement_vector.y < 0)
		{
			animator.SetInteger("Direction", 2);
			animator.speed = 0.35f;
		}

        transform.Translate(movement_vector * movementSpeed * Time.deltaTime);

        //compare this position to the last known one, are we moving?
        if (this.transform.position == lastPosition || isDead)
		{
			// we aren't moving so make sure we dont animate
			animator.speed = 0.0f;
		}

		// get the last known position
		lastPosition = transform.position;
	}
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.tag == "DangerousTile")
		{
			GameObject.Find("FadePanel").GetComponent<FadeScript>().RespawnFade();
			isDead = true;
		}
		else if(collider.gameObject.tag == "LevelChanger")
		{
			GameObject.Find("FadePanel").GetComponent<FadeScript>().FadeOut();
			isDead = true;
		}
	}

	/// <summary>
	/// Respawns the player at checkpoint.
	/// </summary>
	public void RespawnPlayerAtCheckpoint()
	{
		// if we hit a dangerous tile then we are dead so go to the checkpoint position that was last saved
		transform.position = CheckPointPosition;
		isDead = false;
	}

}
