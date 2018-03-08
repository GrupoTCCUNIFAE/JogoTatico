using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcaoDeTeste : Acao {

	private int num;

	public AcaoDeTeste(int n){
		num = n;
	}

	public override void Update()
	{
		Debug.Log (num);

		if (Time.time > num)
			finalizado = true;
	}
}
