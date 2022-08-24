using UnityEngine;

namespace Peiiiii
{
    /// <summary>
    /// �����t��:�����I���B���������m
    /// </summary>
    public class SystemCoin : MonoBehaviour
    {
        [Header("���𭸦�"), Range(0, 2), SerializeField]
        private float delayFly = 1.5f;
        [Header("����t��"), Range(0, 10), SerializeField]
        private float speed = 3.0f;

        /// <summary>
        /// �����n�e������m
        /// </summary>
        private Transform traCoinFlyTo;
        /// <summary>
        /// �}�l����
        /// </summary>
        private bool startFly;

        private ManageCoin manageCoin;

        private void Awake()
        {
            Physics.IgnoreLayerCollision(6, 3); //�����B�u�]���I��
            Physics.IgnoreLayerCollision(6, 6); //�����B�������I��
            Physics.IgnoreLayerCollision(6, 7); //�����B�Ǫ����I��

            traCoinFlyTo = GameObject.Find("�����n�e������m").transform;
            manageCoin = GameObject.Find("�����޲z").GetComponent<ManageCoin>();

            Invoke("StartFly", delayFly); //����
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

            // ����: �NAB��Ӽƭȧ�X���������w��m
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
