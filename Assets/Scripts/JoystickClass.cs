//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class JoystickClass : MonoBehaviour
//{

//    public Vector2 xAxis, YAxis, Point_A, Point_B;
//    public GameObject Cube;
//    //private int xValue, yValue;
//    public Image BtnImage;

//    void Start()
//    {
//        BtnImage = GetComponent<Image>();
//    }


//    void Update()
//    {
//        if (Input.GetMouseButton(0))
//        {
//            //Debug.Log("Mouse Button Clicked");
//            //xAxis = new Vector2(Input.mousePosition.x,0);
//            //YAxis = new Vector2(0, Input.mousePosition.y);
//            Debug.Log(Input.mousePosition.x);
//            Debug.Log(Input.mousePosition.y);
//            Cube.transform.eulerAngles = new Vector3(0, Cube.transform.eulerAngles.y - 1.5f, 0);
//            if (Input.mousePosition.x == -1)
//            {
//                Cube.transform.eulerAngles = new Vector3(0, Cube.transform.eulerAngles.y - 1.5f, 0);
//            }
//        }

//    }
//}
