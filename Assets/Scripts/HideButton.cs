using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideButton : MonoBehaviour
{

    public GameObject fj, cfj, Hidebtn, Unhidebtn, Slider, LineManager, Drawbtn, Clearbtn;
    public GameObject Capturebtn;
    public SwipeManager swipeManager;
    Ray ray;

    public void HideFunc()
    {
        fj.SetActive(false);
        cfj.SetActive(false);
        Hidebtn.SetActive(false);
        Unhidebtn.SetActive(true);
        Slider.SetActive(false);
    }

    public void UnhideFunc()
    {
        fj.SetActive(true);
        cfj.SetActive(true);
        Hidebtn.SetActive(true);
        Unhidebtn.SetActive(false);
        Slider.SetActive(true);
    }

    /*public void lineDrawFunc()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Plane objPlane = new Plane(Camera.main.transform.forward * -1, this.transform.position);
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            float rayDistance;
            if (objPlane.Raycast(ray, out rayDistance))
            {
                this.transform.position = ray.GetPoint(rayDistance);
            }
            
        }
    }*/

    public void DrawFunc()
    {
        LineManager.SetActive(true);
        HideFunc();
        Drawbtn.SetActive(false);
        Clearbtn.SetActive(true);
    }

    public void ClearFunc()
    {
        LineManager.SetActive(false);
        Drawbtn.SetActive(true);
        Clearbtn.SetActive(false);
        swipeManager.ClearList();
    }

}
