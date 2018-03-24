using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeAcoesTeste : MonoBehaviour {

	public ControladorDeFeiticos controladorDeFeiticos;
	public TextMesh texto;
	public int velocidade;
	public Material teste;
	private List<Acao> acoes = new List<Acao> ();
	private List<Acao> acoes2 = new List<Acao> ();

	public bool condicional = false;

	private Verificador verificador;

	private Feitico feitico;

	void Start () {
		feitico = controladorDeFeiticos.feiticos [0];
	}

	void Update () {
		if (!feitico.Rodar)
		{
			if (!condicional) {
				if (Input.GetKeyDown (KeyCode.Space))
					controladorDeFeiticos.Lancar (0);
				if (Input.GetKeyDown (KeyCode.A))
					feitico.AdicionarAcao (new Virar (-90, "Curva a esquerda"));
				if (Input.GetKeyDown (KeyCode.D))
					feitico.AdicionarAcao (new Virar (90, "Curva a direita"));
				if (Input.GetKeyDown (KeyCode.S))
					feitico.AdicionarAcao (new Mover (-velocidade, 5, "Mover para a tras"));
				if (Input.GetKeyDown (KeyCode.W))
					feitico.AdicionarAcao (new Mover (velocidade, 5, "Mover para a frente"));
				if (Input.GetKeyDown (KeyCode.C))
					controladorDeFeiticos.Salvar (0);
				if (Input.GetKeyDown (KeyCode.Q))
					feitico.AdicionarAcao (new TrocaCor ("Cor azul", new Color32 (21, 0, 129, 255)));
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
					acoes.Add (new TrocaCor ("Cor azul", new Color32 (21, 0, 129, 255)));
			}
			if (Input.GetKeyDown (KeyCode.F)) {
				condicional = !condicional;
			}

		}
		texto.text = feitico.printAcoes ();
	}
}
