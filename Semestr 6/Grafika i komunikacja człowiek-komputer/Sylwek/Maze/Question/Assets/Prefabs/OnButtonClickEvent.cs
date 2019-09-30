using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnButtonClickEvent : MonoBehaviour
{
    public Canvas parent;
    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(checkIsCorrect);
    }
    public void checkIsCorrect()
    {
        string str = gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text;
        if (str.Substring(3, str.Length-3) == parent.GetComponent<QuestionGenerator>().CorrectAnswer)
        {
            parent.GetComponent<QuestionGenerator>().pCounter.GetComponent<PointsCounter>().points += 1;
        }
        parent.GetComponent<QuestionGenerator>().DestroyObj();
    }

   
}
