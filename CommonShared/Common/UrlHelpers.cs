﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonShared.Common
{
    public static class UrlHelpers
    {
        private static readonly Regex reSlugCharactersToBeDashes = new Regex(@"([\s,.//\\-_=])+");
        private static readonly Regex reSlugCharactersToRemove = new Regex(@"([^0-9a-z\-])+");
        private static readonly Regex reSlugDashes = new Regex(@"([\-])+");
        private static readonly Regex reSlugCharacters = new Regex(@"([\s,.//\\-_=])+");
        public static string URLFriendly(string title)
        {
            if (String.IsNullOrEmpty(title)) return "";

            var newTitle = RemoveDiacritics(title);
            newTitle = Regex.Replace(newTitle, "(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z])", @"-$1");
            newTitle = reSlugCharactersToBeDashes.Replace(newTitle, "-");
            newTitle = newTitle.ToLowerInvariant();
            newTitle = reSlugCharactersToRemove.Replace(newTitle, "");
            newTitle = reSlugDashes.Replace(newTitle, "-");
            newTitle = newTitle.Trim('-');
            return newTitle;
        }

        static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
        public static string SlugToTopic(string slug)
        {
            if (String.IsNullOrEmpty(slug))
            {
                return "";
            }

            var textInfo = new CultureInfo("en-US", false).TextInfo;
            var outValue = textInfo.ToTitleCase(slug);
            return outValue.Replace("-", " ");

        }
    }
}
