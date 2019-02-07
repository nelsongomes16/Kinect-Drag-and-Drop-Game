using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControllerJogo : MonoBehaviour {

	[SerializeField]
	GameObject CanvasPontuacao;
	[SerializeField]
	GameObject CanvasMenu;
	[SerializeField]
	GameObject CanvasFimJogo;
	[SerializeField]
	GameObject CameraFrontal;
	[SerializeField]
	GameObject CameraCima;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.M)){
			CanvasPontuacao.SetActive(false);
			CanvasMenu.SetActive (true);
	}
		if (Input.GetKey (KeyCode.C)) {
			CameraFrontal.SetActive (false);
			CameraCima.SetActive (true);
		}
		if (Input.GetKey (KeyCode.F)) {
			CameraFrontal.SetActive (true);
			CameraCima.SetActive (false);
		}
			
}
	public void NovoJogo(){
		Application.LoadLevel (Application.loadedLevel);
		//SceneManager.LoadScene ("scene");
		//SceneManager.LoadScene ("KinectAvatarsDemo");
		//CanvasMenu.SetActive (false);
		//CameraFrontal.SetActive (true);
	}
	public void Sair(){
		Application.Quit ();
	}
	public void NovoJogo2(){
		SceneManager.LoadScene ("scene");
		//SceneManager.LoadScene ("KinectAvatarsDemo");
		CanvasFimJogo.SetActive (false);
		//CameraFrontal.SetActive (true);
	}

	public void novojogo3(){
	}
//	SceneManager.LoadScene ("scene");
//	//SceneManager.LoadScene ("KinectAvatarsDemo");
//	CanvasFimJogo.SetActive (false);
//	//CameraFrontal.SetActive (true);
	public void IrMenuPrincipal(){
		CanvasFimJogo.SetActive (false);
		CanvasMenu.SetActive (true);
}
}
