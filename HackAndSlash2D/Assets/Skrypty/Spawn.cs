using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	public GameObject slime, pelo;
	public int numerFali = 1;
	public bool koniecFali;
	public int iloscPotworów, zespawnionePotwory, jakiPotwór = 1;

	public float timer, zmianaTimera = 0.1f, nowyTimer = 2f;

	void Start () {

	}

	void Update () {
		if (koniecFali == true){
			timer -= Time.deltaTime;
			if (timer <= 0f)
			{
				if (jakiPotwór == 1) {
					GameObject wróg = Instantiate (slime, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
					wróg.name = zespawnionePotwory.ToString ();
					GameObject.Find (zespawnionePotwory.ToString ()).AddComponent<Slime> ();
				}

				if (jakiPotwór == 2) {
					GameObject wróg = Instantiate (pelo, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
					wróg.name = zespawnionePotwory.ToString ();
					GameObject.Find (zespawnionePotwory.ToString ()).AddComponent<Pelo> ();
				}
					zespawnionePotwory++;
					timer = nowyTimer;
					jakiPotwór = Random.Range (1, 3);
			}
		}

		if (zespawnionePotwory == numerFali * 10) {
			koniecFali = false;
			numerFali++;
			zespawnionePotwory = 0;
			nowyTimer = timer - zmianaTimera;
		}

		iloscPotworów = GameObject.FindGameObjectsWithTag ("Potwór").Length;

		if (iloscPotworów == 0 && zespawnionePotwory == 0)
			koniecFali = true;

	}
}



