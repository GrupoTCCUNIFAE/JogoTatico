using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXPUI : MonoBehaviour {

	public GameObject levelUpUI;

	private PlayerStatus playerStat;
	private int levelAtual;

	void Start(){
		playerStat = PlayerManager.instance.GetComponent<PlayerStatus> ();
		levelAtual = playerStat.xp.Level;
	}

	public void AumentarVida(){
		playerStat.VidaMaxima += playerStat.xp.Level*10;
		Time.timeScale = 1;
		levelUpUI.SetActive (false);
	}

	public void AumentarMana(){
		playerStat.ManaMaxima += playerStat.xp.Level*10;
		Time.timeScale = 1;
		levelUpUI.SetActive (false);
	}

	public void NovoElemento(){

		Time.timeScale = 1;
		levelUpUI.SetActive (false);

		if (ProcurarProximaMagia (EnumNivel.Tolo))
			return;
		if (ProcurarProximaMagia (EnumNivel.Novato))
			return;
		if (ProcurarProximaMagia (EnumNivel.Adepto))
			return;
		if (ProcurarProximaMagia (EnumNivel.Mestre))
			return;	
		if (ProcurarProximaMagia (EnumNivel.Arquimago))
			return;	
	}

	public void AumentarVelocidade(int value){
		playerStat.Velocidade += value;
		Time.timeScale = 1;
		levelUpUI.SetActive (false);
	}

	void Update () {
		if(playerStat.xp.Level > levelAtual){
			levelAtual = playerStat.xp.Level;
			PlayerManager.instance.GetComponent<ControladorDeAcoes> ().DesativarInterfaces ();
			Time.timeScale = 0f;
			levelUpUI.SetActive (true);
		}

		if (Input.GetKeyDown (KeyCode.G)) {
			playerStat.xp.XpAtual += 100;
		}

	}

	private bool ProcurarProximaMagia(EnumNivel nivel){
		Inventario inv = PlayerManager.instance.GetComponent<Inventario> ();

		foreach (Magia magia in Itens.magia) {
			if (magia.Nivel == nivel) {
				if (!inv.Magias.Exists(x => x == magia.Id)){
					inv.Magias.Add (magia.Id);
					return true;
				}
			}
		}

		return false;
	}
}
