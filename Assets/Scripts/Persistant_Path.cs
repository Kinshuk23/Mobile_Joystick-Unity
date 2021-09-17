using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Persistant_Path : MonoBehaviour
{

    public Text text;
    void Update()
    {
        text.text = Application.persistentDataPath;
    }
}
