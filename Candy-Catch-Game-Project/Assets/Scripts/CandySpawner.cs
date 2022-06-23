using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{

    [SerializeField] float maxX = 7.5f;
    [SerializeField] float timeBeforeStartSpawning = 2f;
    [SerializeField] float spawnInterval = 1f;

    [SerializeField] bool isPlayable = true;

    [SerializeField] GameObject[] Candies;
    void Start()
    {
        StartCoroutine(SpawnCandies());
    }

    void Update()
    {
        StopSpawning();
    }


    private void SpawnCandy()
    {
        int randomCandy = Random.Range(0, Candies.Length);
        float randomXpos = Random.Range(-maxX, maxX);

        this.transform.position = new Vector3(randomXpos, transform.position.y, transform.position.z);

        Instantiate(Candies[randomCandy], this.transform);

    }

    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(timeBeforeStartSpawning);

        while(true)
        {
            SpawnCandy();

            yield return new WaitForSeconds(spawnInterval);
        }
    }
    
    private void StopSpawning()
    {
        if(!isPlayable)
        {
            StopCoroutine(SpawnCandies());
        }
    }
}
