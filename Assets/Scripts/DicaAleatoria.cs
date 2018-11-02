using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DicaAleatoria : MonoBehaviour {

	public Text desc;
	public Image imagem;
	int item;

	void Start () {
		Itens.CarregarItens ();
		item = Random.Range (0, Itens.item.Length-1);

		while (Itens.item [item].Tipo != EnumTipoItem.Artefato) {
			item = Random.Range (0, Itens.item.Length-1);
		}

		desc.text = Itens.item [item].Nome+"\n\n"+Itens.item [item].Descricao;
		imagem.sprite = Itens.item [item].Imagem;

	}
}
