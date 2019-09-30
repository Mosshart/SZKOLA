using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PointsCounter : MonoBehaviour
{
    public int points = 0;
    public Text pText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(points.ToString() != pText.text)
        {
            pText.text = points.ToString();
        }
        if(points >9 )
        { SceneManager.LoadScene("mainScene"); }
    }
}
