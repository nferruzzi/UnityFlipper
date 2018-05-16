using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    [SerializeField]
    private float fakeLoadingTime = 1f;

    public bool isLoading = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    IEnumerator LoadScene() {
        isLoading = true;
        yield return new WaitForSeconds(fakeLoadingTime);
        AsyncOperation operation = SceneManager.LoadSceneAsync("GamePlay");
        while (!operation.isDone) {
            yield return new WaitForSeconds(fakeLoadingTime);
        }
    }

    public void MoveToGame() {
        Debug.Log("Move to game");
        StartCoroutine(LoadScene());
    }
}
