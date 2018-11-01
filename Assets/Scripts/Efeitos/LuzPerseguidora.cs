using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzPerseguidora : Efeito{
	private bool instanciado = false;
	private GameObject instancia;

	public override void Update () {
		if (!instanciado) {
			instancia = Instantiate(Resources.Load<GameObject>("Efeitos/FogoFatuo"));
			instanciado = true;
		}

		if (id != PlayerManager.instance.GetComponent<Inventario> ().Artefato) {
			if (instancia != null)
				Destroy (instancia);
			Destroy (this);
		}
	}
}
