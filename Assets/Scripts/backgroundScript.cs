using UnityEngine;

public class backgroundScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public SpriteRenderer kackendesSchwein;
    void Start()
    {
      kackendesSchwein = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(kackendesSchwein.flipX==true){
        kackendesSchwein.flipX=false;}else{kackendesSchwein.flipX=true;}
        
    }
}
