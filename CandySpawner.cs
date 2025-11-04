using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CandySpawner : MonoBehaviour
{
    [SerializeField]
    float maxX;

    [SerializeField]
    float yieldSecs;

    public GameObject[] Candies;

    public static CandySpawner instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        StartSpawningCandies();
    }
 
    void Update()
    {

    }

    void CandySpawn()
    {
        int rand = Random.Range(0, Candies.Length);

        float randP = Random.Range(-maxX, maxX);

        Vector3 spawnerPos = new Vector3(randP, transform.position.y, transform.position.z);

        Instantiate(Candies[rand], spawnerPos, transform.rotation);
    }

    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(2f);
        while(true)
        {
            CandySpawn();
            yield return new WaitForSeconds(yieldSecs);
        }
    }

    public void StartSpawningCandies()
    {
        StartCoroutine("SpawnCandies");
    }

    public void StopSpawningCandies()
    {
        print("calling..StopSpawningCandies");
        StopCoroutine("SpawnCandies");
    }
}