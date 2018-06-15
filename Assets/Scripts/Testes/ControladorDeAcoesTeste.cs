using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeAcoesTeste : MonoBehaviour {

	public PlayerController controller;
	public RotacaoJogador rotacao;
	public ControladorDeFeiticos controladorDeFeiticos;
	public int velocidade;
	public GameObject indicadorDeMagia;
	public GameObject criadorDeMagias;
	public GameObject interfaceDoJogador;

	private AtaqueFisico ataque;
	private Verificador verificador;
	private Feitico feitico;

	void Start () {
		feitico = controladorDeFeiticos.feiticos [0];
		ataque = GetComponent<AtaqueFisico> ();
	}

	void Update () {
		Vector3 posicao = rotacao.localDaMagia ();
		indicadorDeMagia.transform.position = new Vector3 (posicao.x, posicao.y, posicao.z);

		if (Input.GetKeyDown (KeyCode.P)) {
			AbrirCriador ();
		}

		if(criadorDeMagias.activeSelf){
			interfaceDoJogador.SetActive(false);
			Time.timeScale = 0;
		}else{
			interfaceDoJogador.SetActive(true);
			Time.timeScale = 1;
		}

		if (Input.GetKeyDown (KeyCode.A))
			ataque.Atacar ();

		if (Input.GetKeyDown (KeyCode.Space) && !feitico.Rodar) {
					controladorDeFeiticos.Carregar (0);
					controladorDeFeiticos.Lancar (0);
		}
	}

	public void AbrirCriador(){
		if (criadorDeMagias.activeSelf) {
			criadorDeMagias.SetActive (false);
		} else {
			criadorDeMagias.SetActive (true);
		}
	}
}
