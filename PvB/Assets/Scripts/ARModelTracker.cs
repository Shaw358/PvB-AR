using TMPro;
using UnityEngine;

public class ARModelTracker : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI mesh;
    static GameObject currentActiveModel;

    public static void UpdateCurrentActiveModel(GameObject newModel)
    {
        if (currentActiveModel)
        {
            DestroyImmediate(currentActiveModel);
        }
        currentActiveModel = newModel;
    }
}