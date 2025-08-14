﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_internal_interface_dependency_injection.CSharp.Main.Abstract;

namespace Concrete
{
    public class EnglishAlphabet : IAlphabet
    {
        public Dictionary<char, int> getLetterScores()
        {
            Dictionary<char, int> words = new Dictionary<char, int>();
            words.Add('a', 1);
            words.Add('b', 3);
            words.Add('c', 3);
            words.Add('d', 2);
            words.Add('e', 1);
            words.Add('f', 4);
            words.Add('g', 2);
            words.Add('h', 4);
            words.Add('i', 1);
            words.Add('j', 8);
            words.Add('k', 5);
            words.Add('l', 1);
            words.Add('m', 3);
            words.Add('n', 1);
            words.Add('o', 1);
            words.Add('p', 3);
            words.Add('q', 10);
            words.Add('r', 1);
            words.Add('s', 1);
            words.Add('t', 1);
            words.Add('u', 1);
            words.Add('v', 4);
            words.Add('w', 4);
            words.Add('x', 8);
            words.Add('y', 4);
            words.Add('z', 10);
            return words;
        }
    }
}
