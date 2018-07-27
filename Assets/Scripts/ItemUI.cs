using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUI : MonoBehaviour {
	public int id;

	public void Interagir(){
		EnumTipoItem tipo = Itens.item [id].Tipo;
		switch(tipo){
		case EnumTipoItem.Armadura:
			PlayerManager.instance.GetComponent<Inventario> ().Armadura = id;
			break;
		case EnumTipoItem.Arma:
			PlayerManager.instance.GetComponent<Inventario> ().Arma = id;
			break;
		}
		PlayerManager.instance.GetComponent<InterfaceManager> ().inventarioUI.AtualizarInventario ();
	}

	public void Desequipar(bool arma){
		if (arma) {
			PlayerManager.instance.GetComponent<Inventario> ().Arma = -1;
		} else {
			PlayerManager.instance.GetComponent<Inventario> ().Armadura = -1;
		}
		PlayerManager.instance.GetComponent<InterfaceManager> ().inventarioUI.AtualizarInventario ();
	}

	public void RemoverItem(){
		PlayerManager.instance.GetComponent<Inventario> ().Itens.Remove (id);
		PlayerManager.instance.GetComponent<InterfaceManager> ().inventarioUI.AtualizarInventario ();
	}
}
