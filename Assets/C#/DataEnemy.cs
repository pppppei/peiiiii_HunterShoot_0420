using UnityEngine;

namespace Peiiiii
{
    //ScriptObject�}���ƪ���:�}�����e�ܦ������Ʀs��bProject��
    //�����f�tCreateAssetMenu
    [CreateAssetMenu(menuName ="Peiiiii/DataEnemy", fileName = "Data Enemy")]
    public class DataEnemy : ScriptableObject
    {
        [Header("��q"), Range(0, 10000)]
        public float hp;
        [Header("�ˮ`"), Range(0, 10000)]
        public float damage;
    }
}
