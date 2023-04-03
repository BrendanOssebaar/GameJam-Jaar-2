using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public HealthBar healthBar;
	public int health = 100;
	[SerializeField] private float dropChance = 0f;
	private float m_dropChance = 1f;
	public GameObject deathEffect;

	void Start()
	{
		m_dropChance = 1f / dropChance; // Set Odds here - e.g. 1 in 10 chance
	}

	public void TakeDamage(int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		if(Random.Range(0f, 1f) <= m_dropChance)
        {
			// spawn item
			Instantiate(deathEffect, transform.position, Quaternion.identity);
		}

		
		Destroy(gameObject);
	}
    
	

}
