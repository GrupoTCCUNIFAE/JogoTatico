using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevelaFraquesa : MonoBehaviour {

	public float tempo;

	private TextMesh texto;
	private SpriteRenderer sprite;
	private float tempoAtual = 0;

	void Start () {
		texto = GetComponentsInChildren<TextMesh> ()[0];
		sprite = GetComponentsInChildren<SpriteRenderer> () [0];
		sprite.enabled = false;
	}

	void Update(){
		texto.gameObject.transform.LookAt (Camera.allCameras[0].transform);
		sprite.gameObject.transform.LookAt (Camera.allCameras[0].transform);

		if (tempoAtual > 0)
			tempoAtual -= Time.deltaTime;

		if (tempoAtual <= 0) {
			texto.text = "";
			sprite.enabled = false;
		}
	}

	void OnTriggerEnter (Collider col) {	
		if (col.tag == "Mob") {
			sprite.enabled = true;
			string textoMontado = col.gameObject.GetComponent<ControladorGeral> ().nome+"\n";
			foreach (EnumElementos fraqueza in col.gameObject.GetComponent<ControladorGeral> ().Fraquezas) {
				textoMontado += "- "+fraqueza + "\n";
			}
			texto.text = textoMontado;

			tempoAtual = tempo;
		}
	}
}
