using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoDestrutivelDeTeste : MonoBehaviour {

	public float tempoDeRespawn;

	private float tempoAtual = 0;

	void Update(){
		if(!GetComponent<MeshRenderer> ().enabled)
			tempoAtual += Time.deltaTime;

		if (tempoAtual >= tempoDeRespawn) {
			tempoAtual = 0;
			GetComponent<MeshRenderer> ().enabled = true;
		}
	}

	void OnTriggerEnter(Collider coll){
		if (coll.tag == "Spell") {
			GetComponent<MeshRenderer> ().enabled = false;
		}
	}
}
