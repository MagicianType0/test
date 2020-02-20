using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Scenchange : MonoBehaviour
{
    // Start is called before the first frame update
     public void Changescene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    // Update is called once per frame
    public void ExitToDekstop()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
