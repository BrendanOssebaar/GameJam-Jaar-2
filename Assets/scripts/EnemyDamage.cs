using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

	public int damage2 = 20;
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
			Player.TakeDamage(damage2);
		}

		Instantiate(impactEffect, transform.position, transform.rotation);

	}

}
