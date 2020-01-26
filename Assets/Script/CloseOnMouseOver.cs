


using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections.Generic;

public class CloseOnMouseOver : BaseOnMouse
{


    public override void setClickButton()
    {
        Application.Quit();
    }




}

