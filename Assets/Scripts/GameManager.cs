using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject Enemy;
    public Transform spawnPoint;

    public float maxSpawnPointX;
    public float enemySpawningWaitingTime;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            Spawn();

            yield return new WaitForSeconds(enemySpawningWaitingTime);
        }
    }

    public void Spawn()
    {
        float randSpawnX = Random.Range(-maxSpawnPointX, maxSpawnPointX);

        Vector3 enemySpawnPoint = spawnPoint.position;
        enemySpawnPoint.x = randSpawnX;

        Instantiate(Enemy, enemySpawnPoint, Quaternion.identity);

    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
