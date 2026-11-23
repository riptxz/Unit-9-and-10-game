using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject enemyProjectile;

    public Vector3 projectileOffset;

    public float shootCooldown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
       
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }

    protected virtual void FireProjectile()
    {
        Instantiate(enemyProjectile);
    }
}
