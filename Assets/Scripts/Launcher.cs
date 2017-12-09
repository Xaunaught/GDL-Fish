using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour {
    private Rigidbody rb;
    
	public GameObject BobblePrefab;

	public float Charge;
	public float Thrust;
	public float ChargeMultipliyer = 10;
	public float MaxForce = 40;
	public bool increasing = true;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Jump"))
		{
			if (increasing)
			{
				Charge += Time.deltaTime * ChargeMultipliyer;
			}
			if (!increasing)
			{
				Charge -= Time.deltaTime * ChargeMultipliyer;
			}
			if(Charge >= MaxForce)
			{
				increasing = false;
			}
			if (Charge < 0)
			{
				increasing = true;
			}
			
		}
		
		if(Input.GetKeyUp("space"))
		{
			GameObject clone = Instantiate(BobblePrefab);
			rb = clone.GetComponent<Rigidbody>();
            rb.useGravity = true;
			rb.AddForce(transform.forward * (Charge * Thrust), ForceMode.Impulse);
			Charge = 0;
		}
	}

    
}
