using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
	}

	public void Carregar(int slot){
		feiticos [slot].Acoes = new List<Acao> ();
		int acaoConvertida;
		string algoritimoDaMagia = PlayerPrefs.GetString ("FeiticoSlot"+slot);

		foreach(string acao in algoritimoDaMagia.Split(';')){
			if (int.TryParse (acao, out acaoConvertida)) {
				switch (Mathf.Abs (acaoConvertida)) {
				case 1:
					feiticos [slot].AdicionarAcao (new Mover (acaoConvertida * 10, 5, "Mover " + acao));
					break;
				case 2:
					feiticos [slot].AdicionarAcao (new Virar ((int)(90 * Mathf.Sign (acaoConvertida)), "Virar " + 90 * Mathf.Sign (acaoConvertida)));
					break;
				case 3:
					feiticos [slot].AdicionarAcao (new VirarAzul ("Mudar de cor(Azul)"));
					break;
				}
			}
		}
	}
}