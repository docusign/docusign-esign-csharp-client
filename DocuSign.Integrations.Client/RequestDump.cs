// -----------------------------------------------------------------------
// <copyright file="RequestDump.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace DocuSign.Integrations.Client
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;

    /// <summary>
    /// RequestDump class
    /// </summary>
    static class RequestDump
    {
        /// <summary>
        /// Dumps a specific request
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public static string Dump(this RequestBuilder req)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0}: {1}", req.HttpRequest.Method, req.HttpRequest.RequestUri));
            sb.AppendLine();
            sb.AppendLine("Headers:");

            for (int x = 0; x < req.HttpRequest.Headers.Count; x++)
            {
                var key = req.HttpRequest.Headers.Keys[x];
                var val = req.HttpRequest.Headers[x];

                sb.AppendLine(string.Format("{0}:{1}", key, val));
            }

            sb.AppendLine();
            sb.AppendLine("Request Stream:");

            req.Dump.Seek(0, SeekOrigin.Begin);

            using (var reader = new StreamReader(req.Dump))
            {
                string str = reader.ReadToEnd();
                sb.Append(str);
            }

            return sb.ToString();
        }
    }
}
