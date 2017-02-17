using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  
 public class Fire : MonoBehaviour {
  
    public GameObject spore;
	public float fireSpeed;
	public Transform firePoint;

  
     // Use this for initialization
     void Start () 
     {
        if(spore == null)
        {
          Debug.Log("bullet object is null. Please set a GameObject into the bullet type");
          Debug.Break();
        }
     }
  
     // Update is called once per frame
     void Update () 
     {
        if(Input.GetButtonDown("Fire1"))
		{
			GameObject instance = Instantiate(spore, transform.position, Quaternion.identity);
			//spore = Instantiate(spore, transform.position, Quaternion.identity) as GameObject;
			//spore.SetActive (true);
			//spore.GetComponent<Rigidbody>().AddForce(transform.forward * fireSpeed);
			instance.GetComponent<Rigidbody>().AddForce(transform.forward * fireSpeed);
		}
     }
 }