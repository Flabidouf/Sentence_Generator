// See https://aka.ms/new-console-template for more information

static string ObtenirElementAleatoire(string[] t)
{
    Random rand = new Random();
    int i = rand.Next(t.Length);
    return t[i];
}



var sujets = new string[]
{
    "Un lapin",
    "Une grand-mère",
    "Un garçon",
    "Une fée",
    "Johnny",
    "Un chat",
    "Une cadillac",
    "Johnny dans sa cadillac"
};

var verbes = new string[]
{
    "mange",
    "discute avec",
    "se demande si",
    "regarde",
    "va vers",
    "écrase",
    "momifie",
    "avale",
    "se suspend à",
    "se rend à"
};

var complements = new string[]
{
    "un arbre",
    "le soleil",
    "un poteau",
    "une poutine",
    "la lune",
    "le gant de MJ"
};


const int NB_PHRASES = 100;
var phrasesUniques = new List<string>();
int doublonsEvites = 0;


while(phrasesUniques.Count < 100)
{
    var sujet = ObtenirElementAleatoire(sujets);
    var verbe = ObtenirElementAleatoire(verbes);
    var complement = ObtenirElementAleatoire(complements);
    
    var phrase = sujet + " " + verbe + " " + complement;

    phrase = phrase.Replace("à le", "au"); // .Replace an old value with a new one. 

    if (!phrasesUniques.Contains(phrase)) // Check si une phrase existe déjà. Si non, on l'ajoute à phrasesUniques.
                                          // Si oui, on incrémente la variable doublonsEvites
    {
        phrasesUniques.Add(phrase);
    }
    else
    {
        doublonsEvites++;
    }
    
}

Console.WriteLine("Nombre de phrases uniques = " + phrasesUniques.Count);
Console.WriteLine("Nombre de doublons évités = " + doublonsEvites);


foreach(var phrase in phrasesUniques)
{
    Console.WriteLine(phrase); 
}


