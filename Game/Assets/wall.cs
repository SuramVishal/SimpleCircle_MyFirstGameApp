using UnityEngine;
using System.Collections;

public class wall : MonoBehaviour {
	
	
	void OnTriggerEnter2D (Collider2D hitInfo) {
		if (hitInfo.name == "Ball") {
			string wallName = transform.name;
			gm.Score (wallName);
		

		}
	}
}