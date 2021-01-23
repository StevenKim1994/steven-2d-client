using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEditor;
using UnityEngine.Rendering;

namespace steven
{
    public class Popup_Option : MonoBehaviour
    {
        void Start()
        {
            transform.position = new Vector3(0, 0, 0); // 화면 중앙으로
            gameObject.SetActive(false); // 비활성화
        }



    }


}
