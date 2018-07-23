using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInterativel : MonoBehaviour {

	public InventarioUI inventarioUi;
	public int IDDoItem; 

	void OnTriggerEnter (Collider col) {
		if(col.tag == "Player"){
			if (PlayerManager.instance.GetComponent<Inventario> ().AdicionarItem(IDDoItem)) {
				inventarioUi.AtualizarInventario ();
				Destroy (gameObject);
			}
		}
	}
}
