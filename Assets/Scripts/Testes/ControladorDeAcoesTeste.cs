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

		if (Input.GetKeyDown (KeyCode.P))
			criadorDeMagias.SetActive (true);

		if (Input.GetKeyDown (KeyCode.A))
			ataque.Atacar ();

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
					controladorDeFeiticos.Carregar (0);
					controladorDeFeiticos.Lancar (0);
		}
	}
}
