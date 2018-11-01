using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CranioDeNosferus : Efeito {

	private float manaAnterior;
	private Light luz;

	public override void Update () {
		if (manaAnterior > PlayerManager.instance.GetComponent<PlayerStatus> ().Mana) {
			PlayerManager.instance.GetComponent<PlayerStatus> ().Vida -= manaAnterior - PlayerManager.instance.GetComponent<PlayerStatus> ().Mana;
			PlayerManager.instance.GetComponent<PlayerStatus> ().Mana += manaAnterior - PlayerManager.instance.GetComponent<PlayerStatus> ().Mana;
		}

		if (luz == null) {
			luz = gameObject.AddComponent<Light> ();
			luz.range = 3;
			luz.color = new Color32 (255, 0, 0, 0);
			luz.intensity = 2;
		}

		manaAnterior = PlayerManager.instance.GetComponent<PlayerStatus> ().Mana;

		if (id != PlayerManager.instance.GetComponent<Inventario> ().Artefato) {
			Destroy (luz);
			Destroy (this);
		}
	}
}
