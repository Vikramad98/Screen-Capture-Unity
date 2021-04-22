using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{
    public int count = 0;
    private void Start()
    {
        Debug.Log(Application.persistentDataPath);
    }
    public void screenCapture()
    {
        count++;
        StartCoroutine(TakeScreenShot());
    }
    public IEnumerator TakeScreenShot()
    {
        
        yield return null;
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = false;

        
        yield return new WaitForEndOfFrame();

        
        ScreenCapture.CaptureScreenshot(Application.persistentDataPath + "/WSS" +count+".png");
        Debug.Log("Screenshot Saved!");
        
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = true;
    }
}
