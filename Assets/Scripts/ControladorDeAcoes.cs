using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeAcoes : MonoBehaviour {

	public GameObject interfaces;
	public Camera cam;

	private ControladorDeFeiticos controladorDeFeiticos;
	private Inventario inventario;

	void Start () {
		controladorDeFeiticos = GetComponent<ControladorDeFeiticos> ();
		inventario = GetComponent<Inventario> ();
		DesativarInterfaces ();
	}

	void Update () {
		if (Input.GetButtonDown ("Inventario")) {
			if (GetInterface ("Inventario").activeSelf) {
				DesativarInterfaces ();
				GetInterface ("PlayerGUI").SetActive (true);
				GetComponent<RotacaoJogador> ().enabled = true;
				cam.fieldOfView = 60;
				Time.timeScale = 1;
			} else {
				DesativarInterfaces ();
				GetInterface ("Inventario").SetActive (true);
				GetComponent<RotacaoJogador> ().enabled = false;
				cam.fieldOfView = 15;
				Time.timeScale = 0;
			}
		}
		if (Input.GetButtonDown ("Cards")) {
			if (GetInterface ("Cards").activeSelf) {
				DesativarInterfaces ();
				GetInterface ("PlayerGUI").SetActive (true);
				GetComponent<RotacaoJogador> ().enabled = true;
				Time.timeScale = 1;
			} else {
				DesativarInterfaces ();
				GetInterface ("Cards").SetActive (true);
				GetComponent<RotacaoJogador> ().enabled = false;
				Time.timeScale = 0;
			}
		}
		if (Input.GetButtonDown("Magia")) {
			LancarMagia(int.Parse(Input.inputString));
		}
		if (!InterfaceAtiva ()) {
			GetInterface ("PlayerGUI").gameObject.SetActive (true);
			Time.timeScale = 1;
		}
		if (Input.GetButtonDown ("MagiasPreparadas")) {			
			if (GetInterface ("Magias").activeSelf) {
				DesativarInterfaces ();
				Time.timeScale = 1;
			}
			else {
				DesativarInterfaces ();
				GetInterface ("Magias").gameObject.SetActive (true);
				Time.timeScale = 0;
			}
		}
	}

	private void DesativarInterfaces(){
		int numeroDeInterfaces = interfaces.transform.childCount;
		for (int cnt = 0; cnt < numeroDeInterfaces; cnt++) {
			interfaces.transform.GetChild (cnt).gameObject.SetActive (false);
		}
	}
	private GameObject GetInterface(string nome){
		int numeroDeInterfaces = interfaces.transform.childCount;
		for (int cnt = 0; cnt < numeroDeInterfaces; cnt++) {
			if (interfaces.transform.GetChild (cnt).gameObject.name == nome)
				return interfaces.transform.GetChild (cnt).gameObject;
		}

		return null;
	}

	public void EditorDeMagia(int slot){
		Transform editor = GetInterface ("Editor").transform;

		if (editor.gameObject.activeSelf) {
			DesativarInterfaces ();
			GetInterface ("PlayerGUI").SetActive (true);
			Time.timeScale = 1;
		} else {
			DesativarInterfaces ();
			editor.GetComponentsInChildren<CriaFeitico> () [0].Slot = slot;
			editor.gameObject.SetActive (true);
			Transform spellPanel = GetInterface ("Editor").GetComponentsInChildren<CriaFeitico>()[0].spellPanel.transform;

			spellPanel.GetChild (0).GetComponent<CriadorDeBlocosProgramaveis> ().enabled = true;

			for (int cnt = 0; cnt < spellPanel.childCount; cnt++) {
				if (cnt == 0) {
					if (spellPanel.GetChild (cnt).childCount > 0) {						
						Destroy (spellPanel.GetChild (cnt).GetChild (0).gameObject);
					} 
				}else {
					Destroy (spellPanel.GetChild (cnt).gameObject);
				}
			}

			Time.timeScale = 0;
		}
	}

	private void LancarMagia(int slot){
		if (inventario.MagiasPreparadas [slot] != -1) {
			controladorDeFeiticos.Carregar (slot, inventario.MagiasPreparadas [slot]);
			controladorDeFeiticos.Lancar (slot);
		}
	}

	private bool InterfaceAtiva(){
		int numeroDeInterfaces = interfaces.transform.childCount;
		for (int cnt = 0; cnt < numeroDeInterfaces; cnt++) {
			if (interfaces.transform.GetChild (cnt).gameObject.activeSelf && interfaces.transform.GetChild (cnt).gameObject.name != "PlayerGUI")
				return true;
		}

		return false;
	}
}
