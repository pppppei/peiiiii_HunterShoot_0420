using UnityEngine;

namespace Peiiiii
{
    /// <summary>
    /// �u�]�t��
    /// 1.���ɶ��S�I��Ǫ��N���U��^��
    /// </summary>
    public class SystemMarble : MonoBehaviour
    {
        [SerializeField]
        private LayerMask layerEnemy;
        [Range(0, 10), SerializeField]
        private float timeRecycle = 5;
        [SerializeField]
        private Vector3 v3SpeedRecycle;

        private float timer;
    }
}
