using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SobeMana : Efeito{
	private float taxa = 0.08f;

	public override void Update () {
		PlayerManager.instance.GetComponent<PlayerStatus> ().Mana += taxa;
		if (id != PlayerManager.instance.GetComponent<Inventario> ().Artefato) {
			Destroy (this);
		}
	}
}
