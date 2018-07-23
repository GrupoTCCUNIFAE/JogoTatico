using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InventarioUI : MonoBehaviour {

	private ScrollRect scrollRect;

	void Start () {
		Itens.CarregarItens ();
		scrollRect = GetComponent<ScrollRect> ();

		foreach(Item item in Itens.item){
			GameObject novoItem = new GameObject();
			novoItem.name = "Item do Inventario";
			Image imagem = novoItem.AddComponent<Image> ();
			imagem.sprite = item.imagem;

			novoItem.transform.SetParent (scrollRect.content);
		} 
	}
	
	void Update () {
		
	}
}
