using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueFisico : MonoBehaviour {

	ControladorGeral status;

	void Start(){
		status = GetComponent<ControladorGeral> ();
	}

	public bool Atacar(){
		ControladorGeral statusInimigo = GetStatus ();
		GetComponent<Animator> ().SetTrigger ("Ataque");

		if (statusInimigo != null) {
			statusInimigo.Vida -= status.Ataque;
			print ("Ataque");
			return true;
		}

		return false;
	}

	private ControladorGeral GetStatus(){
		RaycastHit hit;

		if (Physics.Linecast (transform.position+transform.forward, transform.position+transform.forward*3, out hit)) {
			if (hit.collider.tag == "Enemie") {
				return hit.collider.gameObject.GetComponent<ControladorGeral> ();
			}
		}

		return null;
	}
}
