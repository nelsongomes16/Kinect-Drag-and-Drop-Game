using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ContagemTempo : MonoBehaviour {
	[SerializeField]
	Text TimerText;
	[SerializeField]
	GameObject CanvasFimJogo; 
//	[SerializeField]
//	GameObject CanvasPontos;
//	[SerializeField]
//	GameObject CanvasFimJogo;
	public float InitialTime = 0;

	void OnEnable(){
		Debug.Log ("esta a ser chamada");
	}
	// Use this for initialization
	void Start () {
		//TimerText = GetComponent<Text> ();
		//float timeleft = 60.0f;
	}

	// Update is called once per frame
	void Update () {
			
		TimerText.text = "Tempo de jogo: " + InitialTime.ToString ("f0") + " s";
		if (Pontuacao.instance.score >= 5) {
			InitialTime = InitialTime;
			CanvasFimJogo.SetActive (true);

		}
		else{
				InitialTime += Time.deltaTime;
			}
			//print (InitialTime);
		}
	}
