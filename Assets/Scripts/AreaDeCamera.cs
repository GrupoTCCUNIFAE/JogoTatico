using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDeCamera : MonoBehaviour {

	public Vector3 posicao;
	public Vector3 tamanho;
	public Color cor;

	private bool playerEntrou = false;

	void Start () {
		BoxCollider collider = gameObject.GetComponent<BoxCollider> ();
		collider.size = tamanho;
		collider.center = posicao;
	}
	
	void Update () {
		
	}

	void OnDrawGizmos(){
		Gizmos.color = cor;
		Gizmos.DrawWireCube (posicao+transform.position, tamanho);
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Player")
			playerEntrou = true;
	}

	void OnTriggerExit(Collider col){
		if (col.tag == "Player")
			playerEntrou = false;
	}

	public bool playerDentro{
		get{return playerEntrou;}
	}
}
