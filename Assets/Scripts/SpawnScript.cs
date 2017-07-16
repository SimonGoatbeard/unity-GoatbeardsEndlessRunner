using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	public GameObject[] enemyList;
	float lastFired;
	int randomenemy;
	float randomWait=0.75f;
	// Use this for initialization
	void Start () {

			
	}
	
	// Update is called once per frame
	void Update () {

		if(( Time.time > lastFired + randomWait)){
			StartCoroutine(WaitForSpawn());
			lastFired=Time.time;
			randomWait=Random.Range(0.6f,1f);
		}
	}

	IEnumerator WaitForSpawn() {
		yield return new WaitForSeconds(1);
		SpawnEnemy();
	}

	void SpawnEnemy(){
		randomenemy=Random.Range(0,8);
		switch(randomenemy){
		case 0:
			GameObject.Instantiate(enemyList[0],new Vector3(15f,-1f,-1f),Quaternion.identity);
			break;
		case 1:
			GameObject.Instantiate(enemyList[1],new Vector3(15f,-3f,-1f),Quaternion.identity);
			break;
		case 2:
			GameObject.Instantiate(enemyList[2],new Vector3(15f,-2.95f,-1f),Quaternion.identity);
			break;
		case 3:
			GameObject.Instantiate(enemyList[3],new Vector3(15f,-3f,-1f),Quaternion.identity);
			break;
		case 4:
			GameObject.Instantiate(enemyList[4],new Vector3(15f,-2.95f,-1f),Quaternion.identity);
			break;
		case 5:
			GameObject.Instantiate(enemyList[5],new Vector3(15f,-1f,-1f),Quaternion.identity);
			break;
		case 6:
			GameObject.Instantiate(enemyList[6],new Vector3(15f,-1f,-1f),Quaternion.identity);
			break;
		case 7:
			GameObject.Instantiate(enemyList[7],new Vector3(15f,-1f,-1f),Quaternion.identity);
			break;
		case 8:
			GameObject.Instantiate(enemyList[8],new Vector3(15f,-1f,-1f),Quaternion.identity);
			break;
	}
	
}
}