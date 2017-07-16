using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	Vector3 target;
	public float speed;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		target=new Vector3(-15f,transform.position.y,transform.position.z);
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target, step);
	
	}
}
