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
        /*for (int i = 0; i < length; i++)
        {
            icons.Add(Instantiate(iconImages[(int)type], gameObject.transform).GetComponent<RectTransform>());
        }*/
    }

    private float GetLocationForIcon(int index, int totalAmountOfIconsInScrollBar)
    {
        

        return 0;
    }

    private void ClearIcons()
    {
        foreach (RectTransform icon in icons)
        {
            icons.Remove(icon);
            Destroy(icon.gameObject);
        }
    }
}