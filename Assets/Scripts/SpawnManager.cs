using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    private float startDelay = 2f; // Time Interval before the first obstacle is spawned
    private float repeatRate = 2f; // Time Interval between each obstacle spawn

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         InvokeRepeating("SpawnObstacle", startDelay, repeatRate);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
