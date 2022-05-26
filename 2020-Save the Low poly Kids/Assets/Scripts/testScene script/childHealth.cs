using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class childHealth : MonoBehaviour
{
    public static  float lifeTime;
    public static bool treated = false;
  
  // public static int gamepoint;
    public static bool cantmove = false;
    [SerializeField] GameObject redlight=null;
    [SerializeField] GameObject yellowlight = null;
    [SerializeField] GameObject greenlight = null;
    bool functioncalled;
    [SerializeField] GameObject respawneffect=null;
    bool collided ;
     int lifeValue=200;
    AudioSource audio;

    void Start()
    {
        lifeTime = 25;
      //  gamepoint = 2020;
        cantmove = false;
        greenlight.SetActive(true);
        redlight.SetActive(false);
        yellowlight.SetActive(false);
        functioncalled = false;
        collided = true;
        audio = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime*.5f;
        childMovement.Health -= Time.deltaTime * 2;
        
        if(lifeTime<25 && lifeTime > 15)
        {
           yellowlight.SetActive(true);
            greenlight.SetActive(false);
        }
       
        if (lifeTime < 15&& lifeTime>5)
        {
            Debug.Log("child is infected");
            childMovement.Health -= Time.deltaTime * .75f;
            
          //  if(treated==false)
           // cantmove = true;
            
            redlight.SetActive(true);
            yellowlight.SetActive(false);
        }
        if(lifeTime<5 && lifeTime>0)
        {
            Debug.Log("child is critical help needed");
           // childMovement.Health -= Time.deltaTime ;
        }

        if (lifeTime < 0)
        {
            Debug.Log("child is fully infected");
            Destroy(gameObject);
            //childMovement.Health = 0;
            decresePoint();
           

            Debug.Log("point");
        }
       
        if(particleCollision.collided==true)
            spawneffect();
    }
    void decresePoint()
    {
        if (treated == false && functioncalled==false)
        {
          //  player.gamePoint -= lifeValue;
            functioncalled = true;
            Debug.Log(" not successful treated");
            audio.Play();

        }
       // if (treated == true)
         //   player.gamePoint += 168;
            
    }
    void spawneffect()
    {
        if(collided==false)
        Instantiate(respawneffect, transform.position, transform.rotation);
       // respawneffect.transform.parent = gameObject.transform;
        collided = true;

    }
    private void OnParticleCollision(GameObject other)
    {
       
        
           // childMovement.Health += 30;
            treated = true;
           // lifeTime += 20;
           // player.gamePoint += 170;
            // cantmove = false;
            if(collided==true)
        {
            player.gamePoint += lifeValue;
            Debug.Log("INCREASED");
            collided = false;
        }
            Debug.Log("Treated");
            
        
        
    }
}
