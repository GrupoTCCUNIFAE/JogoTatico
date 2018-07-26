using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInterativel : MonoBehaviour {

	public int IDDoItem;

	void OnTriggerEnter (Collider col) {
		InventarioUI inventarioUi = PlayerManager.instance.GetComponent<InterfaceManager> ().inventarioUI;

		if(col.tag == "Player"){
			if (PlayerManager.instance.GetComponent<Inventario> ().AdicionarItem(IDDoItem)) {
				inventarioUi.AtualizarInventario ();
				Destroy (gameObject);
			}
		}
	}
}
