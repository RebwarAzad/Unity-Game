using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{

    public float StartTime = 60;
    public Text textBox;
    

    void Start()
    {
        textBox.text = StartTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {

if (StartTime>0)
{
    
         StartTime -= Time.deltaTime;
            textBox.text = Mathf.Round(StartTime).ToString();
    
   
}
    }

} //CLASS


