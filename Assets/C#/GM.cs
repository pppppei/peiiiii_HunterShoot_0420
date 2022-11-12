using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 控制MENU介面按鈕
/// </summary>
namespace Peiiiii
{
    public class GM : MonoBehaviour
    {
        [Header("下一個場景的名稱")]
        public string Name;

        public void NextScene()
        {
            Application.LoadLevel(Name);
        }

        public void Quit()
        {
            Application.Quit();
        }
    }
}
