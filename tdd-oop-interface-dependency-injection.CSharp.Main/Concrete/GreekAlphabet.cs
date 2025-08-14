﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_internal_interface_dependency_injection.CSharp.Main.Abstract;

namespace tdd_oop_internal_interface_dependency_injection.CSharp.Main.Concrete
{
    public class GreekAlphabet : IAlphabet
    {
        public Dictionary<char, int> getLetterScores()
        {
            Dictionary<char, int> words = new Dictionary<char, int>();
            words.Add('α', 1);
            words.Add('ε', 1);
            words.Add('ι', 1);
            words.Add('ο', 1);
            words.Add('φ', 1);
            words.Add('ξ', 1);

            words.Add('β', 2);
            words.Add('δ', 2);
            words.Add('π', 2);

            words.Add('γ', 3);
            words.Add('η', 3);
            words.Add('ν', 3);
            words.Add('τ', 3);

            words.Add('ζ', 4);
            words.Add('κ', 4);
            words.Add('ρ', 4);
            words.Add('ψ', 4);
            words.Add('λ', 4);

            words.Add('с', 4);
            words.Add('т', 4);
            words.Add('у', 4);
            words.Add('ф', 4);

            words.Add('θ', 5);
            words.Add('χ', 5);

            words.Add('μ', 8);
            words.Add('σ', 8);

            words.Add('υ', 10);
            words.Add('ω', 10);

            return words;
        }
    }
}
