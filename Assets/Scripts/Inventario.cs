using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour {

	public MeshFilter armaduraMesh;
	public MeshFilter armaMesh;

	private List<int> itens;
	private List<int> magias;
	private List<int> cards;
	private int[] magiasPreparadas = new int[10];
	private int armadura = -1;
	private int arma = -1;
	private Controle controle;
	private Mesh playerSemArmadura;

	void Start(){
		playerSemArmadura = Resources.Load<Mesh> ("ItemModels/player_sem_armadura");
		Controle controle = PlayerManager.instance.GetComponent<Controle> ();

		for(int cnt=0; cnt<10; cnt++){
			magiasPreparadas[cnt] = -1;
		}

		if (controle.Data != null) {
			itens = controle.Data.itens;
			arma = controle.Data.arma;
			armadura = controle.Data.armadura;
			magias = controle.Data.magias;
			cards = controle.Data.cards;
			magiasPreparadas = controle.Data.magiasPreparadas;
		} else {
			itens = new List<int> ();
			magias = new List<int> ();
			cards = new List<int> ();
		}
	}

	void Update(){
		AtualizarVizual ();
	}

	public bool AdicionarCard(int cardAdicionado){
		foreach (int card in cards) {
			if (card == cardAdicionado)
				return false;
		}
		cards.Add (cardAdicionado);
		return true;
	}

	private void AtualizarVizual(){
		if (armadura != -1)
			armaduraMesh.mesh = Itens.item [armadura].Modelo;
		else
			armaduraMesh.mesh = playerSemArmadura;

		if (arma != -1)
			armaMesh.mesh = Itens.item [arma].Modelo;
		else
			armaMesh.mesh = null;
	}

	public List<int> Bolsa{
		get{return itens;}
	}

	public bool AdicionarItem(int id){
		itens.Add (id);
		return true;
	}

	public int Armadura{
		get{return armadura;}
		set{
			if (value != -1) {
				if (armadura != -1) {
					itens.Add (armadura);
				}
				itens.Remove (value);
			} else {
				itens.Add (armadura);
			}

			armadura = value;
		}
	}

	public int Arma{
		get{return arma;}
		set{
			if (value != -1) {
				if (arma != -1) {
					itens.Add (arma);
				}
				itens.Remove (value);
			} else {
				itens.Add (arma);
			}

			arma = value;
		}
	}

	public List<int> Magias{
		get{ return magias; }
		set{ magias = value; }
	}

	public int[] MagiasPreparadas{
		get{ return magiasPreparadas; }
		set{ magiasPreparadas = value; }
	}
	public List<int> Cards{
		get{ return cards; }
		set{ cards = value; }
	}
}
