using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour {

	public GameObject passagem;
	public GameObject porta;

	void Update () {
		if (ChecaCubos ()) {
			passagem.SetActive (true);
			porta.SetActive (false);
		}
	}

	private bool ChecaCubos(){
		for(int i =0;i<transform.childCount; i++){
			MeshRenderer renderer = transform.GetChild(i).GetComponent<MeshRenderer> ();
			if(renderer.enabled){
				return false;
			}
		}

		return true;
	}
}
