using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Script.DB;

public class SetDBBAK : MonoBehaviour
{



      //private GameObject gamebakObject[10];//有10个元素的学生类对象数组
    // Use this for initialization

    void Awake()
    {
        new ClassReadDB().readAllDB(3);


    }

    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

    }
}
