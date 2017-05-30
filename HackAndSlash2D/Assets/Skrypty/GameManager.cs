using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public GUIText licznikMonet;
	public int ilośćMonet = 0;

	Animator anim;
	public float animSpeed = 0.6f;


	void Start () {
		GameObject obiekt = GameObject.Find ("Plaża");
		anim = obiekt.GetComponent<Animator> ();
		if( anim.GetCurrentAnimatorStateInfo(0).IsName("Ocean"))
		{
			anim.speed = animSpeed;
		}
	}

	void Update () {
		licznikMonet.text = "Monety: " + ilośćMonet.ToString ();
	}
}
