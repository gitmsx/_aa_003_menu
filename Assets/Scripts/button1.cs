using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class button1 : MonoBehaviour
{
    
    public TMP_Text TextComponent;
    public Transform ButtonTransform;
    private void Awake()
    {
        string theWord = "Example Example Example Example 111";

        // Get the size of the text for the given string.
        Vector2 textSize = TextComponent.GetPreferredValues(theWord);

        // Set the text
        TextComponent.text = theWord;
        // Adjust the button size / scale.
        ButtonTransform.localScale = textSize;
    }

}


