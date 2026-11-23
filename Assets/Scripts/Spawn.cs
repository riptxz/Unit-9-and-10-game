using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject pathPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Spawn"))
       {
            Debug.Log("Spawned");
            Instantiate(pathPrefab, new Vector3(-3.94f, 29.15256f, 49.34f), Quaternion.identity);
       }
    }
}
