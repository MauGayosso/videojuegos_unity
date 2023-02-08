using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class ImageTrackingRecognition : MonoBehaviour
{
    private ARTrackedImageManager _arTrackedImageManager;

    private void Awake() {
        _arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();

    }

    private void OnEnable() {
        _arTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    private void OnDisable() {
        _arTrackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    private void OnImageChanged(ARTrackedImagesChangedEventArgs args) {
        foreach (var trackedImage in args.added) {
            Debug.Log(trackedImage.name);
        }

        foreach (var trackedImage in args.updated) {
            Debug.Log(trackedImage.name);
        }

        foreach (var trackedImage in args.removed) {
            Debug.Log(trackedImage.name);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

}
