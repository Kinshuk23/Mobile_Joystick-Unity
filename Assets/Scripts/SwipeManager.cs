using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeManager : MonoBehaviour
{
    public GameObject trail_Prefab;
    GameObject thisTrail;
    Vector3 startPos;
    Ray ray;
    Plane objPlane;
    public List<GameObject> instantiatedObj = new List<GameObject>();

    //public float WidthRatio;

    void Start()
    {
        objPlane = new Plane(Camera.main.transform.forward * -1, this.transform.position);
    }

    void Update()
    {
        if (((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0)))
        {
            //Plane objPlane = new Plane(Camera.main.transform.forward * -1, this.transform.position);
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float rayDistance;
            if (objPlane.Raycast(ray, out rayDistance))
            {
                this.transform.position = ray.GetPoint(rayDistance);
                //this.GetComponent<LineRenderer>();
            }

        }


        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetMouseButtonDown(0))
        {
            thisTrail =  (GameObject) Instantiate(trail_Prefab, this.transform.position, Quaternion.identity,this.transform);
            instantiatedObj.Add(thisTrail);
            Debug.Log(instantiatedObj.Count);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float rayDistance;
            if (objPlane.Raycast(ray, out rayDistance))
            {
                startPos = ray.GetPoint(rayDistance);
            }
        }
        else if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0))
        {
           
           // Debug.Log(instantiatedObj.Capacity);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float rayDistance;
            if (objPlane.Raycast(ray, out rayDistance))
            {
                thisTrail.transform.position = ray.GetPoint(rayDistance);
            }
        }
      /*  else if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
        {
            if (Vector3.Distance(thisTrail.transform.position, startPos) < 0.1)
            {
                Destroy(thisTrail);

                instantiatedObj.RemoveAt(instantiatedObj.Count - 1);
                Debug.Log("Destroyed");
                
            }
        }*/
       
    }

    public void ClearList()
    {
        for (int i = 0; i < instantiatedObj.Count; i++)
        {
            Destroy(instantiatedObj[i]);
        }

        instantiatedObj.Clear();
        Debug.Log(instantiatedObj.Capacity);
    }

    //public void SetLineWidth()
    //{

    //}
}
