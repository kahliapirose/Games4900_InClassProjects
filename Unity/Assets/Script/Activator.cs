using UnityEngine;

public class Activator : MonoBehaviour
{
    public Greeter HelloActor; 
    void Start()
    {
        Debug.Log(HelloActor.SayHello());
    }


}
