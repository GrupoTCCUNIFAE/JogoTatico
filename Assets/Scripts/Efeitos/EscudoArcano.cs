using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscudoArcano : Efeito {

	private float vidaAnterior;
	private Light luz;

	public override void Update () {
		if (vidaAnterior > PlayerManager.instance.GetComponent<PlayerStatus> ().Vida && PlayerManager.instance.GetComponent<PlayerStatus> ().Mana > 0) {
			PlayerManager.instance.GetComponent<PlayerStatus> ().Mana -= vidaAnterior - PlayerManager.instance.GetComponent<PlayerStatus> ().Vida;
			PlayerManager.instance.GetComponent<PlayerStatus> ().Vida += vidaAnterior - PlayerManager.instance.GetComponent<PlayerStatus> ().Vida;
		}

		if (luz == null) {
			luz = gameObject.AddComponent<Light> ();
			luz.range = 3;
			luz.color = new Color32 (0, 255, 255, 255);
			luz.intensity = 2;
		}

		vidaAnterior = PlayerManager.instance.GetComponent<PlayerStatus> ().Vida;

		if (id != PlayerManager.instance.GetComponent<Inventario> ().Artefato) {
			Destroy (luz);
			Destroy (this);
		}
	}
}
