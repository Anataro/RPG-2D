using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	private GameObject gracz;
	public float reachDist = 1f;
	public float speed = 1f; 

	void Start(){
		gracz = GameObject.FindGameObjectWithTag ("Player");

		Physics2D.IgnoreCollision (GameObject.FindGameObjectWithTag ("Ściana").GetComponent<Collider2D> (), GetComponent<Collider2D> ());
	}

	void Update(){

		transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0f);
			
		float distance = Vector3.Distance (gracz.transform.position, transform.position);

		if (distance > reachDist) {
			transform.position = Vector3.MoveTowards (transform.position, gracz.transform.position, speed * Time.deltaTime);
		}
	}

	void OnCollisionEnter2D (Collision2D other){
		if (other.gameObject.tag == "Broń") {
			Destroy (gameObject);
		}
	}
}

