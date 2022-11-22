using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTrigger : MonoBehaviour
{
    public Animator musicAnim;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if (player != null)
        {
            StartCoroutine(ChangeScene());
        }
    }

    IEnumerator ChangeScene() 
    {
        musicAnim.SetTrigger("fadeOut");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Battle");
        Debug.Log("Loaded Battle Scene");

    }
}
