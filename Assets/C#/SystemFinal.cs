using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

namespace Peiiiii
{
    /// <summary>
    /// �C�������t��: �ӧQ�P����
    /// </summary>
    public class SystemFinal : MonoBehaviour
    {
        #region ���
        /// <summary>
        /// �C�������e������
        /// </summary>
        private CanvasGroup groupFinal;
        /// <summary>
        /// �C���������D
        /// </summary>
        private TextMeshProUGUI textTitle;
        /// <summary>
        /// ���s�C��
        /// </summary>
        private Button btnRetry;
        /// <summary>
        /// ���}�C��
        /// </summary>
        private Button btnQuit;
        #endregion

        private void Awake()
        {
            groupFinal = GameObject.Find("�C�������e������").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("�C���������D").GetComponent<TextMeshProUGUI>();
            btnRetry = GameObject.Find("���s�C��").GetComponent<Button>();
            btnQuit = GameObject.Find("���}�C��").GetComponent<Button>();
            btnRetry.onClick.AddListener(Retry);                //���U���s�C�����s�� ����Retry��k
            btnQuit.onClick.AddListener(Quit);                  //���U���}�C�����s�� ����Quit��k

        }

        /// <summary>
        /// ��ܵ����e���ç�s���D
        /// </summary>
        public void ShowFinalAndUpdateTitle(string Title)
        {
            textTitle.text = Title;
            StartCoroutine(ShowFinal());
        }
        
        /// <summary>
        /// ��ܤ���
        /// </summary>
        private IEnumerator ShowFinal()
        {
            for (int i = 0; i < 10; i++)
            {
                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.03f);
            }

            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;
        }

        /// <summary>
        /// ���s�C���\��
        /// </summary>
        private void Retry()
        {
            string nameCurrent = SceneManager.GetActiveScene().name;   //���o��e�����W��
            SceneManager.LoadScene(nameCurrent);                       //�����޲z.���J����(�W��)
        }

        /// <summary>
        /// ���}���s�\��
        /// </summary>
        private void Quit()
        {
            Application.Quit();     //���ε{��.���}(); - �����C���Aunity���L�@��
        }
    }
}
