using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoutonQuitter : MonoBehaviour
{
    public void QuitScene()
    {
        Application.Quit(); // Si le clic remonte (OnMouseUp), alors l'application se ferme
    }
}
