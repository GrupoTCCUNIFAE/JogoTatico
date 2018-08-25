using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ControleDePosicao : MonoBehaviour {

	private Posicao posicao = new Posicao ("mapa_1", -168, -74);
	public GameObject target;

	void Start () {
		//SceneManager.GetActiveScene()
		if(posicao.Nome.Equals("mapa_1")){
			target.transform.localPosition = new Vector3(posicao.PosicaoX, posicao.PosicaoY, 0);
		}

	}
	


}
