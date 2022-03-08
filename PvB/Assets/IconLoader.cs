using System.Collections.Generic;
using TextEnum;
using UnityEngine;

public class IconLoader : MonoBehaviour
{
    [SerializeField] float widthOfScroll;
    [SerializeField] List<GameObject> iconImages = new List<GameObject>();
    [SerializeField] List<RectTransform> icons = new List<RectTransform>();

    public void UpdateIcons(ChapterType type)
    {
        icons.Add(Instantiate(iconImages[(int)type], gameObject.transform));
    }

    private float GetLocationForIcon(int index, int totalAmountOfIconsInScrollBar)
    {
        return 0;
    }
}