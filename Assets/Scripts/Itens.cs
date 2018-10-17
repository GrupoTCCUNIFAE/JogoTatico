using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Itens{

	public static Item[] item = new Item[14];
	public static Magia[] magia = new Magia[3];
	public static Card[] card = new Card[6];

	public static void CarregarItens(){
		item [0] = new Item ("Cajado de Madeira", "", EnumTipoItem.Arma, 10, 1, 0, 3,  Resources.LoadAll<Sprite>("ItemIcons")[4], Resources.Load<Mesh>("ItemModels/cajado_de_madeira"), 0, 0, 0);
		item [1] = new Item ("Sobretudo de Mago", "", EnumTipoItem.Armadura, 10, 1, 10, 0,  Resources.LoadAll<Sprite>("ItemIcons")[5], Resources.Load<Mesh>("ItemModels/sobretudo_de_mago"), 0, 1, 0);
		item [2] = new Item ("Manto de Mago das Sombras", "", EnumTipoItem.Armadura, 50, 1, 15, 0,  Resources.LoadAll<Sprite>("ItemIcons")[5], Resources.Load<Mesh>("ItemModels/manto_de_mago_das_sombras"), 0, 2, 0);
		item [3] = new Item ("Cajado de Druida", "", EnumTipoItem.Arma, 50, 1, 0, 7, Resources.Load<Sprite>("ItemIcons/cajado_de_druida"), Resources.Load<Mesh>("ItemModels/cajado_de_druida"), 0, 3, 0);
		item [4] = new Item ("Cajado de Bataha", "", EnumTipoItem.Arma, 100, 1, 0, 15,  Resources.LoadAll<Sprite>("ItemIcons")[4], Resources.Load<Mesh>("ItemModels/cajado_de_batalha"), 0, 4, 0);
		item [5] = new Item ("Armadura de Mago de Batalha", "", EnumTipoItem.Armadura, 10, 10, 20, 0,  Resources.LoadAll<Sprite>("ItemIcons")[5], Resources.Load<Mesh>("ItemModels/armadura_de_mago_de_batalha"), 0, 5, 0);
		item [6] = new Item ("Manto de Mago do Deserto", "", EnumTipoItem.Armadura, 10, 1, 15, 0,  Resources.LoadAll<Sprite>("ItemIcons")[5], Resources.Load<Mesh>("ItemModels/manto_de_mago_do_deserto"), 0, 6, 0);
		item [7] = new Item ("Cajado da Areia", "", EnumTipoItem.Arma, 10, 1, 0, 10,  Resources.LoadAll<Sprite>("ItemIcons")[4], Resources.Load<Mesh>("ItemModels/cajado_da_areia"), 0, 7, 0);
		item [8] = new Item ("Trapos de Mago Eremita", "", EnumTipoItem.Armadura, 0, 1, 10, 0,  Resources.LoadAll<Sprite>("ItemIcons")[5], Resources.Load<Mesh>("ItemModels/trapos_de_mago_eremita"), 0, 8, 0);
		item [9] = new Item ("Elixir de Vitalidade (Pequeno)", "", EnumTipoItem.Consumivel, 8, 3, 0, 0, Resources.LoadAll<Sprite>("ItemIcons")[6], Resources.Load<Mesh>("ItemModels/trapos_de_mago_eremita"), 10, 10, 0);
		item [10] = new Item ("Elixir de Vitalidade (Grande)", "", EnumTipoItem.Consumivel, 19, 1, 0, 0, Resources.LoadAll<Sprite>("ItemIcons")[6], Resources.Load<Mesh>("ItemModels/trapos_de_mago_eremita"), 50, 11, 0);
		item [11] = new Item ("Elixir de Poder (Pequeno)", "", EnumTipoItem.Consumivel, 9, 1, 0, 0, Resources.LoadAll<Sprite>("ItemIcons")[7], Resources.Load<Mesh>("ItemModels/trapos_de_mago_eremita"), 0, 12, 10);
		item [12] = new Item ("Elixir de Poder (Grande)", "", EnumTipoItem.Consumivel, 21, 3, 0, 0, Resources.LoadAll<Sprite>("ItemIcons")[7], Resources.Load<Mesh>("ItemModels/trapos_de_mago_eremita"), 0, 13, 50);
	}
	public static void CarregarMagias(){
		magia [0] = new Magia ("Fogo", Resources.Load<GameObject> ("Magias/Fogo"),  Resources.LoadAll<Sprite>("ItemIcons")[8], 10, 1, EnumNivel.Tolo, 0, EnumElementos.Fogo);
		magia [1] = new Magia ("Raio", Resources.Load<GameObject> ("Magias/Raio"),   Resources.LoadAll<Sprite>("ItemIcons")[9], 20, 2, EnumNivel.Novato, 1, EnumElementos.Eletricidade);
		magia [2] = new Magia ("Natureza", Resources.Load<GameObject> ("Magias/Veneno"),   Resources.LoadAll<Sprite>("ItemIcons")[10], 30, 3, EnumNivel.Novato, 2, EnumElementos.Terra);
	}

	public static void CarregarCards(){
		List<EnumElementos> card0 = new List<EnumElementos> ();
		card0.Add (EnumElementos.Fogo);
		card0.Add (EnumElementos.Terra);


		List<EnumElementos> card1 = new List<EnumElementos> ();
		card1.Add (EnumElementos.Agua);
		card1.Add (EnumElementos.Ar);

		List<EnumElementos> card2 = new List<EnumElementos> ();
		card2.Add (EnumElementos.Fogo);

		List<EnumElementos> card3 = new List<EnumElementos> ();
		card2.Add (EnumElementos.Agua);
		card2.Add (EnumElementos.Terra);



		List<EnumElementos> card4 = new List<EnumElementos> ();
		card2.Add (EnumElementos.Terra);
		card2.Add (EnumElementos.Fogo);

		List<EnumElementos> card5 = new List<EnumElementos> ();
		card2.Add (EnumElementos.Agua);
		card2.Add (EnumElementos.Ar);
		card2.Add (EnumElementos.Terra);

		card [0] = new Card ("Capiroto de Fogo", "Teste", Resources.Load<Sprite>("Testes/fire-elemental"), 10, 10, EnumElementos.Fogo, card0 , card1);
		card [1] = new Card ("Bixão de Agua", "Teste", Resources.Load<Sprite>("Testes/turtle"), 10, 10, EnumElementos.Agua, card1, card0);
		card [2] = new Card ("Slime", "Uma bola de gosma", Resources.Load<Sprite>("Testes/slime"), 15, 0, EnumElementos.Agua, new List<EnumElementos>(), card2);
		card [3] = new Card ("Musgo Errante ", "Teste", Resources.Load<Sprite>("Testes/slime"), 15, 11, EnumElementos.Terra, new List<EnumElementos>(), card3);
		card [4] = new Card ("Soldado de Terra", "Teste", Resources.Load<Sprite>("Testes/slime"), 12, 18, EnumElementos.Terra, new List<EnumElementos>(), card4);
		card [5] = new Card ("Cervo Pequeno Corrompido", "Teste", Resources.Load<Sprite>("Testes/slime"), 12, 13, EnumElementos.Terra, new List<EnumElementos>(), card5);
	}
}
