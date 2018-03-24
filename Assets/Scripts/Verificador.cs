using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verificador : MonoBehaviour {

	public int distancia;

	private bool inimigoFrente = false;
	private bool obstaculoFrente = false;
	private bool objetoFrente = false;
	private Vector3 frente;
	private bool inimigoDireita = false;
	private bool obstaculoDireita = false;
	private bool objetoDireita = false;
	private Vector3 direita;
	private bool inimigoEsquerda = false;
	private bool obstaculoEsquerda = false;
	private bool objetoEsquerda = false;
	private Vector3 esquerda;

	private RaycastHit objetoColisao;

	void Update () {
		VerificarFrente ();
		VerificarDireita ();
		VerificarEsquerda ();
	}

	private void VerificarEsquerda(){
		esquerda = transform.position-(transform.right*(transform.localScale.x/2));
		//Raio da esquerda
		Debug.DrawLine (esquerda, esquerda - transform.right * distancia, Color.green);

		if (Physics.Linecast (esquerda, esquerda - transform.right * distancia, out objetoColisao)) 
		{
			if (objetoColisao.collider.tag == "Mob")
				inimigoEsquerda = true;
			else
				inimigoEsquerda = false;

			if (objetoColisao.collider.tag == "Obstacle")
				obstaculoEsquerda = true;
			else
				obstaculoEsquerda = false;

			if (objetoColisao.collider.tag == "Object")
				objetoEsquerda = true;
			else
				objetoEsquerda = false;
		} 
		else 
		{
			inimigoEsquerda = false;
			obstaculoEsquerda = false;
			objetoEsquerda = false;
		}
	}

	private void VerificarDireita(){
		direita = transform.position+(transform.right*(transform.localScale.x/2));
		//Raio da direita
		Debug.DrawLine (direita, direita + transform.right * distancia, Color.red);

		if (Physics.Linecast (direita, direita + transform.right * distancia, out objetoColisao)) 
		{
			if (objetoColisao.collider.tag == "Mob")
				inimigoDireita = true;
			else
				inimigoDireita = false;

			if (objetoColisao.collider.tag == "Obstacle")
				obstaculoDireita = true;
			else
				obstaculoDireita = false;

			if (objetoColisao.collider.tag == "Object")
				objetoDireita = true;
			else
				objetoDireita = false;
		} 
		else 
		{
			inimigoDireita = false;
			obstaculoDireita = false;
			objetoDireita = false;
		}
	}

	private void VerificarFrente(){
		frente = transform.position+(transform.forward*(transform.localScale.z/2));
		//Raio da frente
		Debug.DrawLine (frente, frente + transform.forward * distancia, Color.blue);

		if (Physics.Linecast (frente, frente + transform.forward * distancia, out objetoColisao)) 
		{
			if (objetoColisao.collider.tag == "Mob")
				inimigoFrente = true;
			else
				inimigoFrente = false;

			if (objetoColisao.collider.tag == "Obstacle")
				obstaculoFrente = true;
			else
				obstaculoFrente = false;

			if (objetoColisao.collider.tag == "Object")
				objetoFrente = true;
			else
				objetoFrente = false;
		} 
		else 
		{
			inimigoFrente = false;
			obstaculoFrente = false;
			objetoFrente = false;
		}
	}

	public bool InimigoFrente{
		get{return inimigoFrente;}
		set{inimigoFrente = value;}
	}

	public bool InimigoEsquerda{
		get{return inimigoEsquerda;}
		set{inimigoEsquerda = value;}
	}

	public bool InimigoDireita{
		get{return inimigoDireita;}
		set{inimigoDireita = value;}
	}

	public bool ObjetoFrente{
		get{return objetoFrente;}
		set{objetoFrente = value;}
	}

	public bool ObjetoEsquerda{
		get{return objetoEsquerda;}
		set{objetoEsquerda = value;}
	}

	public bool ObjetoDireita{
		get{return objetoDireita;}
		set{objetoDireita = value;}
	}

	public bool ObstaculoFrente{
		get{return obstaculoFrente;}
		set{obstaculoFrente = value;}
	}

	public bool ObstaculoEsquerda{
		get{return obstaculoEsquerda;}
		set{obstaculoEsquerda = value;}
	}

	public bool ObstaculoDireita{
		get{return obstaculoDireita;}
		set{obstaculoDireita = value;}
	}
}
