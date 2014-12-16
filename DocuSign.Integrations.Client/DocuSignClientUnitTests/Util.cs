// -----------------------------------------------------------------------
// <copyright file="Util.cs" company="DocuSign, Inc.">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace RestClientUnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class Util
    {
        /// <summary>
        /// String replacement with a unique value
        /// </summary>
        /// <param name="stringIn">string instance</param>
        /// <returns>modified string</returns>
        public static string MakeUnique(string stringIn)
        {
            DateTime startDateTime = new DateTime(2012, 03, 27);
            DateTime currentDT = DateTime.Now;
            string unique = (currentDT.Ticks - startDateTime.Ticks).ToString();
            string stringOut = stringIn.Replace("{unique}", unique);
            return stringOut;
        }
    }
}
