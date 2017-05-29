using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public GUIText licznikMonet;
	public int ilośćMonet = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		licznikMonet.text = "Monety: " + ilośćMonet.ToString ();
	}
}
