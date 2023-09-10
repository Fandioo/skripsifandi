using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acakmusuh : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;

    void Start() {
        StartCoroutine(EnemyDrop());
        
    }
    IEnumerator EnemyDrop()
    {
        while (enemyCount < 4)
        {
            xPos = Random.Range( 1, 20);
            zPos = Random.Range( 1, 25);
            Instantiate(theEnemy, new Vector3(xPos, -0 , zPos),Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }
   
    }


