﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeContact : MonoBehaviour {


	public Collider2D col;
	public float attackLife;

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("Hit detected melee");
		if (other.tag == "Enemy") {
			DestroyObject(other.gameObject);
			col.enabled = false;
			Debug.Log ("Hit went through");		
		}

	}

	public IEnumerator attackLifeTime(){
		Debug.Log ("is checking lifetime");
		yield return new WaitForSeconds (attackLife);
		if (col.enabled){ col.enabled = false; Debug.Log ("life time expired"); }
		StopCoroutine ("attackLifeTime");
	}
}