using System.Collections.Generic;

using UnityEngine;


namespace ScriptableObjectTest
{
    public class EnemyGenerator : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] LevelConfiguration levelConfiguration;
        [SerializeField] GameObject prefabEnemy = null;

        List<GameObject> enemyList;



        void Awake()
        {
            enemyList = new List<GameObject>();
        }

        void Start()
        {
            for (int i = 0; i < levelConfiguration.GetEnemyAmount(); i++)
            {
                GameObject newEnemy = Instantiate(prefabEnemy);


                enemyList.Add(newEnemy);
            }

            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].transform.position = levelConfiguration.GetEnemyPositions()[i];
            }
        }


        void Update()
        {

        }
    }
}
