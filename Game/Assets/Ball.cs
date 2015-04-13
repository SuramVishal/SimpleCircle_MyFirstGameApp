using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	void Start () {
		hi (5);
		GoBall ();
	}
	
	IEnumerator hi(float secs){
		yield return new WaitForSeconds(secs);
	}
	
	
	void GoBall(){
		float rand = Random.Range (0.0f,100.0f);
		if (rand < 50.0f) {
			rigidbody2D.AddForce(new Vector2(30.0f,30.0f));
		} else {
			rigidbody2D.AddForce(new Vector2(-30.0f,-30.0f));
		}
	}
	
	void hasWon(){
		var vel = rigidbody2D.velocity;
		vel.y = 0;
		vel.x = 0;
		rigidbody2D.velocity = vel;
		
		gameObject.transform.position = new Vector2 (0, 0);
	}


	
	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.collider.CompareTag("Player")) {
			Debug.Log("Vel"+rigidbody2D.velocity);
			var velY = rigidbody2D.velocity;
			if(velY.x+velY.y>30)
			{
				velY.x=velY.x/2;
				velY.y=velY.y/2;
			}
			else
			velY.y = (velY.y/2.0f)-(coll.collider.rigidbody2D.velocity.y/3.0f);
			rigidbody2D.velocity = velY;
		}
		else if(coll.collider.CompareTag("rb")){
			var vel = rigidbody2D.velocity;
			vel.y = 0;
			vel.x = 0;
			rigidbody2D.velocity = vel;
			
			gameObject.transform.position = new Vector2 (0, 0);
			
			hi (2.0f);
			GoBall ();}


	}
}