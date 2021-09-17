using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoyStickInputTest : MonoBehaviour
{
    public FixedJoystick fj;
    public GameObject Model;
    public Slider slider;
    
    void Update()
    {
       /* //Debug.Log(fj.Vertical);
        if (fj.Horizontal > 0.9f)
        {
            //Debug.Log("Right");
            //Cube.transform.eulerAngles = new Vector3(Cube.transform.eulerAngles.x, Cube.transform.eulerAngles.y - 1.5f, 0);
            Cube.transform.Rotate(0, 1, 0);
        }
        else if (fj.Horizontal < -0.9f)
        {
            //Debug.Log("Right");
            //Cube.transform.eulerAngles = new Vector3(0, Cube.transform.eulerAngles.y + 1.5f, 0);
            Cube.transform.Rotate(0, -1, 0);
        }

        if (fj.Vertical < -0.9f)
        {
            //Cube.transform.eulerAngles = new Vector3(0, 0, Cube.transform.eulerAngles.z + 1.5f);
            Cube.transform.Rotate(-1, 0, 0);
        }

        if (fj.Vertical > 0.9f)
        {
            //Cube.transform.eulerAngles = new Vector3(0, 0, Cube.transform.eulerAngles.z - 1.5f);
            Cube.transform.Rotate(1, 0, 0);
        }*/

        Model.transform.Rotate(fj.Vertical*1.2f,fj.Horizontal*1.2f, 0);
    }

    public void ResetFunc()
    {
        Model.transform.position = new Vector3(0,0,0);
        Model.transform.rotation = new Quaternion(0,0,0,0);
        //Camera.main.orthographicSize = 5f;
        Camera.main.transform.position = new Vector3(0, 0, -10);
        slider.value = 0;
    }

    /*public void ScaleingFunc()
    {
        Cube.transform.localScale = new Vector3(slider.value, slider.value, slider.value);
    }*/

}
