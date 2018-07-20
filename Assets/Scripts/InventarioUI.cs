using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioUI : MonoBehaviour {

	public GameObject itemSlot;
	public Inventario player;

	private ScrollRect scrollRect;

	void Start () {
		Itens.CarregarItens ();
		scrollRect = GetComponent<ScrollRect> ();
		AtualizarInventario ();
	}
	
	void Update () {
		
	}

	private void AtualizarInventario(){
		for (int cnt = 0; cnt < scrollRect.content.transform.childCount; cnt++) {
			Destroy(scrollRect.content.transform.GetChild (cnt));
		}

		foreach(int idDoItem in player.Itens){
			Item item = Itens.item [idDoItem];
			GameObject novoItem = Instantiate (itemSlot, Vector3.zero, Quaternion.identity);
			novoItem.name = "Item do Inventario";
			Image imagem = novoItem.transform.GetChild(0).GetComponent<Image> ();
			Text texto = novoItem.transform.GetChild (1).GetComponent<Text> ();
			RectTransform rect = novoItem.GetComponent<RectTransform> ();

			imagem.sprite = item.imagem;
			texto.text = item.nome;

			novoItem.transform.SetParent (scrollRect.content);
		} 
	}
}
