using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public string PlayerName;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("안녕하세요 " + PlayerName); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
