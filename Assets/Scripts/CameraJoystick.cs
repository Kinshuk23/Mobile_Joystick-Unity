using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraJoystick : MonoBehaviour
{

    public Joystick cfj;
    public GameObject camera;
    public Slider slider;
    private Vector3 joystick;
    public float Factor, CamFactor;
    
    void Update()
    {

        CamFactor = 1.2f - (slider.value * 0.012f);
        //camera.transform.Rotate(Cfj.Vertical * 1.2f, Cfj.Horizontal * 1.2f, 0);
        //camera.transform.position = new Vector3(cfj.Horizontal, cfj.Vertical , camera.transform.position.z);
        //camera.transform.position += new Vector3(cfj.Horizontal, cfj.Vertical, 0);
        //if (Camera.main.orthographicSize == 5)
        //{
            camera.transform.position= new Vector3(camera.transform.position.x + cfj.Horizontal * CamFactor, camera.transform.position.y + cfj.Vertical * CamFactor, -10);
        //}

        //else if (Camera.main.orthographicSize != 5)
        //{
        //    //Debug.Log("HI");
        //    //camera.transform.position = new Vector3(cfj.Horizontal - (slider.value * CamFactor) , cfj.Vertical - (slider.value * CamFactor) , 0);
        //  camera.transform.position = new Vector3(cfj.Horizontal - (CamFactor / slider.value), cfj.Vertical - (CamFactor / slider.value), -10); 
        //}
    }

    public void ScalingFunc()
    {
        Camera.main.orthographicSize = 5 - (slider.value * Factor);
    }

}
