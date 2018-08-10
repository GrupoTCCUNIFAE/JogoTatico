using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Itens{

	public static Item[] item = new Item[9];

	public static void CarregarItens(){
		item [0] = new Item ("Cajado de Madeira", "", EnumTipoItem.Arma, 10, 1, 0, 3, Resources.Load<Sprite>("ItemIcons/cajado_de_madeira"), Resources.Load<Mesh>("ItemModels/cajado_de_madeira"), 0, 0);
		item [1] = new Item ("Sobretudo de Mago", "", EnumTipoItem.Armadura, 10, 1, 10, 0, Resources.Load<Sprite>("ItemIcons/Armadura"), Resources.Load<Mesh>("ItemModels/sobretudo_de_mago"), 0, 1);
		item [2] = new Item ("Manto de Mago das Sombras", "", EnumTipoItem.Armadura, 50, 1, 15, 0, Resources.Load<Sprite>("ItemIcons/Armadura"), Resources.Load<Mesh>("ItemModels/manto_de_mago_das_sombras"), 0, 2);
		item [3] = new Item ("Cajado de Druida", "", EnumTipoItem.Arma, 50, 1, 0, 7, Resources.Load<Sprite>("ItemIcons/cajado_de_druida"), Resources.Load<Mesh>("ItemModels/cajado_de_druida"), 0, 3);
		item [4] = new Item ("Cajado de Bataha", "", EnumTipoItem.Arma, 100, 1, 0, 15, Resources.Load<Sprite>("ItemIcons/cajado_de_batalha"), Resources.Load<Mesh>("ItemModels/cajado_de_batalha"), 0, 4);
		item [5] = new Item ("Armadura de Mago de Batalha", "", EnumTipoItem.Armadura, 10, 10, 20, 0, Resources.Load<Sprite>("ItemIcons/Armadura"), Resources.Load<Mesh>("ItemModels/armadura_de_mago_de_batalha"), 0, 5);
		item [6] = new Item ("Manto de Mago do Deserto", "", EnumTipoItem.Armadura, 10, 1, 15, 0, Resources.Load<Sprite>("ItemIcons/Armadura"), Resources.Load<Mesh>("ItemModels/manto_de_mago_do_deserto"), 0, 6);
		item [7] = new Item ("Cajado da Areia", "", EnumTipoItem.Arma, 10, 1, 0, 10, Resources.Load<Sprite>("ItemIcons/cajado_da_areia"), Resources.Load<Mesh>("ItemModels/cajado_da_areia"), 0, 7);
		item [8] = new Item ("Trapos de Mago Eremita", "", EnumTipoItem.Armadura, 0, 1, 10, 0, Resources.Load<Sprite>("ItemIcons/Armadura"), Resources.Load<Mesh>("ItemModels/trapos_de_mago_eremita"), 0, 8);
	}

}
