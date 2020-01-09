using UnityEngine;
using System.Collections;
using UnitySteer.Behaviors;

// ----- Low Poly FPS Pack Free Version -----
public class TargetScript : MonoBehaviour {
	//Used to check if the target has been hit
	public bool isHit = false;
	public int destroyDelay = 5;
	private BoxCollider collider;
	
	private void Start()
	{
		collider = gameObject.GetComponent<BoxCollider>();
	}

	private void Update () {
		//If the target is hit
		if (isHit == true) 
		{
			gameObject.GetComponent<Animator>().Play("Z_FallingBack");
			gameObject.GetComponent<SteerToFollow>().enabled = false;
			gameObject.GetComponent<BehaviorManager>().enabled = false;
			gameObject.GetComponent<Biped>().enabled = false;
			collider.size = new Vector3(collider.size.x, 0.01f, collider.size.z);
			collider.center = new Vector3(0, 0, 0);
			Destroy(gameObject, destroyDelay);
		}
	}
}
// ----- Low Poly FPS Pack Free Version -----