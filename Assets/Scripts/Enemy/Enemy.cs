using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
using System.Threading;
using Unity.VisualScripting;

public class Enemy : EnemyProjectile
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        FireProjectile();
    }

    protected override void FireProjectile()
    {
        shootCooldown += Time.deltaTime;

        if(shootCooldown > 3)
        {
            Instantiate(enemyProjectile, projectileOffset, Quaternion.identity);
            Debug.Log("Projectile Spawned");

            enemyProjectile.GetComponent<Rigidbody>().AddForce(new Vector3(0.5f, 0, 0));
            Debug.Log("Projectile Moving");

            shootCooldown = 0;
        }

    }
}
