using System;
using System.Collections.Generic;

namespace CollectionExample
{
    public interface ICharacterReader : IDisposable
    {
        char GetNextChar();
    }

    public class SimpleCharacterReader : ICharacterReader
    {
        private int m_Pos = 0;
        private string m_Content = @"	
It was the best of times, it was the worst of times,
it was the age of wisdom, it was the age of foolishness,
it was the epoch of belief, it was the epoch of incredulity,
it was the season of Light, it was the season of Darkness,
it was the spring of hope, it was the winter of despair,
we had everything before us, we had nothing before us,
we were all going direct to Heaven, we were all going direct
the other way--in short, the period was so far like the present
period, that some of its noisiest authorities insisted on its
being received, for good or for evil, in the superlative degree
of comparison only.

There were a king with a large jaw and a queen with a plain face,
on the throne of England; there were a king with a large jaw and
a queen with a fair face, on the throne of France.  In both
countries it was clearer than crystal to the lords of the State
preserves of loaves and fishes, that things in general were
settled for ever";

        private string currentStr;
        private Dictionary<string, Node<string, int>> words;

        public SimpleCharacterReader()
        {
            currentStr = "";
            words = new Dictionary<string, Node<string, int>>();
        }

        public char GetNextChar()
        {
            if (m_Pos >= m_Content.Length)
            {
                throw new System.IO.EndOfStreamException();
            }

            char currentChar = m_Content[m_Pos++];
            if (Char.IsLetter(currentChar))
            {
                currentStr += currentChar;
            }
            else
            {
                addToDictionary(currentStr);
                // reset the string to empty string
                currentStr = "";
            }

            return currentChar;
        }

        private void addToDictionary(string str)
        {
            str = str.ToLower();
            Node<string, int> n = null;
            if (str.Length > 0)
            {
                if (words.ContainsKey(str))
                {
                    words[str].Value += 1;
                }
                else
                {
                    n = new Node<string, int>();
                    n.Key = str;
                    n.Value = 1;
                    words.Add(str, n);
                }
            }
        }

        public List<Node<string, int>> GetWordList()
        {
            List<Node<string, int>> list = new List<Node<string, int>>();
            foreach (string key in words.Keys)
            {
                list.Add(words[key]);
            }
            return list;
        }

        public void Dispose()
        {
            //do nothing
        }
    }

    public class SlowCharacterReader : ICharacterReader
    {

        private int m_Pos = 0;
        private string m_Content = @"  Alice was beginning to get very tired of sitting by her sister
on the bank, and of having nothing to do:  once or twice she had
peeped into the book her sister was reading, but it had no
pictures or conversations in it, 'and what is the use of a book,'
thought Alice `without pictures or conversation?'

  So she was considering in her own mind (as well as she could,
for the hot day made her feel very sleepy and stupid), whether
the pleasure of making a daisy-chain would be worth the trouble
of getting up and picking the daisies, when suddenly a White
Rabbit with pink eyes ran close by her.";

        Random m_Rnd = new Random();

        public char GetNextChar()
        {
            System.Threading.Thread.Sleep(m_Rnd.Next(200));

            if (m_Pos >= m_Content.Length)
            {
                throw new System.IO.EndOfStreamException();
            }

            return m_Content[m_Pos++];

        }

        public void Dispose()
        {
            //do nothing
        }

    }
}