using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ����MENU�������s
/// </summary>
namespace Peiiiii
{
    public class GM : MonoBehaviour
    {
        [Header("�U�@�ӳ������W��")]
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
