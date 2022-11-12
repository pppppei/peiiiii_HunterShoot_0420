using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 進入下一場景關掉BGM
/// </summary>
namespace Peiiiii
{
    public class DontDestroy : MonoBehaviour
    {
        void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }

       void Update()
        {
            if (gameObject.tag == "BGM")
            {
                if (Application.loadedLevelName == "Game")
                {
                    GetComponent<AudioSource>().mute = true;
                }
                else
                {
                    GetComponent<AudioSource>().mute = false;
                }
            }
        }
    }
}
