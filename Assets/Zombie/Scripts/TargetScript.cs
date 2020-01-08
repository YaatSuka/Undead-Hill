using UnityEngine;
using System.Collections;
using UnitySteer.Behaviors;

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
			gameObject.GetComponent<SteerToFollow>().enabled = false;
			gameObject.GetComponent<BehaviorManager>().enabled = false;
			gameObject.GetComponent<Biped>().enabled = false;
			Destroy(gameObject, destroyDelay);
		}
	}
}
// ----- Low Poly FPS Pack Free Version -----