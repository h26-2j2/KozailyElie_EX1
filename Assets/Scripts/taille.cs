using UnityEngine;

public class taille : MonoBehaviour
{


     public float amplitude = 0.5f; //création de la variable d'amplitude 
     public float vitesse = 2f; //rapidité du changement de taille
     float baseScale = 1f; // taille de départ 
 



   
    void Start()
    {
    
    }

   
    void Update()
    {
        // changement de la taille à partir de calcul mathématique
        float scale = baseScale + Mathf.Sin(Time.time * vitesse) * amplitude; //recherche unity pour mieux comprendre la fonction sinus
        transform.localScale = new Vector3(scale, scale, scale);
       
    }
}
