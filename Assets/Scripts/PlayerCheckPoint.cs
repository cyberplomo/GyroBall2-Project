using System.Collections;
using System.Collections.Generic;
using UnityEngine;
	

public class PlayerCheckPoint : MonoBehaviour
{
    public Transform chracter;
    
    private Vector3 spawnPoint;
	
	private Rigidbody rb;

	public float speed = 0;	
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
	
    void Update()
    {	//death area ile bu sorunu çözdüm.S
        //if (chracter.transform.position.y < -0.1f)
        //{
            //chracter.position = spawnPoint;
       // }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("CheckPoint"))
        {
            spawnPoint = other.transform.position;
            
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            //Destroy(gameObject);  
			spawn();
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
            rb.Sleep();

        }
        
    }
	
    private void spawn()
    {
        chracter.position = spawnPoint;
    }
}
