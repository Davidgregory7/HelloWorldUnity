using UnityEngine;

[System.Diagnostics.DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class HelloWorldScript : MonoBehaviour
{
    // Called once when the GameObject is loaded into the scene
    void Start()
    {
        Debug.Log("Hello World from Development Branch!");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
