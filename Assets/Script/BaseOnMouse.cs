using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UnityEngine.EventSystems.EventTrigger))]
public abstract class BaseOnMouse : MonoBehaviour
{
    /// <summary>
    /// 要设置的图集
    /// </summary>
    public Sprite MyOnMouseEntersprit;
    public Sprite MyOnMouseNormalsprit;
    public Sprite MyOnMousePresssprit;
    //private int yyyyy=0;
    Button btn;
    public Texture2D cursorTexture;

    public abstract void setClickButton();   //抽象类
                                        // Use this for initialization
    void Start()
    {
        btn = this.GetComponent<Button>();
        EventTrigger trigger = btn.gameObject.GetComponent<EventTrigger>();
        EventTrigger.Entry entryClick = new EventTrigger.Entry();
        EventTrigger.Entry entryEnter = new EventTrigger.Entry();
        EventTrigger.Entry entryLeave = new EventTrigger.Entry();


        // 鼠标点击事件
        entryClick.eventID = EventTriggerType.PointerClick;
        entryClick.callback.AddListener(OnClick);
        trigger.triggers.Add(entryClick);

        // 鼠标进入事件
        entryEnter.eventID = EventTriggerType.PointerEnter;
        entryEnter.callback.AddListener(OnMouseEnter);
        trigger.triggers.Add(entryEnter);

        //鼠标滑出事件 
        entryLeave.eventID = EventTriggerType.PointerExit;
        entryLeave.callback.AddListener(OnMouseLeave);
        trigger.triggers.Add(entryLeave);


    }

    protected void OnClick(BaseEventData pointData)
    {

        transform.GetComponent<Image>().sprite = MyOnMousePresssprit;
        //yyyyy++;
        //Debug.Log("Button Clicked. EventTrigger..=");
        setClickButton();
        //SceneManager.LoadSceneAsync("DB");
    }

    private void OnMouseEnter(BaseEventData pointData)
    {

        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        ///更改按钮图片
        transform.GetComponent<Image>().sprite = MyOnMouseEntersprit;

        //yyyyy++;
        //Debug.Log("BaseOnMouse Enter. EventTrigger..=" + yyyyy);
    }

    private void OnMouseLeave(BaseEventData pointData)
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        transform.GetComponent<Image>().sprite = MyOnMouseNormalsprit;
        //yyyyy++;
        //Debug.Log("BaseOnMouse OnMouseLeave. EventTrigger..=" + yyyyy);
    }
}
