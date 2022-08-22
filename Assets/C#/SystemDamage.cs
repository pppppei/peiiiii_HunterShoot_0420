using UnityEngine;
using TMPro;
using System.Collections;

namespace Peiiiii
{
    /// <summary>
    /// �ˮ`�t��:��s�ˮ`�Ʀr�B�C��M�ʺA�ĪG
    /// </summary>
    public class SystemDamage : MonoBehaviour
    {
        #region ���
        /// <summary>
        /// �ˮ`�Ʀr
        /// </summary>
        public float damage;

        [Header("�j��100�C��"), SerializeField]
        private Color colorGreaterThan100 = new Color(1.0f, 0.9f, 0.1f);
        [Header("�j��200�C��"), SerializeField]
        private Color colorGreaterThan200 = new Color(0.85f, 0.2f, 0.25f);

        private float limitUp;
        private float limitRight;
        private TextMeshProUGUI textDamage;
        #endregion

        //�ֳt����P�@�ӵ����覡: Alt + Shift + >
        [Header("�ĪG���j"), SerializeField]
        private float interval = 0.025f;

        private void Start()
        {
            textDamage = GetComponentInChildren<TextMeshProUGUI>();
            textDamage.text = damage.ToString();
            
            if (damage >= 200) textDamage.color = colorGreaterThan200;
            else if (damage >= 100) textDamage.color = colorGreaterThan100;

            limitUp = Random.Range(0.5f, 0.8f);

            int r = Random.Range(0, 2);  //(0,2)�u�|��0~2�������Ʀr�A���|��2
            if (r == 0) limitRight = -0.3f;
            else if (r == 1) limitRight = 0.3f;

            StartCoroutine(MovementUp());
            StartCoroutine(MovementRight());
            StartCoroutine(ScaleEffect());

        }

        private IEnumerator MovementUp()
        {
            //���W
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.up * limitUp;
                yield return new WaitForSeconds(interval);
            }
            //���U
            for (int i = 0; i < 3; i++)
            {
                transform.position -= transform.up * limitUp;
                yield return new WaitForSeconds(interval);
            }
            //�H�X
            for (int i = 0; i < 10; i++)
            {
                textDamage.color -= new Color(0, 0, 0, 0.1f);
                yield return new WaitForSeconds(interval);
            }
        }

        private IEnumerator MovementRight()
        {
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.right * limitRight;
                yield return new WaitForSeconds(interval);
            }
        }

        private IEnumerator ScaleEffect()
        {
            //��j
            for (int i = 0; i < 5; i++)
            {
                transform.localScale += Vector3.one * 0.001f;
                yield return new WaitForSeconds(interval);
            }
            //�Y�p
            for (int i = 0; i < 5; i++)
            {
                transform.localScale -= Vector3.one * 0.001f;
                yield return new WaitForSeconds(interval);
            }
        }

    }
}
