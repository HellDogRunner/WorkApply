using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject marine;
    [SerializeField]
    private GameObject bomber;
    [SerializeField]
    private GameObject shooter;
    
    [SerializeField] private EnemyData _data;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(_data.spawnInterval, marine));
        StartCoroutine(spawnEnemy(_data.spawnInterval, bomber));
        StartCoroutine(spawnEnemy(_data.spawnInterval,shooter));

    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-15f, 15), Random.Range(-16f, 16f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
