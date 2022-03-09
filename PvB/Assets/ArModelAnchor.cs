using UnityEngine;

public class ArModelAnchor : MonoBehaviour
{
    public static GameObject gameobjectInstance;

    private void Awake()
    {
        gameobjectInstance = gameObject;
    }
}