using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrasaoDeArdhas : Efeito {

	private Light luz;

	public override void Update() {
		if(PlayerManager.instance.GetComponent<PlayerStatus> ().Imunidade != EnumElementos.Gelo)
			PlayerManager.instance.GetComponent<PlayerStatus> ().Imunidade = EnumElementos.Gelo;

		if (luz == null) {
			luz = gameObject.AddComponent<Light> ();
			luz.range = 2.5f;
			luz.color = new Color32 (238, 238, 255, 255);
			luz.intensity = 2;
		}

		if (id != PlayerManager.instance.GetComponent<Inventario> ().Artefato) {
			PlayerManager.instance.GetComponent<PlayerStatus> ().Imunidade = EnumElementos.Comum;
			Destroy (luz);
			Destroy (this);
		}
	}
}
