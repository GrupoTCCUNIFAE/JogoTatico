using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class ControladorDeFeiticos : MonoBehaviour {

	private Feitico[] feiticos;
	public float dis;

	void Start(){
		feiticos = new Feitico[10];
		Itens.CarregarMagias ();
	}

	void Update()
	{
		foreach (Feitico feitico in feiticos) {
			if (feitico != null) {
				feitico.Update ();
			}
		}
	}

	public void Lancar(int feitico){
		PlayerStatus status = PlayerManager.instance.GetComponent<PlayerStatus> ();

		if (feiticos [feitico] != null && status.mana >= feiticos [feitico].Custo && !feiticos [feitico].Rodar) 
		{
			status.Mana -= feiticos [feitico].Custo;
			feiticos [feitico].Rodar = true;
		}
	}

	public void Salvar(int slot){
		string linhaParaSalvar = "";

		foreach(Acao acao in feiticos[slot].Acoes){
			linhaParaSalvar += acao.Id+";";
		}
		linhaParaSalvar = linhaParaSalvar.Remove(linhaParaSalvar.Length - 1);
		PlayerPrefs.SetString ("FeiticoSlot"+slot, linhaParaSalvar);
	}

	public void Carregar(int slot, int elemento){
		if (feiticos [slot] == null || !feiticos [slot].Rodar) {
			feiticos [slot] = new Feitico ();
			feiticos [slot].Acoes = new List<Acao> ();
			feiticos [slot].donoDoFeitico = gameObject;
			feiticos [slot].elemento = elemento;

			string algoritmoDaMagia = PlayerPrefs.GetString ("FeiticoSlot" + slot);

			CriarFeitico (slot, algoritmoDaMagia);

			feiticos [slot].Custo = feiticos [slot].Acoes.Count * Itens.magia [elemento].MultiplicadorDeMana;
		}
	}

	private Acao CriarAcao(string acao){
		string[] argumentos;
		int acaoConvertida;
		if (int.TryParse (acao.Substring(0, 3), out acaoConvertida)) {
			argumentos = acao.Split (new char[]{'(',')'}); 
			switch ((EnumAcoes)Mathf.Abs (acaoConvertida)) {
				case EnumAcoes.Mover:		
				return new Mover (int.Parse(argumentos[1]), dis, "Mover " + acao);

				case EnumAcoes.Virar:
					return new Virar ((int)(90 * int.Parse(argumentos[1])), "Virar " + 90 * Mathf.Sign (acaoConvertida));

				case EnumAcoes.TrocaCor://Mudar de Cor
					byte corRed = byte.Parse (argumentos [1]);
					byte corGreen = byte.Parse (argumentos [3]);
					byte corBlue = byte.Parse (argumentos [5]);
					return new TrocaCor ("Mudar de cor", new Color32 (corRed, corGreen, corBlue, 255));

				case EnumAcoes.Condicional:
					List<Acao> verdadeiras = new List<Acao>();
					List<Acao> falsas = new List<Acao>();
					string[] acoes =  acao.Split (new char[]{'[',']'}); 

					foreach (string acaoAtual in acoes[1].Split(',')) {
						verdadeiras.Add(CriarAcao (acaoAtual));
					}
					foreach (string acaoAtual in acoes[3].Split(',')) {
						falsas.Add(CriarAcao (acaoAtual));
					}
					return new Condicional(int.Parse(argumentos[1]), verdadeiras, falsas);
			}
		}
		return null;
	}

	private void CriarFeitico(int slot, string algoritmo){
		foreach (string acao in algoritmo.Split(';')) {
			feiticos [slot].AdicionarAcao(CriarAcao (acao));
		}
	}

	public Feitico FeiticoAtual{
		get{
			foreach (Feitico feitico in feiticos) {
				if (feitico.Rodar) {
					return feitico;
				}
			}
			return null;
		}
	}
}