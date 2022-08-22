using UnityEngine;
using System.Collections.Generic;  //��Ƶ��c �M�� List
using System.Linq;                 //�d�߻y��

namespace Peiiiii
{
    /// <summary>
    /// �ͦ��Ǫ��t��
    /// </summary>
    public class SystemSpawn : MonoBehaviour
    {
        #region ���
        //SerializeField �N�p�H������
        [Header("�Ǫ��}�C"), SerializeField]
        private GameObject[] goEnemies;
        [Header("�ͦ���l�ĤG�Ʈy��"), SerializeField]
        private Transform[] traSecondPlace;

        [SerializeField]
        private List<Transform> listSecondPlace = new List<Transform>();

        [Header("�u�]��l"), SerializeField]
        private GameObject goMarble;
        #endregion

        #region �ƥ�
        private void Awake()
        {
            SpawnRandomEnemies();
        }
        #endregion

        #region ��k
        /// <summary>
        /// �ͦ��H���ĤH
        /// </summary>
        private void SpawnRandomEnemies()
        {
            int min = 2;                        //�u�]�B�Ǫ�
            int max = traSecondPlace.Length;

            int randomCount = Random.Range(min, max);
            //print("�H���Ǫ��ƶq:" + randomCount);

            //�M��=�}�C.�ର�M��();
            listSecondPlace = traSecondPlace.ToList();
            //�H������
            System.Random random = new System.Random();
            //�M��=�M�� �� �Ƨ�(�C�ӲM�椺�e => �H���Ƨ�) �ର�M��;
            listSecondPlace = listSecondPlace.OrderBy(x => random.Next()).ToList();

            int sub = traSecondPlace.Length - randomCount;
            //print("������:" + sub);

            //�j�� �R�� �n�����ƶq
            for (int i = 0; i < sub; i++)
            {
                listSecondPlace.RemoveAt(0);
            }

            //�ͦ��Ҧ��Ǫ��P�u�]�@��
            for (int i = 0; i < listSecondPlace.Count; i++)
            {
                if (i == 0)
                {
                    Instantiate(
                        goMarble,
                        listSecondPlace[i].position,
                        Quaternion.identity);
                }
                else
                {
                    //�H���Ǫ�
                    int randomIndex = Random.Range(0, goEnemies.Length);
                    //�ͦ��Ǫ�
                    Instantiate(
                        goEnemies[randomIndex], 
                        listSecondPlace[i].position, 
                        Quaternion.identity);
                }
            }
        }

        #endregion

    }

}

