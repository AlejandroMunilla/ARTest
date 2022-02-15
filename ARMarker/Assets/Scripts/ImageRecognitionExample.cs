using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class ImageRecognitionExample : MonoBehaviour
{
 //   public RawImage rawimage;
    private ARTrackedImageManager _arTrackedImageManager;
    WebCamTexture webcamTexture;
    Renderer rend;

    IEnumerator Start()
    {

        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);
        rend = transform.Find("Plane").gameObject.GetComponent<Renderer>();
        WebCamTexture camera2 = new WebCamTexture();
        rend.material.mainTexture = camera2;
        camera2.Play();
    }

    private void Awake()
    {
        _arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    /*
    void OnEnable()
    {
        webcamTexture = new WebCamTexture();
        WebCamDevice[] devices = WebCamTexture.devices;
        foreach (WebCamDevice dev in devices)
        {
            Debug.Log(dev.name);
        }
        //    _arTrackedImageManager.trackedImagesChanged += OnImageChanged;
        webcamTexture = new WebCamTexture(WebCamTexture.devices[WebCamTexture.devices.Length - 1].name);
  //      rawimage.texture = webcamTexture;
 //       rawimage.material.mainTexture = webcamTexture;
        webcamTexture.Play();
        

        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }*/


}
