using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UnityEngine.EventSystems.EventTrigger))]
public class LineOnMouseOver : MonoBehaviour
{
    /// <summary>
    /// 要设置的图集
    /// </summary>
    public Sprite MyOnMouseEntersprit;
    public Sprite MyOnMouseNormalsprit;
    public Sprite MyOnMousePresssprit;
    private int yyyyy=0;
    Image img;
    public Texture2D cursorTexture;
   // Use this for initialization
   void Start()
    {
        img = this.GetComponent<Image>();
        EventTrigger trigger = img.gameObject.GetComponent<EventTrigger>();
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

    private void OnClick(BaseEventData pointData)
    {

        //transform.GetComponent<Image>().sprite = MyOnMousePresssprit;
        //yyyyy++;
        //Debug.Log("Button Clicked. EventTrigger..="+ yyyyy);

       // SceneManager.LoadSceneAsync("DB");
    }

    private void OnMouseEnter(BaseEventData pointData)
    {
        
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        ///更改按钮图片
        transform.GetComponent<Image>().sprite = MyOnMouseEntersprit;

        yyyyy++;
        //Debug.Log("Button Enter. EventTrigger..=" + yyyyy);
    }

    private void OnMouseLeave(BaseEventData pointData)
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        transform.GetComponent<Image>().sprite = MyOnMouseNormalsprit;
        yyyyy++;
        //Debug.Log("Button OnMouseLeave. EventTrigger..=" + yyyyy);
    }
}
