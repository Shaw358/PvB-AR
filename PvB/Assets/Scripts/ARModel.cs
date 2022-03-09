using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARModel : MonoBehaviour
{
    [SerializeField] Vector3 rotation;
    [SerializeField] Vector3 offset;

    private void Awake()
    {
        transform.eulerAngles = rotation;
    }

    private void Update()
    {
        transform.position = new Vector3(ArModelAnchor.gameobjectInstance.transform.position.x + offset.x, ArModelAnchor.gameobjectInstance.transform.position.y + offset.y, ArModelAnchor.gameobjectInstance.transform.position.z + offset.z + 2);
    }
}
