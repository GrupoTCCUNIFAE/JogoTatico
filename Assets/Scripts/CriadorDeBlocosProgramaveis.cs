using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriadorDeBlocosProgramaveis : MonoBehaviour {

	private GameObject blocoVazio;

	// Use this for initialization
	void Start () {
		blocoVazio = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.childCount > 0) {
			GameObject novoBloco = Instantiate (blocoVazio, Vector3.zero, Quaternion.identity);
			novoBloco.transform.DetachChildren ();
			novoBloco.transform.SetParent (transform.parent);
			gameObject.GetComponent<CriadorDeBlocosProgramaveis> ().enabled = false;
		}
	}
}
