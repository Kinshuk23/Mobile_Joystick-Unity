using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System;


public class SaveImagePNG : MonoBehaviour
{
    public Text PrintText;
    private string toRemove = "/Android/data/com.rams.TMCHHarvester/files";
    string path;

    private void Awake()
    {
        //AndroidPermissionsManager.RequestPermission("android.permission.WRITE_EXTERNAL_STORAGE");

    }

    void Start()
    {
      DirFunction();  
    }

    public void ClickPhoto()
    {
        ScreenCapture.CaptureScreenshot(Application.persistentDataPath + "/Cap.png");
        ScreenCap();
        StartCoroutine(TakeScreenshotAndSave());
    }

    public void DirFunction()
    {
        if (!Directory.Exists("/storage/emulated/0/HarvesterImageCapture"))
        {
            try
            {
                Directory.CreateDirectory("/storage/emulated/0/HarvesterImageCapture");
            }
            catch (Exception e)
            {
               
            }
        }
    }

    public void ScreenCap()
    {
        
            ScreenCapture.CaptureScreenshot("/storage/emulated/0/HarvesterImageCapture" + "RenderImage.png");
            //ScreenCapture.CaptureScreenshot("/RenderImage.png");
    }


    private IEnumerator TakeScreenshotAndSave()
    {
        yield return new WaitForEndOfFrame();

        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();

        // Save the screenshot to Gallery/Photos
        Debug.Log("Permission result: " + NativeGallery.SaveImageToGallery(ss, "GalleryTest", "My img {0}.png"));
        PrintText.text= "Permission result: " + NativeGallery.SaveImageToGallery(ss, "GalleryTest", "My img {0}.png");
        // To avoid memory leaks
        Destroy(ss);
    }
}