// PlaylistDataService.cs (Data Layer)

using System;
using System.Collections.Generic;
using MusicPlaylistModel;

namespace MusicPlaylistDataLayer
{
    public class PlaylistDataService
    {
        private List<Song> _songs = new List<Song>
        {
            new Song
            {
                Title = "The Night We Met",
                Artist = "Lord Huron",
                Lyrics = "I am not the only traveler\r\nWho has not repaid his debt\r\nI've been searching for a trail to follow again\r\nTake me back to the night we met\r\nAnd then I can tell myself\r\nWhat the hell I'm supposed to do\r\nAnd then I can tell myself\r\nNot to ride along with you\r\nI had all and then most of you\r\nSome and now none of you\r\nTake me back to the night we met\r\nI don't know what I'm supposed to do\r\nHaunted by the ghost of you\r\nOh, take me back to the night we met\r\nWhen the night was full of terrors\r\nAnd your eyes were filled with tears\r\nWhen you had not touched me yet\r\nOh, take me back to the night we met\r\nI had all and then most of you\r\\nSome and now none of you\r\nTake me back to the night we met\r\nI don't know what I'm supposed to do\r\nHaunted by the ghost of you\r\nTake me back to the night we met"
            },
            new Song
            {
                Title = "What Would I Do",
                Artist = "Strawberry Guy",
                Lyrics = "I can tell that the grass is greener\r\nOn the other side, with you\r\nI wouldn't know what to do without you\r\nStay by my side, eternally\r\nWhat would I do\r\nWithout someone like you?\r\nWhat would I do\r\nWithout someone like you?\r\nWhat would I do\r\nI can tell that the water's clearer\r\nOn the other side, with you\r\nI know you care about the faults in my life\r\nJust promise me this, stay with me\r\nWhat would I do\r\nWithout someone like you?\r\nWhat would I do\r\nWithout someone like you?\r\nWhat would I do\r\nWhat would I do\r\nWithout someone like you?\r\nWhat would I do\r\nWithout someone like you?\r\nWhat would I do\r\nWhat would I do\r\nWithout someone like you?\r\nWhat would I do\r\nWithout someone like you?\r\nWhat would I do\r\nWhat would I do\r\nWithout someone like you?\r\nWhat would I do\r\nWithout someone like you?\r\nWhat would I do\r\nWhat would I do\r\nWithout someone like you?\r\nWhat would I do"
            },
            new Song
            {
                Title = "Same Ground",
                Artist = "Kitchie Nadal",
                Lyrics = "My love,\r\nIts been a long time since I cried\r\nAnd left you out of the blue\r\nIts hard leaving you that way\r\nWhen I never wanted to\r\nSelf-denial is a game\r\nIts strange I never would've\r\nWanted if until there was you\r\nBecause I have learned that love is beyond\r\nWhat human can imagine,\r\nThe more it clears\r\nThe more I have to let you go\r\nBut now I don'T understand why I'm feeling\r\nSo bad now when I know it was my idea\r\nI could've just denied the truth and lied\r\nBut why am I the only one standing stranded\r\nOn the same ground?\r\nMy love because I have learned that love is a\r\nWord gets thrown a little bit too much\r\nThe best excuse to fill the infinite abyss\r\nI never have to if all else fail\r\nWould you be there to love me?\r\nWhen all else fail,\r\nWould you be brave to see right through me?"
            },
            new Song
            {
                Title = "Say Yes to Heaven",
                Artist = "Lana Del Ray",
                Lyrics = "If you dance, I'll dance\r\nAnd if you don't, I'll dance anyway\r\nGive peace a chance\r\nLet the fear you have fall away\r\nI've got my eye on you\r\nI've got my eye on you\r\nSay yes to Heaven\r\nSay yes to me\r\nSay yes to Heaven\r\nSay yes to me\r\nIf you go, I'll stay\r\nYou come back, I'll be right here\r\nLike a barge at sea\r\nIn the storm, I stay clear\r\n'Cause I've got my mind on you\r\nI've got my mind on you\r\nSay yes to Heaven\r\nSay yes to me\r\nSay yes to Heaven\r\nSay yes to me\r\nIf you dance, I'll dance\r\nI'll put my red dress on, get it on\r\nAnd if you fight, I'll fight\r\nIt doesn't matter now, it's all gone\r\nI've got my mind on you\r\nI got my mind on you\r\nSay yes to Heaven\r\nSay yes to me\r\nSay yes to Heaven\r\nSay yes to me\r\nI've got my eye on you\r\nI've got my eye on you, mm\r\nI've got my eye on you\r\nI've got my eye on you"
            },
            new Song
            {
                Title = "End of Beginning",
                Artist = "Djo",
                Lyrics = "Just one more tear to cry\r\nOne teardrop from my eye\r\nYou better save it for\r\nThe middle of the night\r\nWhen things aren't black and white\r\nEnter, Troubadour\r\nRemember twenty-four?\r\nAnd when I'm back in Chicago, I feel it\r\nAnother version of me, I was in it\r\nI wave goodbye to the end of beginning\r\nThis song has started now\r\nAnd you're just finding out\r\nNow isn't that a laugh?\r\nA major sacrifice\r\nBut clueless at the time\r\nEnter, Caroline\r\nJust trust me, you'll be fine\r\nAnd when I'm back in Chicago, I feel it\r\nAnother version of me, I was in it\r\nI wave goodbye to the end of beginning\r\n(Goodbye, goodbye, goodbye, goodbye)\r\nYou take the man out of the city, not the city out the man\r\nYou take the man out of the city, not the city out the man\r\nYou take the man out of the city, not the city out the man\r\nYou take the man out of the\r\nAnd when I'm back in Chicago, I feel it\r\nAnother version of me, I was in it\r\nOh, I wave goodbye to the end of beginning\r\n(Goodbye, goodbye)"
            },
            new Song
            {
                Title = "Lips of an Angel",
                Artist = "Hinder",
                Lyrics = "Honey, why you calling me so late?\r\nIt's kinda hard to talk right now\r\nHoney, why you crying, is everything okay?\r\nI gotta whisper 'cause I can't be too loud\r\nWell, my girl's in the next room\r\nSometimes I wish she was you\r\nI guess we never really moved on\r\nIt's really good to hear your voice saying my name\r\nIt sounds so sweet\r\nComing from the lips of an angel\r\nHearing those words, it makes me weak\r\nAnd I never wanna say goodbye\r\nBut, girl, you make it hard to be faithful\r\nWith the lips of an angel\r\nIt's funny that you're calling me tonight\r\nAnd, yes, I've dreamt of you too\r\nAnd does he know you're talking to me?\r\nWill it start a fight?\r\nNo, I don't think she has a clue\r\nWell, my girl's in the next room\r\nSometimes I wish she was you\r\nI guess we never really moved on\r\nIt's really good to hear your voice saying my name\r\nIt sounds so sweet\r\nComing from the lips of an angel\r\nHearing those words, it makes me weak\r\nAnd I never wanna say goodbye\r\nBut, girl, you make it hard to be faithful\r\nWith the lips of an angel\r\nIt's really good to hear your voice saying my name\r\nIt sounds so sweet\r\nComing from the lips of an angel\r\nHearing those words, it makes me weak\r\nAnd I never wanna say goodbye\r\nBut, girl, you make it hard to be faithful\r\nWith the lips of an angel\r\nAnd I never wanna say goodbye\r\nBut, girl, you make it hard to be faithful\r\nWith the lips of an angel\r\nHoney, why you calling me so late?"
            },
            new Song
            {
                Title = "Dark Red",
                Artist = "Steve Lacy",
                Lyrics = "Something bad is 'bout to happen to me\r\nI don't know it, but I feel it coming\r\nMight be so sad, might leave my nose running\r\nI just hope she don't wanna leave me\r\nDon't you give me up, please don't give up\r\nHoney, I belong with you, and only you, baby\r\nOnly you, my girl, only you, babe (you)\r\nOnly you, darling, only you, babe (you)\r\nOnly you, my girl, only you, babe (you)\r\nOnly you, darling, only you\r\nSomething bad is 'bout to happen to me\r\nWhy I feel this way, I don't know, baby\r\nI think of her so much, it drives me crazy\r\nI just don't want her to leave me\r\nDon't you give me up, please don't give up\r\nHoney, I belong with you and only you, baby\r\nOnly you, my girl, only you, babe (you)\r\nOnly you, darling, only you, babe (you)\r\nOnly you, my girl, only you, babe (you)\r\nOnly you, darling, only you\r\nWhat if she's fine?\r\nIt's my mind that's wrong\r\nAnd I just let bad thoughts\r\nLinger for far too long\r\nWhat if (if) she's fine? (Fine)\r\nIt's my mind that's wrong\r\nAnd I just (just) let bad thoughts (thoughts)\r\nLinger for far too long\r\nDon't you give me up, please don't give up\r\nHoney, I belong, with you, only you, baby\r\nOnly you, my girl, only you, babe (you)\r\nOnly you, darling, only you, babe (you)\r\nOnly you, my girl, only you, babe (you)\r\nOnly you, darling, only you"
            },
            new Song
            {
                Title = "Ikaw at Ako",
                Artist = "Moira Dela Torre",
                Lyrics = "Sabi nila, balang araw\r\nDarating ang iyong tanging hinihiling\r\nAt noong dumating ang aking panalangin\r\nAy hindi na maikubli\r\nAng pag-asang nahanap ko sa 'yong mga mata\r\nAt ang takot kung sakali mang ika'y mawawala\r\nAt ngayon, nandiyan ka na\r\n'Di mapaliwanag ang nadarama\r\nHanda ako sa walang-hanggan\r\n'Di paaasahin, 'di ka sasaktan\r\nMula noon hanggang ngayon\r\nIkaw at ako\r\nAt sa wakas ay nahanap ko na rin\r\nAng aking tanging hinihiling\r\nPangako sa 'yo na ika'y uunahin\r\nAt hindi na itatanggi\r\nAng tadhanang nahanap ko sa 'yong pagmamahal\r\nAng dudulot sa pag-ibig natin na magtatagal\r\nAt ngayon, nandiyan ka na\r\n'Di mapaliwanag ang nadarama\r\nHanda ako sa walang-hanggan\r\n'Di paaasahin, 'di ka sasaktan\r\nMula noon (mula noon) hanggang ngayon\r\nIkaw at ako\r\nAt ngayon, nandito na\r\nPalaging hahawakan iyong mga kamay\r\nHindi ka na mag-iisa\r\nSa hirap at ginhawa ay iibigin ka\r\nMula noon hanggang ngayon\r\nMula ngayon hanggang dulo\r\nIkaw at ako"
            },
            new Song
            {
                Title = "A Piece of You",
                Artist = "Nathaniel Constantin",
                Lyrics = "If you leave me don't you ever think I want you to go\r\nCause I'm bound to you\r\nAll I need is you to wait for me and I'll be there for you\r\nCause I'll run to you\r\nMy heart belongs to you\r\nI'll take a piece of you\r\nI don't know what's happening now\r\nAnd a lot of things have turned\r\nI wished that I could turn back time\r\nBack when I'm with you\r\nBut my heart belongs to you\r\nI'll take a piece of you\r\nMy heart belongs to you\r\nI'll take a piece of you\r\nMy heart belongs to you\r\nI'll take a piece of you\r\nMy heart belongs to you\r\nI'll take a piece of you"
            },
            new Song
            {
                Title = "Sweet",
                Artist = "Cigarettes After Sex",
                Lyrics = "Watching the video that you sent me\r\nThe one where you're showering with wet hair dripping\r\nYou know that I'm obsessed with your body\r\nBut it's the way you smile that does it for me\r\nIt's so sweet, knowing that you love me\r\nThough we don't need to say it to each other, sweet\r\nKnowing that I love you, and running my fingers through your hair\r\nIt's so sweet\r\nWatching the video where you're lying\r\nIn your red lingerie ten times nightly\r\nYou know I think your skin's the perfect color\r\nBut it's always your eyes that pull me under\r\nIt's so sweet, knowing that you love me\r\nThough we don't need to say it to each other, sweet\r\nKnowing that I love you, and running my fingers through your hair\r\nIt's so sweet\r\nAnd I will gladly break it\r\nI will gladly break my heart for you\r\nAnd I will gladly break it\r\nI will gladly break my heart for you\r\nAnd I will gladly break it\r\nI will gladly break my heart for you\r\nAnd I will gladly break it\r\nI will gladly break my heart for you\r\nIt's so sweet, knowing that you love me\r\nThough we don't need to say it to each other, sweet\r\nKnowing that I love you, and running my fingers through your hair\r\nIt's so sweet"
            },
        };

        public Song GetSong(string title)
        {
            return _songs.Find(s => s.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
}