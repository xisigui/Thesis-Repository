using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameControll : MonoBehaviour
{
    [SerializeField] List<AudioClip> _audioClips;
    public GameObject LevelCompleteDialog;

    public char Letter = 'a';
    
    public int _correctAnswers = 5;
    int _correctClicks;
    
    public static GameControll Instance { get; private set; }

    AudioSource _audioSource;

    void Awake()
    {
        Instance = this;
        _audioSource = GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        LevelCompleteDialog.SetActive(false);
        GenerateBoard();
        UpdateDiplayLetters();
        playLetterAudio();
    }

    void GenerateBoard()
    {
        var clickables = FindObjectsOfType<ClickableLetter>();

        List<char> charsList = new List<char>();

        for (int i = 0; i < _correctAnswers; i++)
            charsList.Add(Letter);

        for (int i = _correctAnswers; i < clickables.Length; i++)
        {
            var chosenLetter = ChooseInvalidRandomLetter();
            charsList.Add(chosenLetter);
        }

        charsList = charsList
            .OrderBy(t => UnityEngine.Random.Range(0, 10000))
            .ToList();

        for (int i = 0; i < clickables.Length; i++)
        {
            clickables[i].SetLetter(charsList[i]);
        }

        FindObjectOfType<RemainingCounterText>().SetRemaining(_correctAnswers - _correctClicks);
    }

    internal void HandleCorrectLetterClick(bool upperCase)
    {       
        playLetterAudio();
        _correctClicks++;
        FindObjectOfType<RemainingCounterText>().SetRemaining(_correctAnswers - _correctClicks);
        if (_correctClicks >= _correctAnswers)
        {
            int clipNumber = Random.Range(1, 4);
            var clips = _audioClips.FirstOrDefault(t => t.name == "Assessment_Complete_" + clipNumber);
            LevelCompleteDialog.SetActive(true);    
            _audioSource.PlayOneShot(clips);
            Debug.Log("Level Complete");
        }
    }

    internal void HandleWrongClick(bool upperCase)
    {
        var clips = _audioClips.FirstOrDefault(t => t.name == "Assessment_Wrong_3");
        _audioSource.PlayOneShot(clips);
    }

    private void MoveToNextLetter()
    {
        Letter++;
        var clip = _audioClips.FirstOrDefault(t => t.name == Letter.ToString());     

        if (clip == null)
            Letter = 'a';
    }

    private void UpdateDiplayLetters()
    {
        foreach (var displayletter in FindObjectsOfType<DisplayLetter>())
        {
            displayletter.SetLetter(Letter);
        }
    }

    private char ChooseInvalidRandomLetter()
    {
        int a = UnityEngine.Random.Range(0, 26);
        var randomLetter = (char)('a' + a);
        while (randomLetter == Letter)
        {
            a = UnityEngine.Random.Range(0, 26);
            randomLetter = (char)('a' + a);
        }

        return randomLetter;
    }    

    public void Continue()
    {
        _correctClicks = 0;
        LevelCompleteDialog.SetActive(false);
        MoveToNextLetter();
        UpdateDiplayLetters();        
        GenerateBoard();
        playLetterAudio();
    }

    private void playLetterAudio()
    {
        var clip = _audioClips.FirstOrDefault(t => t.name == Letter.ToString());
        _audioSource.PlayOneShot(clip);
    }
}