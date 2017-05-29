using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	public Transform potwór;
	public int numerFali = 1;
	public bool koniecFali;
	public int iloscPotworów, zespawnionePotwory;

	public float timer, zmianaTimera = 0.1f, nowyTimer = 2f;

	void Start () {
		
	}

	void Update () {
		if (koniecFali == true){
			timer -= Time.deltaTime;
			if (timer <= 0f)
			{
				Instantiate (potwór, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
				zespawnionePotwory++;
				timer = nowyTimer;
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



