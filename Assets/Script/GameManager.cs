using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] PlayableDirector playableDirector;
    [SerializeField] Text scoreText = default;
    [SerializeField] Text countText = default;
    [SerializeField] GameObject resultPanel = default;
    int score;
    int count;


    //�J�E���g�J�n�̎����i�R���[�`���j
    //�Q�[���̏I��:�^�C�����C���̏I�������m����i�V�O�i���j
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GameMain());
        
    }

    IEnumerator GameMain()
    {
        yield return new WaitForSeconds(1);
        countText.text = "3";
        yield return new WaitForSeconds(1);
        countText.text = "2";
        yield return new WaitForSeconds(1);
        countText.text = "1";
        yield return new WaitForSeconds(1);
        countText.text = "Go!!";
        yield return new WaitForSeconds(0.5f);
        countText.text = "";
        playableDirector.Play();
    }
    public void AddScore(int point)
    {
        score += point;
        scoreText.text = score.ToString();

    
    }

    public void OnEndEvent()
    {
        Debug.Log("�Q�[���I��");
        resultPanel.SetActive(true);
    }

    public void OnRetry()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
