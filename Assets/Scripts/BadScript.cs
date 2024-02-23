using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Accessibility;
using UnityEngine.SceneManagement;

public class BadScript : MonoBehaviour
{
    //cahanges scene
    public void GameScene() { SceneManager.LoadScene(1); }
    public void MenuScene() { SceneManager.LoadScene(0); }
}
