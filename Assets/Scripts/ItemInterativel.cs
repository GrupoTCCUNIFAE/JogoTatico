using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInterativel : MonoBehaviour {

	public int IDDoItem;

	private GameObject nomeGameObj;
	private TextMesh nomeTxtMesh;

	void Start(){
		nomeGameObj = transform.GetChild (0).gameObject;
		nomeTxtMesh = nomeGameObj.GetComponent<TextMesh> ();

		nomeTxtMesh.text = Itens.item [IDDoItem].Nome;
	}

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
