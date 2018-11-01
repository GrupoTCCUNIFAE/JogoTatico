using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciadorDeArtefato : MonoBehaviour {

	void Start () {
		if (PlayerManager.instance.GetComponent<Inventario> ().Artefato != -1) {
			System.Type type = Itens.item [PlayerManager.instance.GetComponent<Inventario> ().Artefato].Efeito.GetType ();
			Component comp = PlayerManager.instance.GetComponent<Inventario> ().artefatoGO.AddComponent (type);
			((Efeito)comp).id = PlayerManager.instance.GetComponent<Inventario> ().Artefato;
		}
	}

}
