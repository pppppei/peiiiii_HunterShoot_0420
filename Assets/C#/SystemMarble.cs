using UnityEngine;

namespace Peiiiii
{
    /// <summary>
    /// 彈珠系統
    /// 1.長時間沒碰到怪物就往下方回收
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
