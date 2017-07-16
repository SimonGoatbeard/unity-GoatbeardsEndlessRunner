using UnityEngine;
using System.Collections;

public class TurboDestroyer : MonoBehaviour {

	void Update () {
	if(transform.position.x<-14.5f){
		Destroy(this.gameObject);
	}
	}
}
