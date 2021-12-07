using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;


public class zneScrip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            DataRecorder.RecordEnteringZone(gameObject.name); // records the name of the zone on a text file that the player enters 

            Analytics.CustomEvent("Entered zone", new Dictionary<string, object> { { "Zone name", gameObject.name } }); // sends the data to unity analytics
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
