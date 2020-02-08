using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class QuestionGetter : MonoBehaviour
{
    private const string MATH_Q_PATH = "MathQuestions.csv";
    private const string MATH_A_PATH = "MathAnswers.csv";

    private Hashtable MathQ;
    private Hashtable MathA;

    // Start is called before the first frame update
    void Start()
    {
        MathQ = new Hashtable();
        MathA = new Hashtable();
        
        using (StreamReader reader = new StreamReader(MATH_A_PATH))
        {
            string line;
            int ID;
            line = reader.ReadLine();
            foreach(char c in line.ToCharArray()) {
               
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
