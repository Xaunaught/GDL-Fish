using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour {
    private Rigidbody rb;
    public float Thrust;
    public GameObject HumanHit;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space"))
        {
            rb.useGravity = true;
            rb.AddForce(transform.forward * Thrust, ForceMode.Impulse);
        }
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
