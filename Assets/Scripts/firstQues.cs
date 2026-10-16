using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class firstQues : MonoBehaviour
{
    public GameObject QuestionPanel;
    public GameObject PromptPanel;
    public GameObject SecPanel;
    public GameObject tryPanel;
    public AiScript aiScript;
    public TMP_Text questionText;
    public TMP_InputField answerInput;
    public TMP_Text feedbackText;
    public Button submitButton;
    public int QuestionNumber = 1;

    private int correctAnswer = 7;

    void Start()
    {
        QuestionPanel.SetActive(true);
        feedbackText.gameObject.SetActive(false);
        PromptPanel.SetActive(false);
        SecPanel.SetActive(false);
        tryPanel.SetActive(false);
    }

    public void CheckAnswer()
    {
        int playerAnswer;
        

        if (!int.TryParse(answerInput.text, out playerAnswer))
        {
            feedbackText.text = "Please enter a valid number.";
            return;
        }
        if(QuestionNumber == 1)
        {
            if (playerAnswer == 7)
            {
                QuestionNumber = 2;
                
                    questionText.text = "9 + 8 = ?";
                    answerInput.text = "";

                    feedbackText.text = "Correct Answer!";
                    feedbackText.color =  Color.green;

                    feedbackText.gameObject.SetActive(true);
                
            }
            else
            {
                feedbackText.gameObject.SetActive(true);
                feedbackText.text = "Incorrect Answer. Try Again!";
                feedbackText.color = Color.red;
            }
        }
        else if(QuestionNumber ==2)
        {
            if(playerAnswer == 17)
            {
                questionText.text = "9 + 8 = ?";
                answerInput.text = "";

                feedbackText.gameObject.SetActive(true);
                feedbackText.text = "Both Answer is correct!!";
                feedbackText.color = Color.green;


                feedbackText.gameObject.SetActive(false);
                tryPanel.SetActive(false);
                QuestionPanel.SetActive(false);
                submitButton.gameObject.SetActive(false);
                PromptPanel.SetActive(true);

                aiScript.openAi();
            }

        }
        else
        {
            feedbackText.gameObject.SetActive(true);
            feedbackText.text = "Incorrect Answer";
            feedbackText.color = Color.red;
        }


        
    }

    public void OnAnswerChanged()
    {
        feedbackText.text = "";
    }
    

    void Update()
    {
       // CheckAnswer();
    }

}
