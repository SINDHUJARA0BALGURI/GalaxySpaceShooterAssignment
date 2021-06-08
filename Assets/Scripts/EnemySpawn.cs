using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemy2;
    PlayerMovement player;



    private void Start()
    {
        StartCoroutine(Spawn());
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-100, 100), Random.Range(-20, 20), 100);
            Instantiate(enemy, spawnPos, Quaternion.identity);

            Vector3 spawnPos2 = new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), 150);
            Instantiate(enemy2, spawnPos2, Quaternion.identity);

            yield return new WaitForSeconds(2.0f);

        }

    }

}

