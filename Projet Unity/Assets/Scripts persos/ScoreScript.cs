using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
   
    public GUIStyle style;
    public static int scoreValue = 0;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score (golems tués): " + scoreValue;
    }

    void OnGUI () {
        
        // Si le score atteint 5, afficher un bouton
        if (scoreValue >= 5) {
            if (GUI.Button(new Rect(60, 60, 300, 50), "Niveau suivant")) {
                // Action à effectuer lorsque le bouton est cliqué
                // Par exemple, charger une nouvelle scène
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
