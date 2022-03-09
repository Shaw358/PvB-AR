using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using TMPro;
using System.Collections;

public class ARManager : MonoBehaviour
{
    ARSession manager;
    [SerializeField] List<GameObject> spawnableModels = new List<GameObject>();

    [SerializeField] GameObject currentObject;

    public void ChangeModel(int modelNumber)
    {
        DestroyImmediate(currentObject);
        currentObject = Instantiate(spawnableModels[modelNumber]);
    }
}
