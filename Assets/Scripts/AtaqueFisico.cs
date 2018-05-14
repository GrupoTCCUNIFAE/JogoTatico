using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueFisico : MonoBehaviour {

	Status status;

	void Start(){
		status = GetComponent<Status> ();
	}

	public bool Atacar(){
		Status statusInimigo = GetStatus ();
		GetComponent<Animator> ().SetTrigger ("Ataque");

		if (statusInimigo != null) {
			statusInimigo.Vida -= status.Ataque;
			print ("Ataque");
			return true;
		}

		return false;
	}

	private Status GetStatus(){
		RaycastHit hit;

		if (Physics.Linecast (transform.position+transform.forward, transform.position+transform.forward*3, out hit)) {
			if (hit.collider.tag == "Enemie") {
				return hit.collider.gameObject.GetComponent<Status> ();
			}
		}

		return null;
	}
}
