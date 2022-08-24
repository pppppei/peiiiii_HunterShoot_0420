using UnityEngine;

namespace Peiiiii
{
    /// <summary>
    /// 金幣系統:忽略碰撞、飛到金幣位置
    /// </summary>
    public class SystemCoin : MonoBehaviour
    {
        [Header("延遲飛行"), Range(0, 2), SerializeField]
        private float delayFly = 1.5f;
        [Header("飛行速度"), Range(0, 10), SerializeField]
        private float speed = 3.0f;

        /// <summary>
        /// 金幣要前往的位置
        /// </summary>
        private Transform traCoinFlyTo;
        /// <summary>
        /// 開始飛行
        /// </summary>
        private bool startFly;

        private ManageCoin manageCoin;

        private void Awake()
        {
            Physics.IgnoreLayerCollision(6, 3); //金幣、彈珠略碰撞
            Physics.IgnoreLayerCollision(6, 6); //金幣、金幣略碰撞
            Physics.IgnoreLayerCollision(6, 7); //金幣、怪物略碰撞

            traCoinFlyTo = GameObject.Find("金幣要前往的位置").transform;
            manageCoin = GameObject.Find("金幣管理").GetComponent<ManageCoin>();

            Invoke("StartFly", delayFly); //延遲
        }

        private void Update()
        {
            Fly();
        }

        private void StartFly()
        {
            startFly = true;
        }

        private void Fly()
        {
            if (!startFly) return;

            // 插值: 將AB兩個數值抓出中間的指定位置
            Vector3 traCoin = transform.position;
            Vector3 traCoinTo = traCoinFlyTo.position;

            traCoin = Vector3.Lerp(traCoin, traCoinTo, speed * Time.deltaTime);
            transform.position = traCoin;

            DestroyCoin();
        }

        private void DestroyCoin()
        {
            float dis = Vector3.Distance(transform.position, traCoinFlyTo.position);

            if (dis < 5)
            {
                manageCoin.AddCoinAndUpdateUI();
                Destroy(gameObject);
            }
        }
    }

}
