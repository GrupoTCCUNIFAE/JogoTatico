using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InventarioUI : MonoBehaviour {

	public GameObject itemSlot;
	public GameObject info;
	public Image armadura;
	public Image arma;

	private Inventario player;
	private ScrollRect scrollRect;
	private Sprite armaDesequipada;
	private Sprite armaduraDesequipada;

	void Start () {
		armaDesequipada = arma.sprite;
		armaduraDesequipada = armadura.sprite;
		Itens.CarregarItens ();
		player = PlayerManager.instance.GetComponent<Inventario>();
		scrollRect = GetComponent<ScrollRect> ();
		AtualizarInventario ();
		transform.parent.parent.gameObject.SetActive (false);
	}

	void Update(){
		RotacionarPlayer ();
	}

	private void RotacionarPlayer(){
		PlayerManager.instance.transform.Rotate (new Vector3 (0,1,0));
	}

	public void AtualizarInventario(){
		if (player.Arma != -1) {
			arma.sprite = Itens.item [player.Arma].Imagem;
			arma.color = Color.white;
		} else {
			arma.sprite = armaDesequipada;
			arma.color = new Color32 (0, 0, 0, 65);
		}

		if (player.Armadura != -1) {
			armadura.sprite = Itens.item [player.Armadura].Imagem;
			armadura.color = Color.white;
		} else {
			armadura.sprite = armaduraDesequipada;
			armadura.color = new Color32 (0, 0, 0, 65);
		}

		for (int cnt = 0; cnt < scrollRect.content.transform.childCount; cnt++) {
			Destroy(scrollRect.content.transform.GetChild (cnt).gameObject);
		}

		foreach(int idDoItem in player.Bolsa){
			Item item = Itens.item [idDoItem];
			GameObject novoItem = Instantiate (itemSlot, Vector3.zero, Quaternion.identity);
			novoItem.name = "Item do Inventario";
			Image imagem = novoItem.transform.GetComponent<Image> ();
			Text texto = novoItem.transform.GetChild (0).GetComponent<Text> ();
			RectTransform rect = novoItem.GetComponent<RectTransform> ();

			novoItem.GetComponent<ItemUI> ().id = idDoItem;
			novoItem.GetComponent<ItemUI> ().info = info;
			imagem.sprite = item.Imagem;
			texto.text = item.Nome;

			novoItem.transform.SetParent (scrollRect.content);
		} 
	}
}
