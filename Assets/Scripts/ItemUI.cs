using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemUI : MonoBehaviour, IPointerEnterHandler,  IPointerExitHandler{
	public int id;
	public GameObject itemInterativo;
	public GameObject info;

	public void Interagir(){
		EnumTipoItem tipo = Itens.item [id].Tipo;
		switch(tipo){
		case EnumTipoItem.Armadura:
			PlayerManager.instance.GetComponent<Inventario> ().Armadura = id;
			break;
		case EnumTipoItem.Arma:
			PlayerManager.instance.GetComponent<Inventario> ().Arma = id;
			break;
		case EnumTipoItem.Consumivel:
			if(Itens.item [id].Cura != 0)
				PlayerManager.instance.GetComponent<PlayerStatus> ().Vida += Itens.item [id].Cura;
			if(Itens.item [id].Mana != 0)
				PlayerManager.instance.GetComponent<PlayerStatus> ().Mana += Itens.item [id].Mana;
			
			PlayerManager.instance.GetComponent<Inventario> ().Bolsa.Remove (id);
			break;
		case EnumTipoItem.Artefato:
			PlayerManager.instance.GetComponent<Inventario> ().Artefato = id;
			System.Type type = Itens.item [id].Efeito.GetType ();
			Component comp = PlayerManager.instance.GetComponent<Inventario> ().artefatoGO.AddComponent (type);
			((Efeito)comp).id = id;
			break;
		}
		if(info != null)
			info.SetActive (false);
		PlayerManager.instance.GetComponent<InterfaceManager> ().inventarioUI.AtualizarInventario ();
	}

	public void DesequiparItem(int tipo){
		switch(tipo){
		case 1:
			PlayerManager.instance.GetComponent<Inventario> ().Arma = -1;
			break;
		case 2:
			PlayerManager.instance.GetComponent<Inventario> ().Armadura = -1;
			break;
		case 3:
			PlayerManager.instance.GetComponent<Inventario> ().Artefato = -1;
			break;
		}
		PlayerManager.instance.GetComponent<InterfaceManager> ().inventarioUI.AtualizarInventario ();
	}

	public void RemoverItem(){
		itemInterativo.GetComponent<ItemInterativel> ().IDDoItem = id;

		PlayerManager.instance.GetComponent<Inventario> ().Bolsa.Remove (id);
		PlayerManager.instance.GetComponent<InterfaceManager> ().inventarioUI.AtualizarInventario ();
		Vector3 posicao = new Vector3 (PlayerManager.instance.transform.position.x+4, PlayerManager.instance.transform.position.y, PlayerManager.instance.transform.position.z);
		Instantiate (itemInterativo, posicao, Quaternion.identity);
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		if (info != null) {
			Text infoText = info.GetComponentInChildren<Text> ();
			string texto = Itens.item[id].Nome+"\n";

			if(Itens.item[id].Ataque != 0){
				texto += "\nAtaque: " + Itens.item [id].Ataque;
			}
			if(Itens.item[id].Defesa != 0){
				texto += "\nDefesa: " + Itens.item [id].Defesa;
			}
			if(Itens.item[id].Descricao != ""){
				texto += "\n" + Itens.item [id].Descricao;
			}
			if(Itens.item[id].Valor != 0)
				texto += "\nValor: " + Itens.item [id].Valor;
			infoText.text = texto;
			info.SetActive (true);

		}
	}
	public void OnPointerExit(PointerEventData eventData)
	{
		if(info != null)
			info.SetActive (false);
	}
}
