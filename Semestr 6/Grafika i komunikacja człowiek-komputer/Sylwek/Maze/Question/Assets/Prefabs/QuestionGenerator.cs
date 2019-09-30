using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestionGenerator : MonoBehaviour
{
    public Canvas pCounter;
    public Text question;
    public Text answerA;
    public Text answerB;
    public Text answerC;
    public Text answerD;

    questionDB randomQuestion;

    string correctAnswer;
    public string CorrectAnswer
    {
        get { return correctAnswer; }
    }

    List<questionDB> questions = new List<questionDB>()
    {
        new questionDB("2+2*2=", new string[3]{"1","6","4"},"6"),
        new questionDB("II wojna światowa zaczęła się: ", new string[]{"1977","1939","1943"},"1939"),
        new questionDB("Stolicą polski jest", new string[]{"Kraków","Poznań","Warszawa"},"Warszawa")
    };


    private List<E> ShuffleList<E>(List<E> inputList)
    {
        List<E> randomList = new List<E>();

        System.Random r = new System.Random();
        int randomIndex = 0;
        while (inputList.Count > 0)
        {
            randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
            randomList.Add(inputList[randomIndex]); //add it to the new, random list
            inputList.RemoveAt(randomIndex); //remove to avoid duplicates
        }

        return randomList; //return the new random list
    }

    // Start is called before the first frame update
    void Start()
    {
        Random rnd = new Random();
        int r = Random.Range(0, questions.Count);
        int r3 = Random.Range(0, 3);

        randomQuestion = questions[r];
        question.text = "Pytanie: " + randomQuestion.question;
              
        answerA.text = "A) " + randomQuestion.asnwers[0];
        answerB.text = "B) " + randomQuestion.asnwers[1];
        answerC.text = "C) " + randomQuestion.asnwers[2];
        answerD.text = "D) " + randomQuestion.asnwers[3];

        correctAnswer = randomQuestion.correctAnswer;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DestroyObj()
    {
        Destroy(gameObject);
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
