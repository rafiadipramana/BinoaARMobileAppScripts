using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonTextManager : MonoBehaviour
{
    public List<string> chapterList; 
    public Transform canvas;

    private void Start()
    {
        Debug.Log("Chapter list count: " + chapterList.Count);
        for (var i = 0; i < canvas.childCount; i++)
        {
            var child = canvas.GetChild(i);
            if (!child.CompareTag("ChapterButton")) continue;
            var tmpComponent = child.GetComponentInChildren<TextMeshProUGUI>();
            if (tmpComponent != null)
            {
                tmpComponent.text = chapterList[i];
            }
        }
    }
}

