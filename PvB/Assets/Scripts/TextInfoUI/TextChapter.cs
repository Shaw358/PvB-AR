using System.Collections.Generic;
using UnityEngine;
using TextEnum;

[CreateAssetMenu(fileName = "TextChapter", menuName = "Text ScriptableObjects/TextChapter", order = 1)]
public class TextChapter : ScriptableObject
{
    public string chapterTitle;
    public List<TextPart> textParts = new List<TextPart>();
    public ChapterType type;
}