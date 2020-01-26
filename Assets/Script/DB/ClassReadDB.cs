using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Assets.Script.DB
{
    class ClassReadDB
    {
        private List<GameObject> dtMenuLineBak = new List<GameObject>();

        public void readAllDB(int intK)
        {
            GameObject mUICanvas = GameObject.Find("TableGameObjectAllText");
            int childCount = mUICanvas.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                GameObject.Destroy(mUICanvas.transform.GetChild(i).gameObject);
            }
            //Debug.Log("child setClickButton..="+ childCount);
            //查找子物体，并且将得到的物体转换成gameobject
            //GameObject objname = mUICanvas.transform.FindChild("ImageOne/TextDB").gameObject;
            //objname.GetComponent<UnityEngine.UI.Text>().text = "dddd";
            //return;

            //var tmpSize = GameObject.Find("TableGameObjectAllText").GetComponent<RectTransform>().rect.height;
            ////GameObject.Find("TableGameObjectAllText").GetComponent<RectTransform>().sizeDelta = new Vector2(445,3000);
            //Debug.Log(tmpSize);
            for (int i = 0; i < intK; i++)
            {
                dtMenuLineBak.Add(null);
            }
            string LineImagebak = "Prefabs/ImageOne1";


            for (int i = 0; i < dtMenuLineBak.Count; i++)
            {
                dtMenuLineBak[i] = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(LineImagebak), new Vector3(0f, 0f, 0), Quaternion.identity);

                dtMenuLineBak[i].transform.SetParent(mUICanvas.transform);
                RectTransform rtr = dtMenuLineBak[i].GetComponent<RectTransform>();
                //定义控件定位点相对基准位置的偏移

                int intoff = 300 - i * 80 - 20;
                if (dtMenuLineBak.Count > 7) intoff = intoff + (dtMenuLineBak.Count - 8) * 40;

                rtr.anchoredPosition = new Vector2(0, intoff);


                GameObject objnamethis = dtMenuLineBak[i].transform.FindChild("OneNum").gameObject;
                objnamethis.GetComponent<UnityEngine.UI.Text>().text = i.ToString();
            }

            //定义控件大小
            RectTransform rtrtable = mUICanvas.GetComponent<RectTransform>();
            rtrtable.sizeDelta = new Vector2(1617, dtMenuLineBak.Count * 80);
        }
    }
}
