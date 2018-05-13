using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostraVidaInimigo : MonoBehaviour {

	void Update () {
		GetComponentInChildren<TextMesh> ().text = "Vida: "+GetComponent<ControladorGeral> ().Vida;
	}
}
