using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combate : MonoBehaviour {

	public Turno[] turnos = new Turno[0];

	private int turnoAtual = 0;

	void Start()
	{ 
		turnos[turnoAtual].finalizado = false;
	}

	void Update()
	{
		if(turnoAtual >= turnos.Length)
			turnoAtual = 0;
		
		turnos[turnoAtual].Update();

		if(turnos[turnoAtual].finalizado)
		{			
			turnos[turnoAtual].finalizado = false;
			turnoAtual++;
		}	
	}
}