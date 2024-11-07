using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class BaseShape : MonoBehaviour
{
    public Vector2 offsetPosition = new Vector2(115.0f, 40.0f);
    protected  GameObject _speachBubleRect;
    protected bool isActive = false;
    protected TMP_Text _speachBubbleText;
    private float scaleFactor = 2.0f;
    private float scaleReset = 1.0f;

    public virtual void Toggle()
    {
        if (!isActive) 
        {
            isActive = true;
            Scale(scaleFactor);
        } else 
        {
            isActive = false;
            Scale(scaleReset);
        }
    }
    private void Start()
    {
        _speachBubleRect = GameObject.Find("SpeachBuble");
        _speachBubbleText = _speachBubleRect.GetComponent<TMP_Text>();
    }
    private void Scale(float scale)
    {
        transform.localScale =  new Vector3(scale, scale, scale);
    }

    private void Update() 
    {
        if (_speachBubleRect != null) 
        {
            _speachBubleRect.SetActive(isActive);
        }
        Vector2 screenPoint = Camera.main.WorldToScreenPoint(transform.transform.position);
        _speachBubleRect.GetComponent<RectTransform>().position = screenPoint + (offsetPosition * new Vector2(transform.localScale.x, transform.localScale.y));
    }

    public abstract void GiveFeedback();
}
