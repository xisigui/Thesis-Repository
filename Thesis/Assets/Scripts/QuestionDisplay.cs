using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionDisplay : MonoBehaviour
{
    public Question [] questionsList;

    public TextMeshProUGUI questionText;   

    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;

    private TMP_Text btn1Text;
    private TMP_Text btn2Text;
    private TMP_Text btn3Text;
    private TMP_Text btn4Text;

    int rnd;
    // int rndChoice = Enumerable.Range(0, questionsList[rnd].choice.Length).OrderBy(x => rnd.Next()).Take(4).ToList();

    // Start is called before the first frame update
    void Start()
    {
        rnd = Random.Range(0, questionsList.Length);
        // Random rand = new Random();
        // int rndChoice = Enumerable.Range(0,questionsList[rnd].choice.Length).OrderBy(x => rand.Next()).Take(4);
        // rndChoice = Random.Range(0, questionsList[rnd].choice.Length);

        questionText.text = questionsList[rnd].question;

        b1.onClick.AddListener(() => btnClick(btn1Text));
        btn1Text = b1.GetComponentInChildren<TMP_Text>();
        btn1Text.text = questionsList[rnd].choice[UniqueRandomInt(0,questionsList[rnd].choice.Length)];

        b2.onClick.AddListener(() => btnClick(btn1Text));
        btn2Text = b2.GetComponentInChildren<TMP_Text>();
        btn2Text.text = questionsList[rnd].choice[UniqueRandomInt(0,questionsList[rnd].choice.Length)];

        b3.onClick.AddListener(() => btnClick(btn1Text));
        btn3Text = b3.GetComponentInChildren<TMP_Text>();
        btn3Text.text = questionsList[rnd].choice[UniqueRandomInt(0,questionsList[rnd].choice.Length)];

        b4.onClick.AddListener(() => btnClick(btn1Text));
        btn4Text = b4.GetComponentInChildren<TMP_Text>();
        btn4Text.text = questionsList[rnd].choice[UniqueRandomInt(0,questionsList[rnd].choice.Length)];
    }

    List<int> usedValues = new List<int>();
    public int UniqueRandomInt(int min, int max)
    {
        int val = Random.Range(min, max);
        while(usedValues.Contains(val))
        {
            val = Random.Range(min, max);
        }
        return val;
    }

    // Update is called once per frame
    void Update()
    {        
        
    }

    void btnClick(TMP_Text btnText)
    {
        Debug.Log("Correct " + btnText.text);
    }
}
