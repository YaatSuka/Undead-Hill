using UnityEngine;
using System.Collections;

// ----- Low Poly FPS Pack Free Version -----
public class TargetScript : MonoBehaviour {
	//Used to check if the target has been hit
	public bool isHit = false;
	public int destroyDelay = 5;
	
	private void Update () {
		//If the target is hit
		if (isHit == true) 
		{
			gameObject.GetComponent<Animator>().Play("Z_FallingBack");
			Destroy(gameObject, destroyDelay);
		}
	}
}
// ----- Low Poly FPS Pack Free Version -----