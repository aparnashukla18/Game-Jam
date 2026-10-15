using UnityEngine;
using TMPro;

public class health : MonoBehaviour
{

    public TextMeshProUGUI text;
    public int healthcount = 0;

    private void Update()
    {
        text.text = "Computer Virus files Downloding :- " + healthcount;
    }


    public void Health()
    {
        text.text = "Computer Virus files Downloding :- " + healthcount;
    }
}
