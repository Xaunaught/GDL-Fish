using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToHuman : MonoBehaviour {

	public GameObject HumanHit;

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Human")
		{
			HumanHit = other.gameObject;
			Debug.Log("hit the player");
			transform.SetParent(HumanHit.transform);
			rb.isKinematic = true;
		}
	}
}
