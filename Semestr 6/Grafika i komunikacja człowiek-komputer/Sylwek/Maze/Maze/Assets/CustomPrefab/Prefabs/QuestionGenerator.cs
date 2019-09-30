using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestionGenerator : MonoBehaviour
{
    public GameObject[] pCounter;
    public Text question;
    public Text answerA;
    public Text answerB;
    public Text answerC;

    questionDB randomQuestion;

    string correctAnswer;
    public string CorrectAnswer
    {
        get { return correctAnswer; }
    }
    int pointsEarned;
    public int PointsEarned
    {
        set { pointsEarned = value; }
        get { return pointsEarned; }
    }

    List<questionDB> questions = new List<questionDB>()
    {
        new questionDB("2+2*2=", new string[3]{"1","6","4"},"6"),
        new questionDB("II wojna światowa zaczęła się: ", new string[]{"1977","1939","1943"},"1939"),
        new questionDB("Stolicą polski jest", new string[]{"Kraków","Poznań","Warszawa"},"Warszawa")
    };
    
    // Start is called before the first frame update
    void Start()
    {
        pCounter = GameObject.FindGameObjectsWithTag("PointCounter");

        Random rnd = new Random();
        int r = Random.Range(0, questions.Count);
        int r3 = Random.Range(0, 2);
        randomQuestion = questions[r];
        question.text = "Pytanie: " + randomQuestion.question;
              
        answerA.text = "A) " + randomQuestion.asnwers[0];
        answerB.text = "B) " + randomQuestion.asnwers[1];
        answerC.text = "C) " + randomQuestion.asnwers[2];

        correctAnswer = randomQuestion.correctAnswer;
        gamePause(true);
    }
    void gamePause(bool pause)
    {
        if (pause)
        {
            Time.timeScale = 0;
            Debug.Log("pause");
        }
        else { Time.timeScale = 1; }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void DestroyObj()
    {
        Destroy(gameObject);
    }
    private void OnDestroy()
    {
        gamePause(false);
    }
}

class questionDB
{
    public string question;
    public string[] asnwers;
    public string correctAnswer;

    public questionDB (string question, string[] answers, string correctAnswer)
    {
        this.question = question;
        this.asnwers = answers;
        this.correctAnswer = correctAnswer;
    }

}
