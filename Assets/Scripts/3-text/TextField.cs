using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an string to the text field.
 */
[RequireComponent(typeof(TextMeshPro))]
public class TextField : MonoBehaviour
{
    private TextMeshPro textField;
    private string txt;
    void Start()
    {
        textField = GetComponent<TextMeshPro>();
    }

    public string GetText()
    {
        return this.txt;
    }

    public void SetText(string newTxt)
    {
        this.txt = newTxt;
        this.textField.text = newTxt.ToString();
    }

}
