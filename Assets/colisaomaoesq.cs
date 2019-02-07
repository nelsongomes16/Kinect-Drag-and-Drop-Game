using UnityEngine;
using System.Collections;

public class colisaomaoesq : MonoBehaviour {

	[SerializeField]
	GameObject PosicaoMaoEsq;
//	[SerializeField]
//	GameObject PosicaoMaoDireita;

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Cylinder"){
			//Destroy (col.gameObject);
			//col.gameObject.SetActive(false);
			col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
			col.gameObject.GetComponent<Rigidbody>().useGravity = false;
			col.gameObject.GetComponent<Collider> ().isTrigger = true;
			//MaoDireita.SetActive(false);
			col.gameObject.transform.parent = PosicaoMaoEsq.transform;
			col.gameObject.transform.position = PosicaoMaoEsq.transform.position;


			Debug.Log ("Colisão Mão esquerda!");
			Debug.Log ("parent: " + col.gameObject.transform.parent.parent.name);
		}
	}
}
