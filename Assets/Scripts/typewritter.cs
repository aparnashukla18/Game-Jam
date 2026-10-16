using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class typewritter : MonoBehaviour
{
   public TMP_Text text;
    public float waittime = 0.05f;
    public float waitscenechange=1f;
    public string msg = "Your system is hacked ....\r\nNow there's no way going out :) ";
    void Start()
    {
        if (text == null)
        {
            text = GetComponent<TMP_Text>();
        }
        
        if (text == null)
        {
            Debug.Log("TMP text not found ");
            return;
        }
        StartCoroutine(typetext());
    }


    IEnumerator typetext()
    {
        text.text = "";

        foreach (char letter in msg)
        {
            text.text += letter;
            yield return new WaitForSeconds(waittime);
        }
        StartCoroutine(afterwait());
    }

    IEnumerator afterwait()
    {
        yield return new WaitForSeconds(waitscenechange);
        SceneManager.LoadScene(1);
    }

}
