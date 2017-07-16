using UnityEngine;
using System.Collections;

public class GroundScript : MonoBehaviour {

	Vector3 startPosition;
	void Start () {
		startPosition=new Vector3(-0.89f,-3.95f,0f);
		transform.position=startPosition;
	}
	void Update () {
		if(transform.position.x==0&&transform.position.y==0){
			transform.position=startPosition;
		}
	}
}
