using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Itens{

	public static Item[] item = new Item[2];

	public static void CarregarItens(){
		item [0] = new Item ("Cajado de Madeira", "", EnumTipoItem.Arma, 10, 1, 0, 3, Resources.Load<Sprite>("Items/Staff"), null, 0);
	}

}
