using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeAcoesTeste : MonoBehaviour {

	public ControladorDeFeiticos controladorDeFeiticos;
	public TextMesh texto;

	private Feitico feitico;

	void Start () {
		feitico = controladorDeFeiticos.feiticos [0];
	}

	void Update () {
		if (!feitico.Rodar)
		{
			if (Input.GetKeyDown (KeyCode.Space))
				feitico.Rodar = true;
			if (Input.GetKeyDown (KeyCode.D))
				feitico.AdicionarAcao (new Mover (new Vector2 (20, 0), 5, "Mover para a direita"));
			if (Input.GetKeyDown (KeyCode.A))
				feitico.AdicionarAcao (new Mover (new Vector2 (-20, 0), 5, "Mover para a esquerda"));
			if (Input.GetKeyDown (KeyCode.S))
				feitico.AdicionarAcao (new Mover (new Vector2 (0, -20), 5, "Mover para a tras"));
			if (Input.GetKeyDown (KeyCode.W))
				feitico.AdicionarAcao (new Mover (new Vector2 (0, 20), 5, "Mover para a frente"));
		}
		texto.text = feitico.printAcoes ();
	}
}
