using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator1 : MonoBehaviour {

    public GameObject platformPreFab; 
    public GameObject player;
    public GameObject platformLar;
    public int numberOfPlatforms;
    public float levelWidth = 1.0f;
    public float minY = 1.0f;
    public float maxY = 2.0f;


    private int generated = 0;
    float lastplat;

    float lastx;

    float var = 4;
    List<GameObject> plats; 
    List<GameObject> platstop;
    // Start is called before the first frame update
    void Start() {
        lastplat = player.transform.position.y + 6;
        lastx = Random.Range(-levelWidth , levelWidth);
        Vector3 spawnPosition = new Vector3();
        GameObject platf ;
        plats = new List<GameObject>();
        for (int i=0; i<numberOfPlatforms; i++){
            
            //spawnPosition.x = 20f;
            platf = (GameObject)Instantiate(platformPreFab);
            plats.Add(platf);
            platf.SetActive(false);
        }

        GameObject platl ;
        platstop = new List<GameObject>();
        for (int i=0; i<40; i++){
            
            //spawnPosition.x = 20f;
            platl = (GameObject)Instantiate(platformLar);
            platstop.Add(platl);
            platl.SetActive(false);
        }




        InvokeRepeating("startPlat", 1f , .8f);
        
    }

    void startPlat(){
        Vector3 spawnPosition = new Vector3();
        float random = Random.Range(1, 10);
        generated ++;

        lastplat += 3;
        lastx = Random.Range(lastx- var, lastx+var)%levelWidth;
        
        if(random < 2 && generated > 4)
        for(int i = 0; i< platstop.Count; i++){
            if(!platstop[i].activeInHierarchy){
                platstop[i].SetActive(true);
                

                spawnPosition.y = lastplat;
                spawnPosition.x = lastx;
                platstop[i].transform.localPosition = spawnPosition;
                //plats[i].transform.localRotation = transform.localPosition;
                break;
            }

        }
        else
        for(int i = 0; i< plats.Count; i++){
            if(!plats[i].activeInHierarchy){
                plats[i].SetActive(true);
                

                spawnPosition.y = lastplat;
                spawnPosition.x = lastx;
                plats[i].transform.localPosition = spawnPosition;
                //plats[i].transform.localRotation = transform.localPosition;
                break;
            }

        }

        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
