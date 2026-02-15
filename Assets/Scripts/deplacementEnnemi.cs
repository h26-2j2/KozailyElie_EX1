using UnityEngine;

public class deplacementEnnemi : MonoBehaviour
{
    public float vitesseMin; // vitesse minimum pour le random 

    public float vitesseMax; // vitesse maximum pour le random 
    float vitesseY; // création de la variable de vitesse
    public float limite1; // création d'une première limite verticale (qui sera la limite à ne pas franchire)
    
    public float limite2; // création d'une deuxième limite verticale (qui sera celle de départ qui permettra le wrap)

    
    void Start()
    {
        vitesseY =  Random.Range(-vitesseMin, -vitesseMax); // vitesse aléatoire
    }

   
    void Update()
    {
        // fonctione wrap, avec un retour au départ quand une certaine limite verticale est atteinte

        transform.position += new Vector3(0, vitesseY, 0) * Time.deltaTime;

        if(transform.position.y < limite1)
        {
            transform.position = new Vector2(transform.position.x, limite2);
        }
        
    }
}
