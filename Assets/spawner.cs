using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    GameObject currentEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentEnemy == null)
        {
            GameObject newEnemy = enemyPrefab;
            newEnemy.transform.position = new Vector3 (Random.Range (-7, 7),4,0);
            currentEnemy = Instantiate(newEnemy);
        }
    }
}
