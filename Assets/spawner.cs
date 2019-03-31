using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    GameObject currentEnemy;
    public int enemyNumber = 0;
    public int totalEnemyNumber = 5;
    bool ready = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (currentEnemy == null && enemyNumber < totalEnemyNumber)
        {
            GameObject newEnemy = enemyPrefab;
            newEnemy.transform.position = new Vector3 (Random.Range (-5, 5),8,0);
            currentEnemy = Instantiate(newEnemy);
            enemyNumber += 1;
        }
    }
}
