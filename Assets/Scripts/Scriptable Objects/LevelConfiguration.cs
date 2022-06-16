using UnityEngine;


namespace ScriptableObjectTest
{
    [CreateAssetMenu(menuName = "Level Configuration")]
    public class LevelConfiguration : ScriptableObject
    {
        [SerializeField] int enemyAmount = 0;
        [SerializeField] int enemyMaxHealth = 0;
        [SerializeField] Vector3[] enemyPositions;



        public int GetEnemyAmount()
        {
            return enemyAmount;
        }
        public int GetEnemyMaxHealth()
        {
            return enemyMaxHealth;
        }
        public Vector3[] GetEnemyPositions()
        {
            return enemyPositions;
        }
    }
}
