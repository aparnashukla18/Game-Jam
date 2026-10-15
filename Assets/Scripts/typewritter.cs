using UnityEngine;
using TMPro;
using System.Collections;

public class typewritter : MonoBehaviour
{
   public TMP_Text text;
    public float waittime = 0.05f;
    public string msg = "Your system is hacked ....\r\nNow there's no way going out :) ";
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        StartCoroutine(typetext()); 
        if (text == null)
        {
            Debug.Log("TMP text not found ");
            return;
        }
    }


    IEnumerator typetext()
    {
        text.text = "";

        foreach (char letter in msg)
        {
            text.text += letter;
            yield return new WaitForSeconds(waittime);
        }
    }
}
