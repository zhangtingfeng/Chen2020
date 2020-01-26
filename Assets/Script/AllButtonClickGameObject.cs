using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

class AllButtonClickGameObject : MonoBehaviour
{
    public void onclickFuncton(String strMarker)
    {
        switch (strMarker)
        {
            case "JumpStart":
                SceneManager.LoadSceneAsync("Start");
                break;
            case "1":
                break;
            case "2":
                break;
            case "3":
                break;

        }

        Debug.Log(strMarker);
    }
}

