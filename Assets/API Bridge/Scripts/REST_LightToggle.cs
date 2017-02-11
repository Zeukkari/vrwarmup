using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Restifizer;
public class REST_LightToggle : MonoBehaviour {

    public RestifizerManager manager;

    // Use this for initialization
    void Start () {
        Debug.Log("Moro");
        manager = GetComponent<RestifizerManager>();
        manager.ResourceAt("services").Get((response) =>
        {
            Debug.Log("Manageri vastaa.");
        });

        Toggle("switch.socket4");

    }

    void Toggle(string entity_id) {
        Hashtable parameters = new Hashtable();
        parameters.Add("entity_id", entity_id);

        manager.ResourceAt("services/switch/toggle").Post(parameters, (response) =>
        {
            Debug.Log("Juu");
            Debug.Log(response.Status);
            Debug.Log(response.GetType());
            Debug.Log(response.ResourceList);
        });
    }
    
    // Update is called once per frame
    void Update () {
    }
}
