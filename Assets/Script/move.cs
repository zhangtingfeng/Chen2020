using UnityEngine;
using System.Collections;
using System;

public class move : MonoBehaviour
{
    public Camera myCamera;//摄像机

    Vector2 first = Vector2.zero;//记录鼠标点击的初始位置

    Vector2 second = Vector2.zero;//记录鼠标移动时的位置

    bool directorToLeft = false;

    bool directorToRight = false;

    bool directorToUp = false;

    bool directorToDown = false;

    bool dragging = false;//标记是否鼠标在滑动

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool boolGetMouseButton = Input.GetMouseButton(0);
        if (boolGetMouseButton)
        {

            Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {

                //print(hit.collider.gameObject.name);
                //print(hit.collider.gameObject.name);
                if (hit.collider.gameObject.name == "Plane" && dragging == true)
                {

                    Vector3 newPosition = Vector3.zero;

                    float speed = 0;

                    if (directorToLeft == true)
                    {

                        newPosition = new Vector3(0, -1, 0);

                        speed = 15;

                        print("left");

                    }

                    if (directorToRight == true)
                    {

                        speed = 10;

                        newPosition = new Vector3(0, 1, 0);

                        print("right");

                    }

                    if (directorToUp == true)
                    {

                        speed = 15;

                        newPosition = new Vector3(1, 0, 0);

                        print("up");

                    }

                    if (directorToDown == true)
                    {

                        speed = 10;

                        newPosition = new Vector3(-1, 0, 0);

                        print("down");

                    }
                    print(speed);
                    print(newPosition);
                    //GetComponent().transform.RotateAround(model.transform.localPosition, newPosition, speed * Time.deltaTime);

                }

            }

        }


        if (Input.GetKey(KeyCode.UpArrow) || directorToUp)
        {
            directorToUp = false;
            // DateTime ddd = DateTime.Now;

            //Debug.Log("KeyCode.UpArrow" + ddd.ToLongTimeString());
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 7f));
        }

        if (Input.GetKey(KeyCode.DownArrow) || directorToDown)
        {
            directorToDown = false;
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -7f));
        }

        if (Input.GetKey(KeyCode.LeftArrow) || directorToLeft)
        {
            directorToLeft = false;
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-7f, 0, 0));
        }

        if (Input.GetKey(KeyCode.RightArrow) || directorToRight)
        {
            directorToRight = false;
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(7f, 0, 0));
        }

    }

    void StopMove()
    {
        //2D
     //   gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        //3D
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
    }


    void OnGUI()
    {
        ///简单理解就是分线程执行，执行先后顺序是：Awake线程->Start线程->FixedUpdate线程->Update线程->LateUpdate线程->OnGUI线程.
        bool EventTypeMouseDown = Event.current.type == EventType.MouseDown;

        bool EventTypeMouseUp = Event.current.type == EventType.MouseUp;
        if (EventTypeMouseUp) {
            //StopMove();
        }

        if (EventTypeMouseDown)
        {//记录鼠标按下的位置
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            first = Event.current.mousePosition;

        }

        dragging = false;
        bool EventTypeMouseDrag = Event.current.type == EventType.MouseDrag;
        if (EventTypeMouseDrag)
        {//记录鼠标拖动的位置

            dragging = true;

            second = Event.current.mousePosition;

            Vector2 slideDirection = second - first;

            float x = slideDirection.x, y = slideDirection.y;

            if (y < x && y > -x)
            {// right

                directorToLeft = false;

                directorToRight = true;

                directorToUp = false;

                directorToDown = false;

            }
            else if (y > x && y < -x)
            {// left

                directorToLeft = true;

                directorToRight = false;

                directorToUp = false;

                directorToDown = false;

            }
            else if (y > x && y > -x)
            {// up

                directorToLeft = false;

                directorToRight = false;

                directorToUp = false;

                directorToDown = true;

            }
            else
            {// down

                directorToLeft = false;

                directorToRight = false;

                directorToUp = true;

                directorToDown = false;

            }

        }

    }
}
