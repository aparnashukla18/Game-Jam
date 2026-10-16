using UnityEngine;
using System.IO;


public class text2 : MonoBehaviour
{
    public int xpoint = 10;
    public RectTransform text1;
    public RectTransform text3;
    public RectTransform text4;
    public double upspeed = 1f;
    public double horizontalspeed = 1f;

    Vector2 movement;

    void Start()
    {
        movement = new Vector2(0.003f, 0.00002f);// horizontalspeed, upspeed);
    }
    void Update()
    {


        text1.anchoredPosition += movement;
        text3.anchoredPosition += movement;
        text4.anchoredPosition += movement;

        if (text1.anchoredPosition.x > 10)
        {

            text1.anchoredPosition = new Vector2(-10, text1.anchoredPosition.y);
        }

        if (text3.anchoredPosition.x > 10)
        {

            text3.anchoredPosition = new Vector2(-10, text3.anchoredPosition.y);
        }
        if (text4.anchoredPosition.x > 10)
        {

            text4.anchoredPosition = new Vector2(-10, text3.anchoredPosition.y);
        }


    }
}
