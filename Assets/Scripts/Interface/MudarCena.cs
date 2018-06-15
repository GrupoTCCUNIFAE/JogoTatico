using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour {

	public void CarregarCena(int cena){
		SceneManager.LoadScene(cena);
	}

	public void Sair(){
		Application.Quit ();
	}
}
