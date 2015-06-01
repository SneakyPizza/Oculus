using UnityEngine;
using UnityEngine.UI;

public class lmao : MonoBehaviour {

    private Text _ui;
    private bool _lmao;

    void Start()
    {
        _ui = GetComponent<Text>();
        Invoke("StartLmao", 10);
    }

	void FixedUpdate () {
        if(_lmao)
        {
            _ui.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            _ui.fontSize = Random.Range(22, 65);
            _ui.transform.Rotate(new Vector3(0, Random.Range(0f, 4f), Random.Range(0f, 4f)));
        }
	}

    void StartLmao()
    {
        _lmao = true;
    }
}
