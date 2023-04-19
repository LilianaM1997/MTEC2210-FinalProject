using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public Transform Left;
    public Transform Right;



    private float timePassed;
    private float spawnTime;

    public float minSpawnTime = 1f;
    public float maxSpawnTime = 3f;


    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCoin", 5, 2);

        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);

    }

    public void Spawner()
    {
        float xPos = Random.Range(Left.position.x, Right.position.x);
        float yPos = Left.position.y;

        Vector3 newPos = new Vector3(xPos, yPos, 0);
        print(newPos);
        Instantiate(coin, newPos, Quaternion.identity);

    }
    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed >= spawnTime)
        {
            int randomPrefab = Random.Range(minInclusive: 0, maxExclusive: 3);
            int randomX = Random.Range((int)Left.transform.position.x, (int)Right.transform.position.x);
            if (randomPrefab == 0)
            {
                Instantiate(coin, position: new Vector3(randomX, transform.position.y, 0), Quaternion.identity);
            }
           
            timePassed = 0f;
            spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }

    }
}
