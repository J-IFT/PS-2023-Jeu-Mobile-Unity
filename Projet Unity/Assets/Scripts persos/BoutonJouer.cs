using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonJouer : MonoBehaviour
{
    // private TextMesh Jouer; // création d'une variable "Jouer"

    // void Start()
    // {
    //     Jouer = GetComponent<TextMesh>(); // Détextion du curseur sur le MeshRenderer du texte
    // }

    // void OnMouseUp()
    // {
    //     SceneManager.LoadScene("Playground"); // Si le clic remonte (OnMouseUp), alors le niveau "jeu1" est chargé
    // }

    // void OnMouseEnter()
    // {
    //     Jouer.color = Color.red; // Si le curseur passe au dessus du texte (OnMouseEnter), alors le MeshRenderer du texte passe au rouge
    // }

    // void OnMouseExit()
    // {
    //     Jouer.color = Color.white; // Si le curseur sort d'au dessus du texte (OnMouseExit), alors le MeshRenderer du texte passe au blanc
    // }

    public void SwitchScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
