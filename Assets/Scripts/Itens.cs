using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Itens{

	public static Item[] item = new Item[4];

	public static void CarregarItens(){
		item [0] = new Item ("Cajado de Madeira", "", EnumTipoItem.Arma, 10, 1, 0, 3, Resources.Load<Sprite>("ItemIcons/Staff"), Resources.Load<Mesh>("ItemModels/cajado_de_madeira"), 0, 0);
		item [1] = new Item ("Sobretudo de Mago", "", EnumTipoItem.Armadura, 10, 1, 10, 0, Resources.Load<Sprite>("ItemIcons/Armadura"), Resources.Load<Mesh>("ItemModels/sobretudo_de_mago"), 0, 1);
		item [2] = new Item ("Manto de Mago das Sombras", "", EnumTipoItem.Armadura, 50, 1, 15, 0, Resources.Load<Sprite>("ItemIcons/Armadura"), Resources.Load<Mesh>("ItemModels/manto_de_mago_das_sombras"), 0, 2);
		item [3] = new Item ("Cajado de Druida", "", EnumTipoItem.Arma, 50, 1, 0, 7, Resources.Load<Sprite>("ItemIcons/Staff"), Resources.Load<Mesh>("ItemModels/cajado_de_druida"), 0, 3);
	}

}
