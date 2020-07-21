using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    public GameObject EnemyDestroyEffect;
   // public GameObject HealthFollowParticle;

    void OnTriggerEnter2D(Collider2D col)
    {
		if (col.gameObject.tag == "SwordAttackPoint")
		{
			 SoundEffect.PlaySound("enemydeath");
			 Instantiate(EnemyDestroyEffect, transform.position, Quaternion.identity);
			 Destroy(gameObject);
		}
        if(col.gameObject.tag == "Bullet"  ) //|| col.gameObject.tag == "Player"
        {
            SoundEffect.PlaySound("enemydeath");
            Instantiate(EnemyDestroyEffect, transform.position, Quaternion.identity);
           // Instantiate(HealthFollowParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
