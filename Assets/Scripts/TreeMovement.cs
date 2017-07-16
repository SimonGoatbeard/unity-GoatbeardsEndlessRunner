using UnityEngine;
using System.Collections;

public class TreeMovement : MonoBehaviour {
	Vector3 target;
	public float speed;
	Vector3 startPosition;
	void Start (){
		startPosition=new Vector3(12.5f,transform.position.y,transform.position.z);
		target=new Vector3(-12.5f,transform.position.y,transform.position.z);
	}

	void Update () {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target, step);
		if(transform.position==target){
			transform.position=startPosition;
		}
	}
}
