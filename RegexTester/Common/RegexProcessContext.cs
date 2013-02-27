﻿using System;
using System.Text.RegularExpressions;

namespace Sharomank.RegexTester.Common
{
    /// <summary>
    /// Author: Roman Kurbangaliev (Sharomank)
    /// </summary>
    public class RegexProcessContext
    {
        private string _replaceRegexPattern;

        public Regex MatchRegex { get; set; }
        public string InputText { get; set; }
        public RegexMode CurrentMode { get; set; }

        public string ReplaceRegexPattern {
            get
            {
                return _replaceRegexPattern;
            }
            set
            {
                if (value == null)
                    value = String.Empty;
                _replaceRegexPattern = value.Replace("\\n", Environment.NewLine).Replace("\\t", "	");
            }
        }
    }
}