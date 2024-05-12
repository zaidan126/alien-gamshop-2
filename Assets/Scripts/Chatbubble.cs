using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Chatbubble : MonoBehaviour
{
    private Image background;
    private RawImage icon;
    private TextMeshPro text;
    private void Awake()
    {
        background=transform.Find("ImageBackground").GetComponent<Image>();
        icon = transform.Find("Iconw").GetComponent<RawImage>();
        text= transform.Find("Text (TMP)").GetComponent<TextMeshPro>();
    }
    private void Update()
    {
        Setup("Hello Everyone");
    }
    private void Setup(string Text)
    {
        text.SetText(Text);
    }
}
