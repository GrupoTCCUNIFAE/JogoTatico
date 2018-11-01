using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaixaDeTardius : Efeito {

	private bool alterado = false;
	private int random;
	private Light luz;

	public override void Update () {

		if (!alterado) {
			alterado = true;
			random = Random.Range (0, 100);
		}

		if (random > 50)
			PlayerManager.instance.GetComponent<ControladorDeAcoes>().normalTime = 0.5f;
		else
			PlayerManager.instance.GetComponent<ControladorDeAcoes>().normalTime  = 1.5f;

		if (luz == null) {
			luz = gameObject.AddComponent<Light> ();
			luz.range = 3;
			luz.color = new Color32 (0, 0, 255, 255);
			luz.intensity = 2;
		}

		if (id != PlayerManager.instance.GetComponent<Inventario> ().Artefato) {
			PlayerManager.instance.GetComponent<ControladorDeAcoes>().normalTime  = 1;
			Destroy (luz);
			Destroy (this);
		}
	}
}
