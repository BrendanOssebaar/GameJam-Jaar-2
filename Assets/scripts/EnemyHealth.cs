using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public HealthBar healthBar;
	public int health = 100;

	public GameObject deathEffect;

	void Start()
	{
		healthBar.SetMaxHealth(health);
	}

	public void TakeDamage(int damage)
	{
		health -= damage;
		healthBar.SetHealth(health);
		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		//Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

}
