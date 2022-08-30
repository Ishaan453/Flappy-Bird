using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public static ScoreUpdate instance;
    public static int score=0;
    static Text text;

    //private void Awake()
    //{
    //    score = 0;
    //    if (instance == null)
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}
    private void Start()
    {
        score = 0;
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    public static void ScoreUp()
    {
        score++;
        text.text = score.ToString();
    }
}
