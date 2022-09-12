using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{

	public int amount = 20;
	public Rigidbody2D rb;
	public GameObject impactEffect;

	// Use this for initialization
	void Start()
	{

	}


	void OnTriggerEnter2D(Collider2D hitInfo)
	{
		PlayerHealth Player = hitInfo.GetComponent<PlayerHealth>();
		if (Player != null)
		{
			Player.Heal(amount);
			Destroy(gameObject);
		}

		Instantiate(impactEffect, transform.position, transform.rotation);

	}

}
