using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InventarioUI : MonoBehaviour {

	public GameObject itemSlot;
	public Image armadura;
	public Image arma;

	private Inventario player;
	private ScrollRect scrollRect;

	void Start () {
		Itens.CarregarItens ();
		player = PlayerManager.instance.GetComponent<Inventario>();
		scrollRect = GetComponent<ScrollRect> ();
		AtualizarInventario ();
	}
	
	public void AtualizarInventario(){
		if (player.Arma != -1) {
			arma.sprite = Itens.item [player.Arma].Imagem;
			arma.color = Color.white;
		}

		if (player.Armadura != -1) {
			armadura.sprite = Itens.item [player.Armadura].Imagem;
			armadura.color = Color.white;
		}

		for (int cnt = 0; cnt < scrollRect.content.transform.childCount; cnt++) {
			Destroy(scrollRect.content.transform.GetChild (cnt).gameObject);
		}

		foreach(int idDoItem in player.Itens){
			Item item = Itens.item [idDoItem];
			GameObject novoItem = Instantiate (itemSlot, Vector3.zero, Quaternion.identity);
			novoItem.name = "Item do Inventario";
			Image imagem = novoItem.transform.GetChild(0).GetComponent<Image> ();
			Text texto = novoItem.transform.GetChild (1).GetComponent<Text> ();
			RectTransform rect = novoItem.GetComponent<RectTransform> ();

			novoItem.GetComponent<ItemUI> ().id = idDoItem;
			imagem.sprite = item.Imagem;
			texto.text = item.Nome;

			novoItem.transform.SetParent (scrollRect.content);
		} 
	}
}
