using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class WordList {
    public static WordDictionary[] words = new WordDictionary[] {
        new WordDictionary(0, "a", new List<int> {1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29}),
        new WordDictionary(1, "b", new List<int> {0, 4, 7, 8, 11, 14, 17, 20, 24}),
        new WordDictionary(2, "c", new List<int> {0, 4, 7, 8, 10, 11, 14, 17, 20}),
        new WordDictionary(3, "d", new List<int> {0, 4, 7, 8, 14, 17, 20, 22}),
        new WordDictionary(4, "e", new List<int> {0, 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 16, 17, 18, 19, 21, 22, 23, 24, 25, 26, 27, 28, 29}),
        new WordDictionary(5, "f", new List<int> {0, 4, 7, 8, 11, 14, 17, 20}),
        new WordDictionary(6, "g", new List<int> {0, 4, 7, 8, 11, 13, 14, 18, 19, 20, 24}),
        new WordDictionary(7, "h", new List<int> {0, 4, 8, 14, 20, 24}),
        new WordDictionary(8, "i", new List<int> {0, 1, 2, 3, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 22, 23, 24, 25, 26, 27, 28, 29}),
        new WordDictionary(9, "j", new List<int> {0, 4, 7, 8, 11, 14, 17, 20}),
        new WordDictionary(10, "k", new List<int> {0, 4, 7, 8, 11, 13, 14, 17, 20, 24}),
        new WordDictionary(11, "l", new List<int> {0, 4, 7, 8, 14, 20}),
        new WordDictionary(12, "m", new List<int> {0, 4, 7, 8, 14, 20}),
        new WordDictionary(13, "n", new List<int> {0, 3, 4, 6, 7, 8, 14, 18, 19}),
        new WordDictionary(14, "o", new List<int> {0, 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 16, 17, 18, 19, 21, 22, 23, 24, 25, 26, 27, 28, 29}),
        new WordDictionary(15, "p", new List<int> {0, 4, 7, 8, 11, 13, 14, 17, 18, 20, 24}),
        new WordDictionary(16, "q", new List<int> {0, 4, 8, 14, 17, 20}),
        new WordDictionary(17, "r", new List<int> {0, 4, 7, 8, 12, 13, 14, 19, 20, 24, 26, 27, 28, 29}),
        new WordDictionary(18, "s", new List<int> {0, 4, 7, 8, 10, 11, 12, 13, 14, 16, 17, 19, 20, 22, 23}),
        new WordDictionary(19, "t", new List<int> {0, 4, 7, 8, 14, 17, 18, 20, 22, 24, 27}),
        new WordDictionary(20, "u", new List<int> {1, 2, 3, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 22, 23, 24, 25}),
        new WordDictionary(21, "v", new List<int> {0, 4, 7, 8, 11, 14, 20}),
        new WordDictionary(22, "w", new List<int> {0, 4, 7, 8, 14, 17, 20}),
        new WordDictionary(23, "x", new List<int> {0, 2, 3, 8, 15, 19}),
        new WordDictionary(24, "y", new List<int> {0, 1, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 17, 18, 19, 20, 21, 22, 24}),
        new WordDictionary(25, "z", new List<int> {0, 4, 8}),
        new WordDictionary(26, "sh", new List<int> {0, 4, 8, 11, 12, 14, 17, 19, 20}),
        new WordDictionary(27, "ch", new List<int> {0, 4, 8, 11, 12, 14, 17, 20, 24}),
        new WordDictionary(28, "th", new List<int> {0, 4, 8, 11, 14, 17, 20, 24}),
        new WordDictionary(29, "ph", new List<int> {0, 4, 8, 11, 14, 17, 20}),

    };


    //adapted from www.yourlocalunitedway.org/sites/main/files/3-common_syllables_packet.pdf
    public static SyllableDictionary[] syllables = new SyllableDictionary[] {
        new SyllableDictionary("a", new List<string> {"a", "ag", "air", "am", "act", "age", "als", "an", "as", "at", "ate", "au", "ap"}),
        new SyllableDictionary("b", new List<string> {"ba", "be", "bi", "bat", "bet", "bles", "bor", "but", "by"}),
        new SyllableDictionary("c", new List<string> {"cap", "cat", "cen", "can", "car", "cate", "cent", "char", "ci", "cial", "cle", "come", "cu", "cir", "co", "cor", "cul", "cus", "cy"}),
        new SyllableDictionary("d", new List<string> {"da", "day", "der", "ders", "dy", "dan", "den", "dle"}),
        new SyllableDictionary("e", new List<string> {"east", "ef", "ence", "end", "et", "ered", "eve"}),
        new SyllableDictionary("f", new List<string> {"fac", "fin", "fect", "fish", "fix", "for", "form"}),
        new SyllableDictionary("g", new List<string> {"gi", "go", "great", "gen", "gle", "grand"}),
        new SyllableDictionary("h", new List<string> {"har", "head", "heav", "high", "ho", "hunt"}),
        new SyllableDictionary("i", new List<string> {"ies", "in", "ic", "il", "ings", "ion", "is", "ish", "its", "it"}),
        new SyllableDictionary("j", new List<string> {"jo", "jug", "jag", "jil", "jis", "jaw", "jet", "jig", "jog", "jay", "jab", "jar", "jot"}),
        new SyllableDictionary("k", new List<string> {"ket", "kab", "kae", "kaf", "kas", "kat", "kay", "kea", "kef", "keg", "ken", "kep", "kex", "key", "khi", "kid", "kif", "kin", "kip", "kir", "kis", "kit", "koa", "kob", "koi", "kop", "kor", "kos", "kue", "kye"}),
        new SyllableDictionary("l", new List<string> {"lands", "land", "lat", "lead", "lec", "lect", "less", "li", "lin", "lent", "let", "light", "lo", "long", "low", "lu", "ly"}),
        new SyllableDictionary("m", new List<string> {"mag", "mal", "mar", "mair", "main", "man", "mat", "me", "meas", "men", "man", "mi", "min", "mo", "ments", "mil", "mis", "mul", "my"}),
        new SyllableDictionary("n", new List<string> {"nal", "nel", "ness", "new", "near", "ner", "net", "ni", "no", "nore", "nor", "nu"}),
        new SyllableDictionary("o", new List<string> {"oc", "on", "op", "ob", "of", "one", "or", "ous", "out"}),
        new SyllableDictionary("p", new List<string> {"prac", "pen", "play", "ply", "part", "pi", "ples", "point", "port", "pos", "pre", "press", "pres", "pop", "pip"}),
        new SyllableDictionary("q", new List<string> {"qat", "qit", "qu", "qa", "qe", "qua"}),
        new SyllableDictionary("r", new List<string> {"ral", "rec", "ra", "read", "rect", "rep", "ried", "ro", "row", "round"}),
        new SyllableDictionary("s", new List<string> {"sand", "sent", "sa", "sat", "se", "self", "ser", "sat", "sac", "sar", "suc", "set", "side", "sion", "sis", "ship", "sim", "sions", "so", "some", "son", "sons", "stand", "sub", "sun", "south", "su", "sug", "sup", "sur", "sus"}),
        new SyllableDictionary("t", new List<string> {"ta", "tal", "ted", "tem", "tend", "te", "tel", "ten", "the", "tha", "tho", "thu", "thi", "ti", "tic", "ties", "ting", "to", "ton", "tin", "tive", "tom", "tor", "tors", "tra", "tract", "tri", "try", "tures", "tray", "tro", "tu"}),
        new SyllableDictionary("u", new List<string> {"u", "uer", "um", "up", "us"}),
        new SyllableDictionary("v", new List<string> {"va", "var", "vi", "val", "vel", "vid", "vis"}),
        new SyllableDictionary("w", new List<string> {"way", "west", "wil", "won", "writ"}),
        new SyllableDictionary("x", new List<string> {"xi", "x", "xa", "xe", "xo", "xu", "xy"}),
        new SyllableDictionary("y", new List<string> {"yag", "yah", "yak", "yam", "yap", "yar", "yas", "yaw", "yay", "yea", "yeh", "yen", "yep", "yes", "yet", "yew", "yin", "yip", "yob", "yod", "yok", "yom", "yon", "you", "yow", "yuk", "yum", "yup"}),
        new SyllableDictionary("z", new List<string> {"zag", "zap", "zas", "zax", "zed", "zee", "zek", "zen", "zep", "zig", "zin", "zip", "zit", "zoa", "zoo", "zuz"})
    };
}

public struct WordDictionary {

    public int index;
    public string sound;
    public List<int> followingSounds;

    public WordDictionary(int index, string s, List<int> i) {
        this.index = index;
        sound = s;
        followingSounds = i;
    }

}

public struct SyllableDictionary {
    public string beginningLetter;
    public List<string> syllablesWithLetter;

    public SyllableDictionary(string b, List<string> sWL) {
        beginningLetter = b;
        syllablesWithLetter = sWL;
    }
}
