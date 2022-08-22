using UnityEngine;
using UnityEngine.Events;

namespace Peiiiii
{
    /// <summary>
    /// �^�X�t��:���a�μĤH�^�X�޲z
    /// </summary>
    public class SystemTurn : MonoBehaviour
    {
        /// <summary>
        /// �ĤH�^�X
        /// </summary>
        public UnityEvent onTurnEnemy;

        #region ���
        private SystemControl systemControl;
        private SystemSpawn systemSpawn;
        private RecycleArea recycleArea;

        /// <summary>
        /// �u�]�`��
        /// </summary>
        private int totalCountMarble;
        /// <summary>
        /// �Ǫ��P�i�H�Y���u�]�s���`��
        /// </summary>
        private int totalCountEnemyLive;

        /// <summary>
        /// �^���u�]�ƶq
        /// </summary>
        private int totalRecycleMarble;
        #endregion

        private bool canSpawn = true;

        private void Awake()
        {
            systemControl = GameObject.Find("�ӪŤH").GetComponent<SystemControl>();
            systemSpawn = GameObject.Find("�ͦ��Ǫ��t��").GetComponent<SystemSpawn>();
            recycleArea = GameObject.Find("�^���ϰ�").GetComponent<RecycleArea>();

            recycleArea.onRecycle.AddListener(RecycleMarble);

        }

        /// <summary>
        /// �^���u�]
        /// </summary>
        private void RecycleMarble()
        {
            totalCountMarble = systemControl.canShootMarbleTotal;

            totalCountMarble++;
            //print("<color=yellow>�u�]�^���ƶq:" + totalRecycleMarble + "</color>");

            if (totalRecycleMarble == totalCountMarble)
            {
                //print("�^�������A���ĤH�^�X");
                onTurnEnemy.Invoke();
            }
        }

        /// <summary>
        /// ���ʵ�����ͦ��ĤH�P�u�]
        /// </summary>
        public void MoveEndSpawnEnemy()
        {
            if (!canSpawn) return;

            canSpawn = false;
            systemSpawn.SpawnRandomEnemy();
            Invoke("PlayerTurn", 1);
        }

        private void PlayerTurn()
        {
            systemControl.canShootMarble = true;
            canSpawn = true;
            totalRecycleMarble = 0;
        }
    }

}
