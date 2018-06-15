using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {

	public string cena;

	void OnTriggerEnter (Collider col) {
		if (col.tag == "Player") {
			SceneManager.LoadScene (cena);
		}
	}
}
