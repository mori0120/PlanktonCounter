using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountUpButton : MonoBehaviour
{
    public Text currNumTex;
    public GameObject nextNum;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        currNumTex.text = count.ToString();
    }

    public void incrementCounter()
    {
        count = System.Int32.Parse(currNumTex.text);
        count++;
        if (count >= 10)
        {
            count = 0;
            if (nextNum != null) nextNum.GetComponent<CountUpButton>().incrementCounter();

        }
        currNumTex.text = count.ToString();
    }

    public void decrementCounter()
    {
        count = System.Int32.Parse(currNumTex.text);
        if (count == 0)
        {
            if (nextNum != null) nextNum.GetComponent<CountUpButton>().decrementCounter();
            count=9;
        }
        else count--;
        currNumTex.text = count.ToString();
    }

    public void setZero()
    {
        count = 0;
        currNumTex.text = count.ToString();
    }
}
