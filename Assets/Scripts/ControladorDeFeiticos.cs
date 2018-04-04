using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class ControladorDeFeiticos : MonoBehaviour {

	public Feitico[] feiticos = new Feitico[0];

	void Update()
	{
		foreach (Feitico feitico in feiticos) {
			if (feitico != null) {
				feitico.Update ();
			}
		}
	}

	public void Lancar(int feitico){
		if (feiticos [feitico] != null) 
		{
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
		print (linhaParaSalvar);
	}

	public void Carregar(int slot){
		feiticos [slot].Acoes = new List<Acao> ();

		string algoritimoDaMagia = PlayerPrefs.GetString ("FeiticoSlot" + slot);

		foreach (string acao in algoritimoDaMagia.Split(';')) {
			feiticos [slot].AdicionarAcao(CriarFeitico (acao));
		}
	}

	private Acao CriarFeitico(string acao){
		string[] argumentos;
		int acaoConvertida;
		if (int.TryParse (acao.Substring(0, 3), out acaoConvertida)) {
			argumentos = acao.Split (new char[]{'(',')'}); 
			switch (Mathf.Abs (acaoConvertida)) {
			case 1://Mover		
				return new Mover (int.Parse(argumentos[1]) * 10, 5, "Mover " + acao);
			case 2://Virar
				return new Virar ((int)(90 * int.Parse(argumentos[1])), "Virar " + 90 * Mathf.Sign (acaoConvertida));
			case 3://Mudar de Cor
				byte corRed = byte.Parse (argumentos [1]);
				byte corGreen = byte.Parse (argumentos [3]);
				byte corBlue = byte.Parse (argumentos [5]);
				return new TrocaCor ("Mudar de cor", new Color32 (corRed, corGreen, corBlue, 255));
			case 4://Condicional
				List<Acao> verdadeiras = new List<Acao>();
				List<Acao> falsas = new List<Acao>();
				string[] acoes =  acao.Split (new char[]{'[',']'}); 

				foreach (string acaoAtual in acoes[1].Split(',')) {
					verdadeiras.Add(CriarFeitico (acaoAtual));
				}
				foreach (string acaoAtual in acoes[3].Split(',')) {
					falsas.Add(CriarFeitico (acaoAtual));
				}
				return new Condicional(int.Parse(argumentos[1]), verdadeiras, falsas);
			}
		}
		return null;
	}
}