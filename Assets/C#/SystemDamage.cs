using UnityEngine;
using TMPro;
using System.Collections;

namespace Peiiiii
{
    /// <summary>
    /// 傷害系統:更新傷害數字、顏色和動態效果
    /// </summary>
    public class SystemDamage : MonoBehaviour
    {
        #region 資料
        /// <summary>
        /// 傷害數字
        /// </summary>
        public float damage;

        [Header("大於100顏色"), SerializeField]
        private Color colorGreaterThan100 = new Color(1.0f, 0.9f, 0.1f);
        [Header("大於200顏色"), SerializeField]
        private Color colorGreaterThan200 = new Color(0.85f, 0.2f, 0.25f);

        private float limitUp;
        private float limitRight;
        private TextMeshProUGUI textDamage;
        #endregion

        //快速選取同一個詞的方式: Alt + Shift + >
        [Header("效果間隔"), SerializeField]
        private float interval = 0.025f;

        private void Start()
        {
            textDamage = GetComponentInChildren<TextMeshProUGUI>();
            textDamage.text = damage.ToString();
            
            if (damage >= 200) textDamage.color = colorGreaterThan200;
            else if (damage >= 100) textDamage.color = colorGreaterThan100;

            limitUp = Random.Range(0.5f, 0.8f);

            int r = Random.Range(0, 2);  //(0,2)只會有0~2之間的數字，不會有2
            if (r == 0) limitRight = -0.3f;
            else if (r == 1) limitRight = 0.3f;

            StartCoroutine(MovementUp());
            StartCoroutine(MovementRight());
            StartCoroutine(ScaleEffect());

        }

        private IEnumerator MovementUp()
        {
            //往上
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.up * limitUp;
                yield return new WaitForSeconds(interval);
            }
            //往下
            for (int i = 0; i < 3; i++)
            {
                transform.position -= transform.up * limitUp;
                yield return new WaitForSeconds(interval);
            }
            //淡出
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
            //放大
            for (int i = 0; i < 5; i++)
            {
                transform.localScale += Vector3.one * 0.001f;
                yield return new WaitForSeconds(interval);
            }
            //縮小
            for (int i = 0; i < 5; i++)
            {
                transform.localScale -= Vector3.one * 0.001f;
                yield return new WaitForSeconds(interval);
            }
        }

    }
}
