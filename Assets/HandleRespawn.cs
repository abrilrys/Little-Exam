using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleRespawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Jump.OnDead += Respawn;
    }

    void Respawn() {
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
