using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Itens{

	public static Item[] item = new Item[21];
	public static Magia[] magia = new Magia[3];
	public static Card[] card = new Card[7];

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
		item [9] = new Item ("Elixir de Vitalidade (Pequeno)", "", EnumTipoItem.Consumivel, 8, 3, 0, 0, Resources.LoadAll<Sprite>("ItemIcons")[6], Resources.Load<Mesh>("ItemModels/trapos_de_mago_eremita"), 10, 9, 0);
		item [10] = new Item ("Elixir de Vitalidade (Grande)", "", EnumTipoItem.Consumivel, 19, 1, 0, 0, Resources.LoadAll<Sprite>("ItemIcons")[6], Resources.Load<Mesh>("ItemModels/trapos_de_mago_eremita"), 50, 10, 0);
		item [11] = new Item ("Elixir de Poder (Pequeno)", "", EnumTipoItem.Consumivel, 9, 1, 0, 0, Resources.LoadAll<Sprite>("ItemIcons")[7], Resources.Load<Mesh>("ItemModels/trapos_de_mago_eremita"), 0, 11, 10);
		item [12] = new Item ("Elixir de Poder (Grande)", "", EnumTipoItem.Consumivel, 21, 3, 0, 0, Resources.LoadAll<Sprite>("ItemIcons")[7], Resources.Load<Mesh>("ItemModels/trapos_de_mago_eremita"), 0, 12, 50);
		item [13] = new Item (13, "Anel de Orm Embar", "Anel feito com a escama de um antigo dragão, quando utilizado libera um orbe de fogo que ilumina o caminho de seu portador.", new LuzPerseguidora(), Resources.LoadAll<Sprite>("ItemIcons")[12]);
		item [14] = new Item (14, "Relogio de Alquimista", "Relogio criado para maximizar os poderes de seu portador, utiliza-lo lhe dara uma taxa de regeneração de poder", new SobeMana(), Resources.LoadAll<Sprite>("ItemIcons")[13]);
		item [15] = new Item (15, "Escudo Arcano", "Orbe de cristal que emana energias misteriosas e é quente ao toque.", new EscudoArcano(), Resources.LoadAll<Sprite>("ItemIcons")[14]);
		item [16] = new Item (16, "Crânio de Nosferus", "Crânio profanado de um vampiro ancestral", new CranioDeNosferus(), Resources.LoadAll<Sprite>("ItemIcons")[15]);
		item [17] = new Item (17, "Brasão de Ardhas", "Um amuleto de prata com um brasão esculpido", new BrasaoDeArdhas (), Resources.LoadAll<Sprite> ("ItemIcons") [16]);
		item [18] = new Item (18, "Caixa de Tardius", "Uma misteriosa caixa azul de madeira, niguém sabe de onde veio mas as lendas contam que ela é de outra dimensão", new CaixaDeTardius (), Resources.LoadAll<Sprite> ("ItemIcons") [17]);
		item [19] = new Item (19, "Broche de Navih", "Broche de uma fada irritante", new Fada (), Resources.LoadAll<Sprite> ("ItemIcons") [18]);
		item [20] = new Item (20, "Olho de Zathanar", "Olho do lendario beholder Zathanar", new OlhoDeZathanar (), Resources.LoadAll<Sprite> ("ItemIcons") [19]);
	}
	public static void CarregarMagias(){
		magia [0] = new Magia ("Fogo", Resources.Load<GameObject> ("Magias/Fogo"),  Resources.LoadAll<Sprite>("ItemIcons")[8], 10, 1, EnumNivel.Tolo, 0, EnumElementos.Fogo);
		magia [1] = new Magia ("Raio", Resources.Load<GameObject> ("Magias/Raio"),   Resources.LoadAll<Sprite>("ItemIcons")[9], 20, 2, EnumNivel.Novato, 1, EnumElementos.Eletricidade);
		magia [2] = new Magia ("Natureza", Resources.Load<GameObject> ("Magias/Veneno"),   Resources.LoadAll<Sprite>("ItemIcons")[10], 30, 3, EnumNivel.Novato, 2, EnumElementos.Terra);
	}

	public static void CarregarCards(){
		List<EnumElementos> fraquesas = new List<EnumElementos> ();
		fraquesas.Add (EnumElementos.Agua);
		fraquesas.Add (EnumElementos.Ar);
		List<EnumElementos> resistencias = new List<EnumElementos> ();
		resistencias.Add (EnumElementos.Fogo);
		resistencias.Add (EnumElementos.Terra);
		card [0] = new Card ("Capiroto de Fogo", "É o coisa ruim", Resources.Load<Sprite>("Testes/fire-elemental"), 10, 10, EnumElementos.Fogo, resistencias, resistencias);

		fraquesas = new List<EnumElementos> ();
		fraquesas.Add (EnumElementos.Fogo);
		fraquesas.Add (EnumElementos.Terra);
		resistencias = new List<EnumElementos> ();
		resistencias.Add (EnumElementos.Agua);
		resistencias.Add (EnumElementos.Ar);
		card [1] = new Card ("Bixão de Agua", "Ó o bixo vino", Resources.Load<Sprite>("Testes/turtle"), 10, 10, EnumElementos.Agua, resistencias, resistencias);

		fraquesas = new List<EnumElementos> ();
		fraquesas.Add (EnumElementos.Fogo);
		resistencias = new List<EnumElementos> ();
		resistencias.Add (EnumElementos.Agua);
		resistencias.Add (EnumElementos.Veneno);
		card [2] = new Card ("Slime", "Uma bola de gosma", Resources.Load<Sprite>("Cards/slime"), 15, 0, EnumElementos.Agua, resistencias, resistencias);

		fraquesas = new List<EnumElementos> ();
		fraquesas.Add (EnumElementos.Fogo);
		resistencias = new List<EnumElementos> ();
		resistencias.Add (EnumElementos.Agua);
		resistencias.Add (EnumElementos.Terra);
		card [3] = new Card ("Musgo Errante ", "Um fungo do tamanho de um ser humano", Resources.Load<Sprite>("Testes/fungo"), 15, 11, EnumElementos.Terra, resistencias, resistencias);

		fraquesas = new List<EnumElementos> ();
		fraquesas.Add (EnumElementos.Agua);
		resistencias = new List<EnumElementos> ();
		resistencias.Add (EnumElementos.Eletricidade);
		resistencias.Add (EnumElementos.Terra);
		card [4] = new Card ("Soldado de Terra", "Um golem guerreiro feito de lama", Resources.Load<Sprite>("Testes/soldado-terra"), 12, 18, EnumElementos.Terra, resistencias, resistencias);

		fraquesas = new List<EnumElementos> ();
		fraquesas.Add (EnumElementos.Fogo);
		fraquesas.Add (EnumElementos.Eletricidade);
		resistencias = new List<EnumElementos> ();
		resistencias.Add (EnumElementos.Veneno);
		resistencias.Add (EnumElementos.Escuridao);
		card [5] = new Card ("Cervo Pequeno Corrompido", "Um pequeno cervo corrompido por forças obscuras", Resources.Load<Sprite>("Cards/cervo"), 12, 13, EnumElementos.Terra, resistencias, resistencias);

		fraquesas = new List<EnumElementos> ();
		fraquesas.Add (EnumElementos.Fogo);
		resistencias = new List<EnumElementos> ();
		resistencias.Add (EnumElementos.Agua);
		card [6] = new Card ("Carrapicho", "Bicho espinhento que corre atrás até grudar em você e te matar", Resources.Load<Sprite>("Testes/carrapicho"), 12, 13, EnumElementos.Terra, resistencias, fraquesas);
	}
}
