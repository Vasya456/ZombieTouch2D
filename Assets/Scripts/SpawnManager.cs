using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;

    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private GameObject _enemyFastPrefab;
   
    [SerializeField] private GameObject _personPrefab;


    [SerializeField] private float _speedSpawnEnemy = 2.5f;
    [SerializeField] private float _speedSpawnPerson = 2.5f;

    private bool _stopSpawning = false;
    private bool _destroyAll = false;
    private bool isGameOver = false;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        StartCoroutine(SpawnEnemyRoutine());
        StartCoroutine(spawnPersonRoutine());
        StartCoroutine(SpawnEnemyFastRoutine());
    }

    



    void Update()
    {
        
    }

    IEnumerator SpawnEnemyRoutine()
    {

        while (_stopSpawning == false)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(-8f, 8f), 7, 0);
            GameObject newEnemy = Instantiate(_enemyPrefab, posToSpawn, Quaternion.identity);                   
            yield return new WaitForSeconds(_speedSpawnEnemy);


        }

    }

    IEnumerator SpawnEnemyFastRoutine()
    {

        while (_stopSpawning == false)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(-8f, 8f), 7, 0);
            GameObject newEnemy = Instantiate(_enemyFastPrefab, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(_speedSpawnEnemy);


        }

    }

    IEnumerator spawnPersonRoutine() 
    {
        while (_stopSpawning == false)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(-8f, 8f), 7, 0);           
            GameObject newPerson = Instantiate(_personPrefab, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(_speedSpawnPerson);


        }

    }

    


    public void GameOver() 
    {
        _stopSpawning = true;
       
    }
}
