using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour {
	public static Pontuacao instance;
	public int score = 0;
	[SerializeField]
	Text pontosText;

//	public bool parar;
	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		pontosText.text = "Objetos movidos: " + score.ToString();
//		if (score >= 7) {
//			parar = true;
//		} 
//		else {
//			parar = false;
//		}
//			//canvasfimdejogo
//		}}
}
}
