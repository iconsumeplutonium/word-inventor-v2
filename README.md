# Word Inventor, the Sequel

#### Description

A modified version of my original [WordInventor](https://github.com/iconsumeplutonium/word-inventor) that creates words through combining syllables rather than letters.
Did it warrant its own repository? Maybe not, but I don't care. 😎

#### Data used by the program

![Table of data, adapted from the code](https://cdn.discordapp.com/attachments/690652979036028929/900555561282728008/unknown.png)


The above table is adapted from the data used in the code. 

The first column represents the starting letter for that particular row. The second column contains the various syllables starting with its corresponding letter. This table,
combined with the original table of data from the original WordInventor is use to create words.

#### How it works

   * First, a random syllable is chosen to be the starting syllable of the word
   * The last letter of that syllable is taken and compared against the table of letter data from the original WordInventor.
   * It picks a random letter that can follow after that chosen letter.
   * Finally, it goes back to the syllable table and picks a random syllable starting with that letter
   * This process repeats until it reaches the maximum syllable length. 
   
<p>&nbsp</p>  
   
The following is a visual explanation of the algorithm behind generating a 3-syllable word.

![Diagram](https://cdn.discordapp.com/attachments/690652979036028929/900572129739825192/explanation.jpg)

#### The Project

The project was initially written in version 2020.3.12f1 of the Unity game engine using C#. Just like with the original Word Inventor, I also created a standalone .NET executable that can be run from the desktop. 

In the original program, any word longer than 7 letters would be an unpronouncable
mess of consonants. With the new program, however, there were significant improvements to words between 8 and 14 letters in length.

   * 2 syllables (~5 letters): words are about the same
   * 3 syllables (~8 letters): WI2 is significantly less likely to generate unpronoucable words. By comparison, pronouncable words from WI1 are rare at this length.
   * 4 syllables (~11 letters): WI2 will still have mostly pronounceceable words, while WI1 words are entirely garbage.
   * 5 syllables (~14 letters): Only a few WI2 words will be pronounceable.
   * 6 syllables and up: Nothing is pronounceable across either program.

#### How to Run 
After downloading and unzipping, go into the `InventorExecutable` folder and run `WordInventorTheSequel.exe`.

Note: If Windows Defender blocks it from running then click "Run Anyways" to run the file.
