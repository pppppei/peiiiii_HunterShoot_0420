using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

namespace Peiiiii
{
    /// <summary>
    /// 遊戲結束系統: 勝利與失敗
    /// </summary>
    public class SystemFinal : MonoBehaviour
    {
        #region 資料
        /// <summary>
        /// 遊戲結束畫面底圖
        /// </summary>
        private CanvasGroup groupFinal;
        /// <summary>
        /// 遊戲結束標題
        /// </summary>
        private TextMeshProUGUI textTitle;
        /// <summary>
        /// 重新遊戲
        /// </summary>
        private Button btnRetry;
        /// <summary>
        /// 離開遊戲
        /// </summary>
        private Button btnQuit;
        #endregion

        private void Awake()
        {
            groupFinal = GameObject.Find("遊戲結束畫面底圖").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("遊戲結束標題").GetComponent<TextMeshProUGUI>();
            btnRetry = GameObject.Find("重新遊戲").GetComponent<Button>();
            btnQuit = GameObject.Find("離開遊戲").GetComponent<Button>();
            btnRetry.onClick.AddListener(Retry);                //按下重新遊戲按鈕後 執行Retry方法
            btnQuit.onClick.AddListener(Quit);                  //按下離開遊戲按鈕後 執行Quit方法

        }

        /// <summary>
        /// 顯示結束畫面並更新標題
        /// </summary>
        public void ShowFinalAndUpdateTitle(string Title)
        {
            textTitle.text = Title;
            StartCoroutine(ShowFinal());
        }
        
        /// <summary>
        /// 顯示介面
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
        /// 重新遊戲功能
        /// </summary>
        private void Retry()
        {
            string nameCurrent = SceneManager.GetActiveScene().name;   //取得當前場景名稱
            SceneManager.LoadScene(nameCurrent);                       //場景管理.載入場景(名稱)
        }

        /// <summary>
        /// 離開按鈕功能
        /// </summary>
        private void Quit()
        {
            Application.Quit();     //應用程式.離開(); - 關閉遊戲，unity內無作用
        }
    }
}
