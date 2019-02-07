using UnityEngine;
using System.Collections;

public class Colisao : MonoBehaviour {

//	[SerializeField]
//	GameObject PosicaoMaoEsquerda;
	[SerializeField]
	GameObject ColMaoDireita;
	[SerializeField]
	GameObject PosicaoMaoDireita;

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Cylinder"){
			//Destroy (col.gameObject);
			//col.gameObject.SetActive(false);
			   col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
			col.gameObject.GetComponent<Rigidbody>().useGravity = false;
			//MaoDireita.SetActive(false);
			col.gameObject.transform.parent = PosicaoMaoDireita.transform;
			col.gameObject.transform.position = PosicaoMaoDireita.transform.position;
			col.gameObject.GetComponent<Collider> ().isTrigger = true;

//			col.gameObject.transform.parent = GameObject.Find ("U_CharaterBack").transform;
//			col.gameObject.transform.parent = GameObject.Find ("U").transform;
//			col.gameObject.transform.parent = GameObject.Find ("joint_Char").transform;
//			col.gameObject.transform.parent = GameObject.Find ("joint_Pelvis").transform;
//			col.gameObject.transform.parent = GameObject.Find ("joint_TorsoA").transform;
//			col.gameObject.transform.parent = GameObject.Find ("joint_TorsoB").transform;
//			col.gameObject.transform.parent = GameObject.Find ("joint_TorsoC").transform;
//			col.gameObject.transform.parent = GameObject.Find ("joint_ClavicleRT").transform;
//			col.gameObject.transform.parent = GameObject.Find ("joint_ShoulderRT").transform;
//			col.gameObject.transform.parent = GameObject.Find ("joint_ElbowRT").transform;
//			col.gameObject.transform.parent = GameObject.Find ("joint_HandRT").transform;
//			col.gameObject.transform.parent = GameObject.Find ("ColliderMaoDireita").transform;
			Debug.Log ("Colisão Mão Direita!");
			Debug.Log ("parent: " + col.gameObject.transform.parent.parent.name);
	}
}
}
