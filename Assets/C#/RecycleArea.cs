using UnityEngine;
using UnityEngine.Events;

namespace Peiiiii
{
    /// <summary>
    /// �^���ϰ�
    /// </summary>
    public class RecycleArea : MonoBehaviour
    {
        /// <summary>
        /// �^���u�]���ƥ�
        /// </summary>
        public UnityEvent onRecycle;

        //��ӸI�����䤤�@�ӤĿ� Is Trigger �N�� OnTriggerEnter
        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains("�u�]"))
            {
                // print("�^���u�]");
                onRecycle.Invoke();
            }
        }

    }
}
