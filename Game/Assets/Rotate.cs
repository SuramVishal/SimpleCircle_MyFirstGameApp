using UnityEngine;
using System.Collections;

public class Rotate: MonoBehaviour {
	
	public KeyCode moveleft = KeyCode.LeftArrow;
	public KeyCode moveright = KeyCode.RightArrow;
	
	public float rotateSpeed = 10.0f;
	
	void Update()
	{
		if (Input.GetKey (moveleft)) {
						var dir = rigidbody2D.velocity;
						var angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
						var q = Quaternion.AngleAxis (angle, Vector3.forward);
						transform.rotation = Quaternion.RotateTowards (transform.rotation, q, rotateSpeed * Time.deltaTime);
				} /*else if (Input.GetKey (moveright)) {
						var dir1 = rigidbody2D.velocity;
						var angle1 = Mathf.Atan2 (dir1.y, dir1.x) * Mathf.Rad2Deg;
						var q1 = Quaternion.AngleAxis (angle1, Vector3.forward);
						transform.rotation = Quaternion.RotateTowards (transform.rotation, q1, rotateSpeed * Time.deltaTime);
				}*/
//
	/*void Update(){ 

		if (Input.GetKey (moveleft)) {
			var vel = rigidbody2D.angularVelocity;
			vel.y= speed;
			rigidbody2D.angularVelocity = vel;
		} else if (Input.GetKey (moveright)) {
			var vel = rigidbody2D.angularVelocity;
			vel.y = -1*speed;
			rigidbody2D.angularVelocity = vel;;
		} else if(!Input.anyKey){
			var vel = rigidbody2D.angularVelocity;
			vel.y = 0.0f;
			rigidbody2D.angularVelocity = vel;
		}
		
		var reset = rigidbody2D.angularVelocity;
		reset.= 0;
		rigidbody2D.angularVelocity = reset;*/
		
	}
}