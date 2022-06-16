using System.Collections.Generic;

using UnityEngine;


namespace ScriptableObjectTest
{
    public class EnemyGenerator : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] LevelConfiguration levelConfiguration;

        List<GameObject> enemyList;


        void Awake()
        {
            enemyList = new List<GameObject>();
        }

        void Start()
        {
            for (int i = 0; i < levelConfiguration.GetEnemyAmount(); i++)
            {
                GameObject newEnemy = levelConfiguration.GenerateEnemy();


                enemyList.Add(newEnemy);
            }

            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].transform.position = levelConfiguration.GetEnemyPositions()[i];
            }
        }
    }
}
