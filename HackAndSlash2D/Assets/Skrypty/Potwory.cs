using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potwory : MonoBehaviour {
	
		public string rodzaj;
		public int życie;
		public float szansaNaKase;
		
	void Awake(){
		szansaNaKase = Random.Range (15, 100);
	}
		
}

public class Slime : Potwory {

	public Slime(){
		this.rodzaj = "Slime";
		this.życie = 10;
		this.szansaNaKase = szansaNaKase;
	}

}

public class Pelo : Potwory {

	public Pelo(){
		this.rodzaj = "Pelo";
		this.życie = 15;
		this.szansaNaKase = szansaNaKase;
	}

}
