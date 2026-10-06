using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
public void playGame()
{
    SceneManager.LoadSceneAsync(1);
}
}