using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInterativel : MonoBehaviour {

	public int IDDoItem;
	public EnumTipoInterativel tipo;

	private GameObject nomeGameObj;
	private TextMesh nomeTxtMesh;

	void Start(){
		nomeGameObj = transform.GetChild (0).gameObject;
		nomeTxtMesh = nomeGameObj.GetComponent<TextMesh> ();
		Itens.CarregarCards ();
		switch (tipo) {
		case EnumTipoInterativel.Item:
			nomeTxtMesh.text = Itens.item [IDDoItem].Nome;
			break;
		case EnumTipoInterativel.Card:
			nomeTxtMesh.text = "Card: "+Itens.card [IDDoItem].Nome;
			break;
		}
	}

	void OnTriggerEnter (Collider col) {
		InventarioUI inventarioUi = PlayerManager.instance.GetComponent<InterfaceManager> ().inventarioUI;

		if(col.tag == "Player"){
			switch(tipo){
			case EnumTipoInterativel.Item:
				if (PlayerManager.instance.GetComponent<Inventario> ().AdicionarItem (IDDoItem)) {
					inventarioUi.AtualizarInventario ();
					Destroy (gameObject);
				}
				break;
			case EnumTipoInterativel.Card:
				if (PlayerManager.instance.GetComponent<Inventario> ().AdicionarCard (IDDoItem)) {
					Destroy (gameObject);
				}
				break;
			}
		}
	}
}

public enum EnumTipoInterativel{
	Item,
	Card
}
