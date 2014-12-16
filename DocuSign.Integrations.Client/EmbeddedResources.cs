// -----------------------------------------------------------------------
// <copyright file="EmbeddedResources.cs" company="DocuSign, Inc.">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DocuSignClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Reflection;
    using System.IO;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class EmbeddedResources
    {
        public static string ReadTextResource(string resourceName)
        {
            var smbly = Assembly.GetExecutingAssembly();
            using(var rs = smbly.GetManifestResourceStream(resourceName))
            {
                using(var resource = new StreamReader(rs))
                {
                    return resource.ReadToEnd();
                }
            }
        }
    }
}
