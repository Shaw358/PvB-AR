using TMPro;
using UnityEngine;

public class DebugScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI MESH;

    private void Update()
    {
        Debug.Log(MESH.GetComponent<RectTransform>().sizeDelta);
    }
}
