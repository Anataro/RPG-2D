using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed;
	private GameManager gameManagerSkrypt;
	private Rigidbody2D rb;
	private Vector2 movement;
	public Vector2 speed = new Vector2(5, 5);

	//private Animator anim;

	void Start () {
		//anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D>();

		GameObject obiekt = GameObject.Find ("GameManager");
		gameManagerSkrypt = obiekt.GetComponent<GameManager> ();

		Physics2D.IgnoreCollision (GameObject.FindGameObjectWithTag ("Broń").GetComponent<Collider2D> (), GetComponent<Collider2D> ());
	}

	void Update () {

		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);

		/*if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < 0.5f){
			transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
		}

		if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < 0.5f){
			transform.Translate (new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
		}*/

		/*anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
		anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));*/
	}

	void FixedUpdate(){
		transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0.0f);
		rb.velocity = movement;

	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Moneta") {
			gameManagerSkrypt.ilośćMonet++;
			Destroy (other.gameObject);
		}
	}
}
