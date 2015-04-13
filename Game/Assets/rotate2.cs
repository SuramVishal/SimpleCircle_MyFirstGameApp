using UnityEngine;
using System.Collections;

public class rotate2 : MonoBehaviour {


	public KeyCode moveleft = KeyCode.LeftArrow;
	public KeyCode moveright = KeyCode.RightArrow;

	void Update ()
	{
		if (Input.GetKey (moveleft)) {
						rigidbody2D.transform.Rotate (0, 0, 100 * Time.deltaTime);
				}  if (Input.GetKey (moveright)) {
			rigidbody2D.transform.Rotate (0, 0, -100 * Time.deltaTime);
				}
			else
			rigidbody2D.transform.Rotate (0, 0,0);
	}

}


