using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public GameObject[] Eggs;

    public float xBound, yBound;
    void Start()
    {
        StartCoroutine(SpawnRandomObject());
    }

    IEnumerator SpawnRandomObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));
        int randomEggs = Random.Range(0, Eggs.Length);

        if(Random.value<= .6f)
        {
            Instantiate(Eggs[randomEggs],
                new Vector2(Random.Range(-xBound, xBound), yBound), Quaternion.identity);
        }

        StartCoroutine(SpawnRandomObject());
    }
}
