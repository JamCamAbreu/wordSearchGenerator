using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace WordSearchGenerator {


  enum imprintType {
    across = 0,
    down,
    backwords,
    up
  }

  class WordGrid {

    const char BLANK = '*';
    const int MAX_CHARS_PER_LINE = 65;
    public int gridSize;
    public string indent;
    public List<string> allWordList;
    public List<string> wordList;
    public char[,] letters;
    Random ran;

    public WordGrid(int _dimension) {
      gridSize = _dimension;
      letters = new char[gridSize, gridSize];
      ran = new Random();
      allWordList = new List<string>();
      wordList = new List<string>();

      indent = "    ";
    }

    public void setBlanks() {
      for (int i = 0; i < gridSize; i++) {
        for (int j = 0; j < gridSize; j++) { letters[j, i] = '*'; }
      }
    }

    public void setRandomLetters() {
      for (int i = 0; i < gridSize; i++) {
        for (int j = 0; j < gridSize; j++) {
          if (letters[j, i] == BLANK) {
            letters[j, i] = (char)ran.Next(97, 122);
          }
        }
      }
    }



    public void printWordGrid() {
      string curLine;
      Console.WriteLine("\n");

      // HORIZONTAL LABELS
      /*
      string labels = "";
      for (int n = 0; n < gridSize; n++) {
        if (n % 2 == 0) labels += n;
        if (n % 2 == 0 && n < 10) labels += " ";
        labels += " ";
      }
      Console.WriteLine(indent + "   " + labels);
      */

      for (int i = 0; i < gridSize; i++) {
        curLine = indent;

        // VERTICAL LABELS
        /*
        if (i % 2 == 0) { curLine += i; }
        else { curLine += "  "; }
        if (i % 2 == 0 && i < 10) { curLine += "  "; }
        else { curLine += " "; }
        */

        for (int j = 0; j < gridSize; j++) {
          curLine += letters[i, j];
          curLine += " ";
        }
        Console.WriteLine(curLine);
      }
      Console.WriteLine("\n");
    }


    public void buildWordList(string words, int maxSize) { // need to be separated by one of the delimiters
      char[] delimiters = { ' ', ',', '.', '\t', '\n' };
      string[] wList = words.Split(delimiters);

      foreach (var w in wList) {
        if (w.Length <= maxSize) allWordList.Add(w); // don't add words that can't fit
      }
    }

    public void newWords(int numWords) {
      wordList.Clear(); // first, clear words in list
      string curWord;
      for (int i = 0; i < numWords; i++) {
        int tries = 0;
        do {
          tries++;
          curWord = allWordList[ran.Next(0, allWordList.Count - 1)];
        } while (wordList.Contains(curWord) && tries < 500);
        wordList.Add(curWord);
      }
    }

    public void printWordList() {
      string lineIndent = "        ";
      Console.WriteLine(lineIndent + "Find these words:");
      string w = lineIndent;
      for (int i = 0; i < wordList.Count; i++) {
        if (w.Length >= (MAX_CHARS_PER_LINE - wordList[i].Length)) {
          Console.WriteLine(w);
          w = lineIndent;
        }
        w += wordList[i];
        w += ", ";
      }
      Console.WriteLine(w);
      Console.WriteLine("\n");
    }


    public void imprintWord(string word, bool show) {
      int attempt = 0;
      imprintType t;
      List<int> collisions = new List<int>();
      int spaces = word.Length;
      int startRow, startCol;
      bool isMatch;
      do {

        // reset:
        t = (imprintType)ran.Next(0, 3);
        attempt++;
        collisions.Clear();

        if (show) { Console.Write("Word=" + word + " Attempt: " + attempt + "\t"); }

        // Get width and height of word in grid:
        if (t == imprintType.across || t == imprintType.backwords) {
          startRow = ran.Next(0, gridSize - 1);
          startCol = ran.Next(0, gridSize - spaces - 1);
        }
        else {
          startRow = ran.Next(0, gridSize - spaces - 1);
          startCol = ran.Next(0, gridSize - 1);
        }

        if (show) {
          Console.Write("StartRow=" + startRow + ", startCol=" + startCol + "\t");
          if (t == imprintType.across || t == imprintType.backwords)
            Console.Write("Type: horizontal\n");
          else
            Console.Write("Type: vertical\n");
        }

        // Check characters:
        if (t == imprintType.across || t == imprintType.backwords) {
          for (int i = 0; i < spaces; i++) {
            if (letters[startRow, startCol + i] != BLANK) { collisions.Add(startCol + i); }
          }
        }
        else {
          for (int i = 0; i < spaces; i++) {
            if (letters[startRow + i, startCol] != BLANK) { collisions.Add(startRow + i); }
          }
        }

        // Now collisions contains the COLUMNs (if horizontal) or ROWs (if vertical) of the collisions
        if (collisions.Count == 1) {
          if (show) { Console.WriteLine("Attempting collision"); }
          int checkIndex = 0;
          isMatch = true;
          char cur, target;

          // Check EACH collision, and see if they are the correct letters:
          for (int p = 0; p < collisions.Count; p++) {
            if (t == imprintType.across) {
              cur = word[collisions[p] - startCol];
              target = letters[startRow, collisions[p]];
            }
            else if (t == imprintType.backwords) {
              cur = word[word.Length - 1 - (collisions[p] - startCol)];
              target = letters[startRow, collisions[p]];
            }
            else if (t == imprintType.down) {
              cur = word[collisions[p] - startRow];
              target = letters[collisions[p], startCol];
            }
            else { // up
              cur = word[word.Length - 1 - (collisions[p] - startRow)];
              target = letters[collisions[p], startCol];
            }

            if (cur != target) isMatch = false;
          } // end check collisions


        } // end if collision
        else {
          if (collisions.Count == 0) isMatch = true;
          else isMatch = false;
        }

      } while ((collisions.Count > 0) && (isMatch == false) && (attempt < 300));

      // Imprint the word:
      if (t == imprintType.across) {
        for (int i = 0; i < spaces; i++) { letters[startRow, startCol + i] = word[i]; }
      }
      else if (t == imprintType.backwords) {
        for (int i = 0; i < spaces; i++) { letters[startRow, startCol + i] = word[word.Length - 1 - i]; }
      }
      else if (t == imprintType.down) {
        for (int i = 0; i < spaces; i++) { letters[startRow + i, startCol] = word[i]; }
      }
      else { // UP
        for (int i = 0; i < spaces; i++) { letters[startRow + i, startCol] = word[word.Length - 1 - i]; }
      }

    } // end imprint function



    public void printDashes() {
      string line = "";
      for (int i = 0; i <= MAX_CHARS_PER_LINE; i++) { line += '-'; }
      Console.WriteLine(line + '\n');
    }



    public string getGridString() {
      string retString = "";
      string curLine;
      for (int i = 0; i < gridSize; i++) {
        curLine = indent; // add left margin: the indent
        for (int j = 0; j < gridSize; j++) {
          curLine += letters[i, j];
          curLine += " ";
        }
        retString += curLine + "\n";
      }

      retString += "\n";
      return retString;
    }



    public string getWordListString() {
      string retString = "";

      retString += indent + "Find these words:\n";
      string w = indent;
      for (int i = 0; i < wordList.Count; i++) {
        if (w.Length >= (MAX_CHARS_PER_LINE - wordList[i].Length)) {
          retString += w + "\n";
          w = indent;
        }
        w += wordList[i];
        w += ", ";
      }

      retString += w + "\n";
      return retString;
    }


    public string generatePuzzle(int numWords) {
      string retString = "";
      newWords(numWords);

      setBlanks();
      for (int i = 0; i < wordList.Count; i++) {
        imprintWord(wordList[i], false);
      }
      setRandomLetters();

      retString += getGridString();
      retString += getWordListString();
      return retString;
    }



  } // end class wordgrid



  class Program {

    public static List<string> menu_wordLists = new List<string>();
    public static List<string> menu_dimensions = new List<string>();
    public static List<string> menu_wordLengths = new List<string>();
    public static List<string> menu_numWords = new List<string>();
    public static List<string> menu_numPuzzles = new List<string>();


    public static void buildMenus() {
      menu_wordLists.Add("Thousand Word List");
      menu_wordLists.Add("Hundred Word List");

      menu_dimensions.Add("10 characters");
      menu_dimensions.Add("15 characters");
      menu_dimensions.Add("20 characters");
      menu_dimensions.Add("25 characters");
      menu_dimensions.Add("30 characters");

      menu_wordLengths.Add("4 letters");
      menu_wordLengths.Add("6 letters");
      menu_wordLengths.Add("8 letters");
      menu_wordLengths.Add("10 letters");
      menu_wordLengths.Add("12 letters");

      menu_numWords.Add("5 words");
      menu_numWords.Add("10 words");
      menu_numWords.Add("15 words");
      menu_numWords.Add("20 words");
      menu_numWords.Add("25 words");
      menu_numWords.Add("30 words");

      menu_numPuzzles.Add("1 puzzle");
      menu_numPuzzles.Add("2 puzzles");
      menu_numPuzzles.Add("4 puzzles");
      menu_numPuzzles.Add("8 puzzles");
      menu_numPuzzles.Add("16 puzzles");
      menu_numPuzzles.Add("32 puzzles");
    }


    static public string menuOptions(List<string> options, int numTabs) {
      string tabs = "";
      for (int i = 0; i < numTabs; i++) { tabs += "\t"; }

      string retString = "";
      string curLine;
      for (int j = 0; j < options.Count; j++) {
        curLine = tabs;
        curLine += (j + 1) + ".   ";
        curLine += options[j] + "\n";
        retString += curLine;
      }
      retString += tabs + "Or press escape to exit. Your response: ";
      return retString;
    }


    static public int isNumOrEscape(ConsoleKeyInfo c) {
      if (c.Key == ConsoleKey.D1) return 1;
      else if (c.Key == ConsoleKey.D2) return 2;
      else if (c.Key == ConsoleKey.D3) return 3;
      else if (c.Key == ConsoleKey.D4) return 4;
      else if (c.Key == ConsoleKey.D5) return 5;
      else if (c.Key == ConsoleKey.D6) return 6;
      else if (c.Key == ConsoleKey.D7) return 7;
      else if (c.Key == ConsoleKey.D8) return 8;
      else if (c.Key == ConsoleKey.D9) return 9;
      else if (c.Key == ConsoleKey.Escape) return 0;
      else return -1;
    }

    static public int question(string q) {
      Console.Write(q);
      ConsoleKeyInfo input = Console.ReadKey();
      while (isNumOrEscape(input) == -1) {
        Console.WriteLine("Invalid response. Please choose an option or press escape");
        input = Console.ReadKey();
        Console.Write("\n");
      }

      if (isNumOrEscape(input) == 0) { Environment.Exit(0); }
      return isNumOrEscape(input);
    }


    public static void printLogo() {
      var indent = "           ";
      Console.Write("\n");
      Console.WriteLine(indent + "+---------------------------------------------------+");
      Console.WriteLine(indent + "|   @ ~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~ @   |");
      Console.WriteLine(indent + "| * |   WORD SEARCH GENERATOR                   | * |");
      Console.WriteLine(indent + "| * |                     by James 'Cam' Abreu  | * |");
      Console.WriteLine(indent + "|   @-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~ @   |");
      Console.WriteLine(indent + "+---------------------------------------------------+");
      Console.Write("\n");
    }



    static void Main(string[] args) {
      // Program Prep:
      printLogo();
      buildMenus();
      string curFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      WordGrid wg;
      int answer;
      string folderName = "puzzles "  + DateTime.Now.ToString("yyyy-MM-dd");
      string fullPath = Path.Combine(curFolder, folderName);
      Directory.CreateDirectory(fullPath);

      // Questions:
      answer = question("How many letters wide/long would you like your puzzle?:\n" + menuOptions(menu_dimensions, 1));
      int puzzleSize = 5 + 5 * answer;
      int wordList = question("\n\nPlease choose a word list:\n" + menuOptions(menu_wordLists, 1));
      answer = question("\n\nMaximum possible word size?\n" + menuOptions(menu_wordLengths, 1));
      int wordSize = 2 + answer * 2;
      answer = question("\n\nHow many words will each puzzle contain?\n" + menuOptions(menu_numWords, 1));
      int numWords = answer * 5;
      answer = question("\n\nHow many puzzle files would you like to generate?\n" + menuOptions(menu_numPuzzles, 1));
      int numPuzzles = (int)Math.Pow(2, (answer - 1));

      // Generate Puzzle(s):
      wg = new WordGrid(puzzleSize);
      switch (wordList) {
        case 1: wg.buildWordList(wordSelections.commonHundred, wordSize); break;
        case 2: wg.buildWordList(wordSelections.commonThousand, wordSize); break;
        default: wg.buildWordList(wordSelections.commonHundred, wordSize); break;
      }


      string curPuzzle;
      string fileName;
      string filePath;
      string timeString;
      for (int i = 1; i <= numPuzzles; i++) {
        curPuzzle = wg.generatePuzzle(numWords);
        timeString = DateTime.Now.ToString("hhmmtt") + "-" + DateTime.Now.ToString("ss") + "s-";
        fileName = timeString + "puzzle" + i.ToString() + ".txt";
        filePath = Path.Combine(fullPath, fileName);
        System.IO.File.WriteAllText(@filePath, curPuzzle);
      }

      // Success and Exit:
      Console.Write("\n\n");
      Console.WriteLine("Puzzles generated at the following file location:");
      Console.WriteLine(curFolder);
      Console.WriteLine("Press any key to exit");
      Console.ReadKey();

    } // end main
  } // end program class
} // end WordSearchGenerator namespace

