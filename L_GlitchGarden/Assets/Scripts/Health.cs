using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            PlayDeathVFX();
            Destroy(gameObject);
        }
    }

    private void PlayDeathVFX()
    {
        if (!deathVFX) { return; }

        //Some parts have been commented out because the Particle System can handle destruction itself !
        //GameObject = deathVFXObject = Instantiate(deathVFX, transform.position, Quaternion.identity);
        Instantiate(deathVFX, transform.position, Quaternion.identity);
        //Destroy(deathVFXObject, 1f);
    }
}
