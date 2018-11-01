using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fada : Efeito {
	private bool instanciado = false;
	private GameObject instancia;
	float tempoTotal = 5;
	float tempoAtual = 5;

	public override void Update () {
		if (!instanciado) {
			instancia = Instantiate(Resources.Load<GameObject>("Efeitos/Fada"));
			instanciado = true;
		}

		tempoAtual -= Time.deltaTime;

		if (tempoAtual <= 0) {
			tempoAtual = tempoTotal;
			PlayerManager.instance.GetComponent<PlayerStatus> ().Vida += 10;
		}

		if (id != PlayerManager.instance.GetComponent<Inventario> ().Artefato) {
			if (instancia != null)
				Destroy (instancia);
			Destroy (this);
		}
	}
}
