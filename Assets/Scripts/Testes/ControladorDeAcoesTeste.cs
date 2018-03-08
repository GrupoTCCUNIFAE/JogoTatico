using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeAcoesTeste : MonoBehaviour {

	public Combate combate;

	private Turno turno;

	void Start () {
		turno = combate.turnos [0];
		turno.AdicionarAcao (new AcaoDeTeste (1));
		turno.AdicionarAcao (new AcaoDeTeste (2));
		turno.rodar = true;
	}
	

	void Update () {
		
	}
}
