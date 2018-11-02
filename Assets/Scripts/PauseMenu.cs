using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public void Salvar(){
		PlayerManager.instance.player.GetComponent<Controle> ().Salvar ();
	}

	public void Sair(){
		Application.Quit ();
	}

	public void Continuar(){
		PlayerManager.instance.player.GetComponent<RotacaoJogador> ().enabled = true;
		gameObject.SetActive (false);
	}

	public void Menu(){
		GameObject.Find ("SceneManager").GetComponent<SceneController> ().LoadScene ("MainMenu");
	}
}
