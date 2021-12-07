using UnityEngine;

public class BadExampleTest : MonoBehaviour
{
    [SerializeField] private int inputSize = 20;

    private void Update()
    {
        // Call a complicated method every frame
        ComplicatedMethodOuter();
    }
    
    private void ComplicatedMethodOuter()
    {
        for (int i = 0; i < inputSize; i++)
        {
            for (int j = 0; j < inputSize; j++)
            {
                Chain1();
            }
        }
    }

    private void Chain1() { Chain2(); }
    private void Chain2() { Chain3(); }
    private void Chain3() { Chain4(); }
    private void Chain4() { return; }
}
