using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
  public void PlayAgain(){
     SceneManager.LoadScene("MainLevel");
}
}
