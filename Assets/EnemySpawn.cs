using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
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
            Vector3 spawnPos = new Vector3(Random.Range(-100, 100), Random.Range(-20,20),100);
            Instantiate(enemy, spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(2.0f);

        }

    }

}