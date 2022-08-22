using UnityEngine;
using UnityEngine.Events;

namespace Peiiiii
{
    /// <summary>
    /// 回收區域
    /// </summary>
    public class RecycleArea : MonoBehaviour
    {
        /// <summary>
        /// 回收彈珠的事件
        /// </summary>
        public UnityEvent onRecycle;

        //兩個碰撞器其中一個勾選 Is Trigger 就用 OnTriggerEnter
        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains("彈珠"))
            {
                // print("回收彈珠");
                onRecycle.Invoke();
            }
        }

    }
}
