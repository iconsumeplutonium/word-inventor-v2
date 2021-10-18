using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class WordGenerator : MonoBehaviour
{
    public int syllableLength;
    public TMP_Text text;
    public TMP_Text avgText;
    [HideInInspector]
    public List<int> wordInIndexes = new List<int>();

    public List<string> wordInSyllables = new List<string>();

    public bool autoUpdate;

    public int wordLengths = 0;
    public int buttonPresses;

    private void Start() {
        buttonPresses = 0;
        //Activities();
    }

    //public void CreateWord() {
    //    WordDictionary w = new WordDictionary();
    //    int index;
    //    for (int i = 0; i < wordLength; i++) {
    //        if (i == 0) {
    //            index = Random.Range(0, WordList.words.Length - 1);
    //            w = WordList.words[index];
    //        }

    //        wordInIndexes.Add(w.index);
    //        index = Random.Range(0, w.followingSounds.Count - 1);
    //        w = WordList.words[w.followingSounds[index]];

    //    }
    //}

    public void CreateWordThroughSyllables() {
        for (int i = 0; i < syllableLength - 1; i++) {
            
            if (i == 0) {
                SyllableDictionary sd = WordList.syllables[Random.Range(0, WordList.syllables.Length - 1)];
                int index = Random.Range(0, sd.syllablesWithLetter.Count - 1);
                wordInSyllables.Add(sd.syllablesWithLetter[index]);
            }

            //get the last letter of the previous syllable
            char[] syl = wordInSyllables[wordInSyllables.Count - 1].ToCharArray();
            string lastLetter = syl[syl.Length - 1].ToString();

            //get the associated worddictionary and figure out what letter will come next through rng
            WordDictionary wd = GetWDfromLetter(lastLetter);

            //get random letter from list of following letters
            int nextLetterIndex = wd.followingSounds[Random.Range(0, wd.followingSounds.Count - 1)];
            string nextLetter = WordList.words[nextLetterIndex].sound;

            for (int j = 0; j < WordList.syllables.Length; j++) {
                if (WordList.syllables[j].beginningLetter == nextLetter) {
                    int randIndex = Random.Range(0, WordList.syllables[j].syllablesWithLetter.Count - 1);
                    wordInSyllables.Add(WordList.syllables[j].syllablesWithLetter[randIndex]);

                }

            }            

        }
    }

    public WordDictionary GetWDfromLetter(string letter) {
        for (int i = 0; i < WordList.words.Length; i++) {
            if (WordList.words[i].sound == letter)
                return WordList.words[i];
        }
        return WordList.words[0];
    }

    public void Activities() {
        //wordLength = Random.Range(3, 7);
        text.text = "";
        wordInSyllables.Clear();
        CreateWordThroughSyllables();
        //text.SetText(ConvertIndexWordToString(wordInIndexes));\
        string word = "";
        for (int i = 0; i < wordInSyllables.Count; i++) {
            word += wordInSyllables[i];
        }
        text.text = word;
        buttonPresses++;

        wordLengths += word.Length;
        avgText.text = (wordLengths / buttonPresses).ToString();
    }

    public void IncreaseButtonPresses() {
        buttonPresses++;
    }
}
