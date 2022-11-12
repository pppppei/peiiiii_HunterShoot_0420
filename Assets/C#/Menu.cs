using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// option�����]�w
/// </summary>
namespace Peiiiii
{
    public class Menu : MonoBehaviour
    {
        [Header("BGM Prefab")]
        public GameObject BGM;
        [Header("�����n���}��")]
        public bool ControlSound;
        [Header("���n�������s")]
        public Image SoundBottom;
        [Header("�ѪR�פU�Կ��")]
        public TMP_Dropdown ResolutionDropdown;

        void Start()
        {
            if (GameObject.FindGameObjectsWithTag("BGM").Length <= 0)
            {
                Instantiate(BGM);
            }
        }

        public void SoundControl()
        {
            ControlSound = !ControlSound;
            if (ControlSound)
            {
                AudioListener.pause = true;
                SoundBottom.sprite = Resources.Load<Sprite>("soundoff");
            }
            else
            {
                AudioListener.pause = false;
                SoundBottom.sprite = Resources.Load<Sprite>("soundon");
            }
        }

        public void ChangeResolution()
        {
            switch (ResolutionDropdown.value)
            {
                case 0:
                    Screen.SetResolution(480, 800, false);
                    break;
                case 1:
                    Screen.SetResolution(1080, 1920, false);
                    break;
            }
        }
    }
}
