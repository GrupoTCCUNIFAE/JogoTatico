using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeAcoesTeste : MonoBehaviour {

	public PlayerController controller;
	public RotacaoJogador rotacao;
	public ControladorDeFeiticos controladorDeFeiticos;
	public int velocidade;
	public GameObject indicadorDeMagia;
	private List<Acao> acoes = new List<Acao> ();
	private List<Acao> acoes2 = new List<Acao> ();
	private AtaqueFisico ataque;

	public bool condicional = false;

	private bool feiticoLancado = false;
	private Verificador verificador;

	private Feitico feitico;

	void Start () {
		feitico = controladorDeFeiticos.feiticos [0];
		ataque = GetComponent<AtaqueFisico> ();
	}

	void Update () {
		Debug.DrawLine (transform.position+transform.forward, transform.position+transform.forward*3);
		Vector3 posicao = rotacao.localDaMagia ();
		indicadorDeMagia.transform.position = new Vector3 (posicao.x, posicao.y, posicao.z);
		if (Input.GetKeyDown (KeyCode.A))
			ataque.Atacar ();
		if (!feitico.Rodar)
		{
			if (!condicional) {
				if (Input.GetKeyDown (KeyCode.Space)) {
					if (feiticoLancado) {
						feiticoLancado = false;
						controladorDeFeiticos.Lancar (0);
						rotacao.enabled = false;
						controller.enabled = true;
					} else {
						feiticoLancado = true;
						rotacao.enabled = true;
						controller.enabled = false;
					}
				}
				if (Input.GetKeyDown (KeyCode.Alpha1))
					controladorDeFeiticos.Carregar (0);
				if (Input.GetKeyDown (KeyCode.G)) {
					acoes2.Add(new TrocaCor ("Cor vermelha", new Color32 (255, 0, 0, 255)));
					feitico.AdicionarAcao (new Condicional (3, acoes, acoes2));
					acoes = new List<Acao> ();
					acoes2 = new List<Acao> ();
				}
			}
			else {
				if (Input.GetKeyDown (KeyCode.A))
					acoes.Add (new Virar (-90, "Curva a esquerda"));
				if (Input.GetKeyDown (KeyCode.D))
					acoes.Add (new Virar (90, "Curva a direita"));
				if (Input.GetKeyDown (KeyCode.S))
					acoes.Add (new Mover (-velocidade, 5, "Mover para a tras"));
				if (Input.GetKeyDown (KeyCode.W))
					acoes.Add (new Mover (velocidade, 5, "Mover para a frente"));
				if (Input.GetKeyDown (KeyCode.Q))
					acoes.Add (new TrocaCor ("Cor verde", new Color32 (0, 255, 0, 255)));
			}
			if (Input.GetKeyDown (KeyCode.F)) {
				condicional = !condicional;
			}

		}
	}
}
