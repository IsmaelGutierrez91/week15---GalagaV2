using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneration : MonoBehaviour
{
    public float enemyGenerationTime;
    float currentTimeTocreateEnemy;
    public GameObject prefabEnemyShip;
    public GameManager gameManager;

    void Update()
    {
        currentTimeTocreateEnemy = currentTimeTocreateEnemy + Time.deltaTime;
        if( currentTimeTocreateEnemy > enemyGenerationTime)
        {
            CreateEnemy();
            currentTimeTocreateEnemy = 0;
        }

    }
    public int GetEnemyPosition()
    {
        int xEnemyPositon = Random.Range(-8, 9);
        return xEnemyPositon;
    }
    void CreateEnemy()
    {
        GameObject Clone = Instantiate(prefabEnemyShip, new Vector2(GetEnemyPosition(), 6.5f), transform.rotation);
        Clone.GetComponent<EnemyMovement>().SetGameManager(gameManager);
        Clone.transform.SetParent(this.transform);
    }
}
