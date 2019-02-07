using UnityEngine;
using System.Collections;

public class dropScript : MonoBehaviour {
	
//	void OnCollisionEnter(Collision col)
//	{
//		if(col.gameObject.tag == "Cylinder2"){
//
//			col.gameObject.transform.parent = null;
//			col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
//			col.gameObject.GetComponent<Rigidbody> ().useGravity = true;
//			Debug.Log ("ColisãoMesa: Objeto caiu!");
//
//			//pontos ++
//		}
//	}
	void OnTriggerEnter (Collider col2){
		if (col2.gameObject.tag == "Cylinder") {
			col2.gameObject.transform.parent = null;
			col2.gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			col2.gameObject.GetComponent<Rigidbody> ().useGravity = true;
			Debug.Log ("ColisãoMesa: Objeto caiu!");
			Pontuacao.instance.score++;
		}
	}
}
