using UnityEngine;

namespace Peiiiii
{
    /// <summary>
    /// �����t��
    /// </summary>
    public class SystemAttack : MonoBehaviour
    {
        [Header("�������"), SerializeField]
        private DataAttack dataAttack;

        /// <summary>
        /// �����ƭ�
        /// </summary>
        public float valueAttack;

        private void Awake()
        {
            //�����ƭ�=�����O+�d��(-�����B�ʡA+�����B��)
            //�Ҧp:�����ƭ�=100+(-10�A10):�d�򸨦b90~110
            valueAttack = dataAttack.attack + 
                Random.Range(-dataAttack.attackFloat, dataAttack.attackFloat);

            valueAttack = Mathf.Floor(valueAttack);
        }
    }
}
