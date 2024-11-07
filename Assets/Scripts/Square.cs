using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Square : BaseShape
{
    private string _name = "Square";
    
    public override void GiveFeedback()
    {
        _speachBubbleText.text = "I am " + _name;
    }

    private void OnMouseDown()
    {
        Toggle();
        GiveFeedback();
    }

}
