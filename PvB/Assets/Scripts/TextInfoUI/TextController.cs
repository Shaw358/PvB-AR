using UnityEngine;
using TextEnum;
using System.Collections.Generic;
using TMPro;
using System.Collections;

public class TextController : MonoBehaviour
{
    [SerializeField] GameObject textWindow;

    [SerializeField] GameObject textPrefab;
    [SerializeField] GameObject firstSpawnPoint;

    [SerializeField] List<TextChapter> chapters = new List<TextChapter>();
    [SerializeField] TextMeshProUGUI chapterTitleText;
    [SerializeField] TextMeshProUGUI mainText;

    #region debugging

    private void Start()
    {
        LoadInText(ChapterType.Panzer);
    }

    #endregion

    public void LoadInText(ChapterType newType)
    {
        TextChapter chapter = chapters.Find(x => x.type == newType);

        if (chapter)
        {
            chapterTitleText.text = chapter.chapterTitle;
            RectTransform trans = mainText.GetComponent<RectTransform>();

            for (int i = 0; i < chapter.textParts.Count; i++)
            {
                mainText.text += chapter.textParts[i].partTitle + "\n\n" + chapter.textParts[i].partText + "\n\n\n";

                Canvas.ForceUpdateCanvases();

                float newSize = (13f * mainText.textInfo.lineCount);
                trans.sizeDelta = new Vector2(trans.sizeDelta.x, newSize);
            }
        }
        else
        {
            return;
        }
    }
}