using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{

    [SerializeField] float maxX = 7.5f;
    [SerializeField] float timeBeforeStartSpawning = .5f;
    [SerializeField] float spawnInterval = 4f;

    [SerializeField] float candySpeedMultiplier = 0.05f;
    int candyCount = 0;

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

        Instantiate(Candies[randomCandy], this.transform.position, Quaternion.identity);

        candyCount++;

        if(candyCount % 5 == 0 && Candies[randomCandy].GetComponent<Rigidbody2D>().gravityScale <= 1)
        {
            foreach(GameObject candy in Candies)
            {
                candy.GetComponent<Rigidbody2D>().gravityScale += candySpeedMultiplier;
                print(candy.GetComponent<Rigidbody2D>().gravityScale);
            }
        }

        if(spawnInterval % 10 == 0 && spawnInterval >= 0.5f)
        {
            spawnInterval -= 0.5f;
            print(spawnInterval);
        }

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
