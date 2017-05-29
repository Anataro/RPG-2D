using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public GameObject gracz;
	public float reachDist = 0.1f;
	public float speed; 

	void Start(){
		gracz = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update(){
		
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

