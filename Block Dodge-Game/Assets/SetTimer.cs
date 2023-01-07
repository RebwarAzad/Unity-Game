using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTimer : MonoBehaviour
{
    public float StartTime=60;
    public Text textBox;
    // Start is called before the first frame update
    void Start(){
        textBox.text=StartTime.ToString("F2");
    }
  
    // Update is called once per frame
    void Update()
    {
        StartTime+=Time.deltaTime;
        textBox.text=StartTime.ToString("F2");
        

        
    }
}
