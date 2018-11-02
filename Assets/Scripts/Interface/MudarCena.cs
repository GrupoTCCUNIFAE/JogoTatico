using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour {

	public void CarregarCena(string cena){
		GameObject.Find ("SceneManager").GetComponent<SceneController> ().LoadScene (cena);
	}

	public void Sair(){
		Application.Quit ();
	}
}
