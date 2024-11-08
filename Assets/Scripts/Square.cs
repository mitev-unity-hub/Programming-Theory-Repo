using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
public class Square : BaseShape // INHERITANCE
{
    private string _name = "Square";
    
    public override void GiveFeedback()
    {
        _speachBubbleText.text = "I am " + _name + ". Base Object name is: " + BaseObjectName;
    }// ABSTRACTION

    private void OnMouseDown()
    {
        Toggle(); // ABSTRACTION”
        GiveFeedback(); // ABSTRACTION”
    }

}
