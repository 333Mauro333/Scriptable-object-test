using UnityEngine;


namespace ScriptableObjectTest
{
    [CreateAssetMenu(menuName = "Level Configuration")]
    public class LevelConfiguration : ScriptableObject
    {
        [Header("References")]
        [SerializeField] Vector3[] enemyPositions;
        [SerializeField] GameObject[] prefabEnemies;



        public int GetEnemyAmount()
        {
            return enemyPositions.Length;
        }
        public Vector3[] GetEnemyPositions()
        {
            return enemyPositions;
        }
        public GameObject GenerateEnemy()
        {
            // Retorno una instancia de un prefab del arreglo con posición aleatoria.
            return Instantiate(prefabEnemies[Random.Range(0, prefabEnemies.Length)]);
        }
    }
}
