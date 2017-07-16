using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	float jumpSpeed = 5f;
	bool click=true;
	public Animator animator;
	Vector3 startPosition;
	TextMesh life;
	int goldCount;
	int lifeCount=3;
	public GameObject health3;
	public GameObject health2;
	public GameObject health1;
	bool gameOver=false;

	// Use this for initialization
	void Start () {
		startPosition=new Vector3(-7.6f,-2.163f,-7f);
		transform.position=startPosition;
		animator.speed=1.5f;
		goldCount=0;
		PlayerPrefs.SetInt("GoldCount", 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
if(click){
			GetComponent<Rigidbody2D>().velocity += jumpSpeed * Vector2.up;
				animator.SetBool("isJumping",true);
				click=false;
			}
		}
		if(transform.position.y>-0.7)
			GetComponent<Rigidbody2D>().velocity=0.5f*Vector2.down;
		if(transform.position.x==0&&transform.position.y==0){
			transform.position=startPosition;
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.name=="Ground"){
			animator.SetBool("isJumping",false);
			click=true;
		}
	
	
		if(other.gameObject.tag=="Gold"){
			Destroy(other.gameObject);
			goldCount++;
			PlayerPrefs.SetInt("GoldCount", goldCount);
		}


		if(other.gameObject.tag=="Enemy"){
			Destroy(other.gameObject);
			if(lifeCount!=0){
				lifeCount--;
				switch(lifeCount){
				case 3:
					health1.SetActive(true);
					health2.SetActive(true);
					health3.SetActive(true);
					break;
				case 2:
					health1.SetActive(true);
					health2.SetActive(true);
					health3.SetActive(false);
					break;
				case 1:
					health1.SetActive(true);
					health2.SetActive(false);
					health3.SetActive(false);
					break;
				case 0:
					health1.SetActive(false);
					health2.SetActive(false);
					health3.SetActive(false);
					break;
				}


				gameOver=false;
			}
			else{
				gameOver=true;
			}
			PlayerPrefs.SetInt("GoldCount", goldCount);
		}
		if(gameOver){
			Application.LoadLevel(3);
		}
	}

}
