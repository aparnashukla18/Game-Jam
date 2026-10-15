using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using JetBrains.Annotations;

public class SecQues : MonoBehaviour
{
    public GameObject SecPanel;
    public GameObject PromptPanel;
    public GameObject firstPanel;
    public TMP_Text questionText;
    public TMP_InputField answerInput;
    public TMP_Text feedbackText;
    public Button submitButton;
    public int QuestionNumber = 0;
    public GameObject level;
    

    private int correctAnswer = 7;

    public string[] Questions =
    {
        "10 - 5 = ?",
         "99 - 76 = ?"

    };
    public int[] answers =
    {
        5,23
    };

    void Start()
    {
        level.SetActive(false);
        SecPanel.SetActive(false);
        //PromptPanel.SetActive(false);
        //firstPanel.SetActive(false);
        ShowQuestion();
    }

    void Update()
    {
        if(SecPanel.activeInHierarchy && (Input.GetKeyDown(KeyCode.Space)))
        {
            AutoFillAnswer();
        }
    }
    void ShowQuestion()
    {
        if(QuestionNumber < Questions.Length)
        {
            questionText.text = Questions[QuestionNumber];
            answerInput.text = "";

            feedbackText.text = "";
           // feedbackText.gameObject.SetActive(false);
        }
    }
    public void AutoFillAnswer()
    {
        if (QuestionNumber >= Questions.Length)
            return;

        answerInput.text = answers[QuestionNumber].ToString();
        answerInput.caretPosition = answerInput.text.Length;
        answerInput.ForceLabelUpdate();
        
    }
    public void checkAnswer()
    {
        int playerAnswer;

        if (!int.TryParse(answerInput.text, out playerAnswer))
        {
            //feedbackText.gameObject.SetActive(true);
            feedbackText.text = "Please enter valid answer";
            feedbackText.color = Color.red;
            return;
        }
        if (playerAnswer == answers[QuestionNumber])
        {
            QuestionNumber++;
            
            if(QuestionNumber >= Questions.Length)
            {
                //feedbackText.gameObject.SetActive(false);
                feedbackText.text = "All answer is correct! ";
                feedbackText.color = Color.green;

                SecPanel.SetActive(false);
                submitButton.gameObject.SetActive(false);
                level.SetActive(true);
               

                return;
            }
            ShowQuestion();

        }
        else
        {
            feedbackText.gameObject.SetActive(true);
            feedbackText.text = " Incorrect Answer";
            feedbackText.color = Color.red;
        }
       
    }
    public void OnAnswerChanged()
    {
        feedbackText.text = "";
        
    }
    public void changePanel()
    {
        PromptPanel.SetActive(false);
        SecPanel.SetActive(true);
    }
    

}
