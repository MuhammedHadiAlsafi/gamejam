using UnityEngine;
using UnityEngine.SceneManagement;

public class go : MonoBehaviour
{
    public static void scan(string sce){
        SceneManager.LoadScene(sce);
    }
}
