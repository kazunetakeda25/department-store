using System;
using System.Collections.Generic;
using System.Linq;

namespace Department.Base.Model.Catalog
{
    public static class TermExtensions
    {

        public static IEnumerable<Term> ToTerms(this string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }
            var result = input.Split(';')
                      .Select(x => x.Split(':'))
                      .Where(x => x.Length == 2)
                      .SelectMany(x => x[1].Split(',').Select(v => new Term { Name = x[0], Value = v }));
            return result;
        }
        /// <summary>
        /// Groups terms by name and converts each group to a string:
        /// name1:value1,value2,value3
        /// </summary>
        /// <param name="terms"></param>
        /// <returns></returns>
        public static List<string> ToStrings(this IEnumerable<Term> terms)
        {
            List<string> result = null;

            if (terms != null)
            {
                var strings = terms
                    .GroupBy(t => t.Name, t => t, StringComparer.OrdinalIgnoreCase)
                    .OrderBy(g => g.Key)
                    .Select(
                        g =>
                            string.Join(":", g.Key,
                                string.Join(",",
                                    g.Select(t => t.Value)
                                        .Distinct(StringComparer.OrdinalIgnoreCase)
                                        .OrderBy(v => v))))
                    .ToList();

                if (strings.Any())
                {
                    result = strings;
                }
            }

            return result;
        }
    }
}
