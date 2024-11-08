using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Triangle : BaseShape
{
    private string _name = "Triangle"; 
    public override void GiveFeedback()
    {
        _speachBubbleText.text = "I am " + _name + ". Base Object name is: " + BaseObjectName;
    }// ABSTRACTION

    private void OnMouseDown()
    {
        Toggle(); // ABSTRACTION
        GiveFeedback(); // ABSTRACTION
    }
}
