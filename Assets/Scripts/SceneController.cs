using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class SceneController : Singleton<SceneController>{

	private bool carregando;
	private bool comecarCarregamento;
	private string nomeProximaCena;
	private float tempoMinimoLoad;

	void Start(){
		if (base.SingletonStart()){
			Itens.CarregarCards ();
			Itens.CarregarItens ();
			Itens.CarregarMagias ();
			comecarCarregamento = true;
			carregando = false;
			nomeProximaCena = "MainMenu";
			tempoMinimoLoad = 3;
		}
	}

	void Update(){
		if (comecarCarregamento && !carregando)
			StartCoroutine(ComecarCarregarCena());
	}

	public IEnumerator ComecarCarregarCena(){
		carregando = true;

		Animator animacaoFade = null;//GameObject.Find ("Fade").GetComponent<Animator>();

		if(animacaoFade != null)
			animacaoFade.SetTrigger("show");

		yield return new WaitForEndOfFrame();
		if (animacaoFade != null) {
			if (animacaoFade.GetCurrentAnimatorStateInfo (0).IsName ("FadeIn"))
				yield return new WaitForSeconds (animacaoFade.GetCurrentAnimatorStateInfo (0).length);
		}

		AsyncOperation op = SceneManager.LoadSceneAsync("LoadingScene");

		while (!op.isDone)
			yield return new WaitForEndOfFrame();

		float tempoCarregando = Time.time + tempoMinimoLoad;

		op = SceneManager.LoadSceneAsync(nomeProximaCena);
		op.allowSceneActivation = false;

		while (!op.isDone){
			float percentual = (op.progress / 0.9f) * 100;

			if(GameObject.Find("Barra").GetComponent<Slider>() != null)
				GameObject.Find("Barra").GetComponent<Slider>().value = percentual/100;

			if (GameObject.Find("Percentual").GetComponent<Text>() != null)
				GameObject.Find("Percentual").GetComponent<Text>().text = String.Format("{0:0}", percentual) + "%";

			if (percentual == 100)
				break;

			yield return new WaitForEndOfFrame();
		}

		while( Time.time < tempoCarregando )
			yield return new WaitForEndOfFrame();

		op.allowSceneActivation = true;

		comecarCarregamento = false;
		carregando = false;
		nomeProximaCena = "";
	}

	public void LoadScene( string nomeProximaCena){
		this.nomeProximaCena = nomeProximaCena;
		comecarCarregamento = true;
	}
}