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
	}
}
