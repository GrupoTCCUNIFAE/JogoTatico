using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeAcoesTeste : MonoBehaviour {

	public ControladorDeFeiticos controladorDeFeiticos;
	public TextMesh texto;
	public int velocidade;
	public Material teste;

	private Feitico feitico;

	void Start () {
		feitico = controladorDeFeiticos.feiticos [0];
	}

	void Update () {
		if (!feitico.Rodar)
		{
			if (Input.GetKeyDown (KeyCode.Space)) 
				controladorDeFeiticos.Lancar (0);
			if (Input.GetKeyDown (KeyCode.A))
				feitico.AdicionarAcao (new Virar(-90,"Curva a esquerda"));
			if (Input.GetKeyDown (KeyCode.D))
				feitico.AdicionarAcao (new Virar(90,"Curva a direita"));
			if (Input.GetKeyDown (KeyCode.S))
				feitico.AdicionarAcao (new Mover (-velocidade, 5, "Mover para a tras"));
			if (Input.GetKeyDown (KeyCode.W))
				feitico.AdicionarAcao (new Mover (velocidade, 5, "Mover para a frente"));
			if(Input.GetKeyDown(KeyCode.C))
				controladorDeFeiticos.Salvar (0);
			if (Input.GetKeyDown (KeyCode.Q))
				feitico.AdicionarAcao (new VirarAzul ("Cor azul"));
			if(Input.GetKeyDown(KeyCode.Alpha1))
				controladorDeFeiticos.Carregar (0);
		}
		texto.text = feitico.printAcoes ();
	}
}
