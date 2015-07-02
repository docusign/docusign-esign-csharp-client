// -----------------------------------------------------------------------
// <copyright file="EnvelopeStatus.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DocuSign.Integrations.Client
{
    /// <summary>
    /// EnvelopeStatus is an XML serializable class for handling the data contained in the request body
    /// of a DocuSign Envelope notification event.  We use it to deserialize that data into an object
    /// that we can use.  The object is contained within DocuSignEnvelopeInformation XML.
    /// </summary>
    [Serializable]
    [XmlType]
    public class EnvelopeStatus
    {
        [XmlArray]
        public RecipientStatus[] RecipientStatuses { get; set; }

        [XmlElement(DataType = "dateTime", Type = typeof(DateTime))]
        public DateTime TimeGenerated { get; set; }

        [XmlElement(ElementName = "EnvelopeID", DataType = "string", Type = typeof(string))]
        public string EnvelopeId { get; set; }

        [XmlElement(DataType = "string", Type = typeof(string))]
        public string Subject { get; set; }

        [XmlElement(DataType = "string", Type = typeof(string))]
        public string UserName { get; set; }

        [XmlElement(DataType = "string", Type = typeof(string))]
        public string Email { get; set; }

        [XmlElement(DataType = "string", Type = typeof(string))]
        public string Status { get; set; }

        [XmlElement(DataType = "dateTime", Type = typeof(DateTime))]
        public DateTime Created { get; set; }

        [XmlElement(DataType = "dateTime", Type = typeof(DateTime))]
        public DateTime Sent { get; set; }

        [XmlElement(DataType = "dateTime", Type = typeof(DateTime))]
        public DateTime Delivered { get; set; }

        [XmlElement(DataType = "dateTime", Type = typeof(DateTime))]
        public DateTime Signed { get; set; }

        [XmlElement(DataType = "dateTime", Type = typeof(DateTime))]
        public DateTime Completed { get; set; }

        [XmlElement(DataType = "string", Type = typeof(string))]
        public string ACStatus { get; set; }

        [XmlElement(DataType = "dateTime", Type = typeof(DateTime))]
        public DateTime ACStatusDate { get; set; }

        [XmlElement(DataType = "string", Type = typeof(string))]
        public string ACHolder { get; set; }

        [XmlElement(DataType = "string", Type = typeof(string))]
        public string ACHolderEmail { get; set; }

        [XmlElement(DataType = "string", Type = typeof(string))]
        public string ACHolderLocation { get; set; }

        [XmlElement(DataType = "string", Type = typeof(string))]
        public string SigningLocation { get; set; }

        [XmlElement(DataType = "string", Type = typeof(string))]
        public string SenderIPAddress { get; set; }

        [XmlIgnore]
        public string EnvelopePDFHash { get; set; }

        [XmlArray]
        public CustomField[] CustomFields { get; set; }

        [XmlIgnore]
        public string AutoNavigation { get; set; }

        [XmlIgnore]
        public string EnvelopeIdStamping { get; set; }

        [XmlIgnore]
        public string AuthoritativeCopy { get; set; }

        [XmlArray]
        public DocumentStatus[] DocumentStatuses { get; set; }

        /// <summary>
        /// CustomField is an XML serializable class for handling the data contained in the request body
        /// of a DocuSign Envelope notification event.  We use it to deserialize that data into an object
        /// that we can use.  The object is contained within EnvelopeStatus XML.
        /// 
        /// This class also contains static methods for chunking data into custom fields when creating an
        /// envelope and reconstructing that data when received via an envelope status event.
        /// </summary>
        [XmlType]
        [Serializable]
        public class CustomField
        {
            /// <summary>
            /// Maximum allowed custom field length
            /// </summary>
            static readonly int MaxFieldLength = 100;

            /// <summary>
            /// Takes a list of items (value/object pairs) and creates a text set of custom fields
            /// </summary>
            /// <param name="items">Dictionary of stringizable objects to be made into text custom fields</param>
            /// <returns>Array of TextCustomField objects representing the input dictionary</returns>
            public static TextCustomField[] CreateCustomFieldsArray(Dictionary<string, object> items)
            {
                // Get the number of array items to create.  Each custom field can only be 100 chars long
                int fieldCount = 0;
                foreach (KeyValuePair<string, object> item in items)
                {
                    fieldCount += item.Value.ToString().Length / MaxFieldLength;
                    if (item.Value.ToString().Length % MaxFieldLength != 0)
                    {
                        fieldCount++;
                    }
                }

                // Create the output array and chop up each input into custom fields
                var outputFields = new TextCustomField[fieldCount];
                int fieldIdx = 0;
                foreach (KeyValuePair<string, object> item in items)
                {
                    int itemFieldCount = 0;
                    if (item.Value.ToString().Length < MaxFieldLength)
                    {
                        outputFields[fieldIdx] = new TextCustomField();
                        outputFields[fieldIdx].name = item.Key;
                        outputFields[fieldIdx].value = item.Value.ToString();
                        outputFields[fieldIdx++].show = "False";
                    }
                    else // fields longer than 100 characters needs to be split 
                    {
                        for (int startCharIdx = 0; startCharIdx < item.Value.ToString().Length; startCharIdx += MaxFieldLength)
                        {
                            var nextCustomField = new TextCustomField();
                            nextCustomField.name = String.Format("{0}#{1}", item.Key, itemFieldCount++);
                            nextCustomField.show = "False";
                            int stringLen = item.Value.ToString().Length;
                            nextCustomField.value = item.Value.ToString().Substring(startCharIdx, stringLen - startCharIdx < MaxFieldLength ? stringLen - startCharIdx : 100);
                            outputFields[fieldIdx++] = nextCustomField;
                        }
                    }
                }

                return outputFields;
            }

            /// <summary>
            /// Returns a string made up of multiple custom envelope fields that are comprised of a base name
            /// appended with a zero-based integer count. Example:
            ///   myCustomFields = { MyCustomField#0 = "ABC", MyCustomField#1 = "def" }
            ///   RecreateTokenFromCustomFields(myCustomFields, "MyCustomField") returns "ABCdef"  
            /// </summary>
            /// <param name="customFields">The full array of envelope custom fields to search</param>
            /// <param name="baseCustomFieldName">Base name of the custome fields</param>
            /// <returns>A concatenated string of </returns>
            public static string RecreateTokenFromCustomFields(CustomField[] customFields, string baseCustomFieldName)
            {
                int fieldPartCount = GetCustomFieldPartCount(customFields, baseCustomFieldName);
                if (fieldPartCount == 0)
                {
                    return null;
                }

                string[] fieldParts = new string[fieldPartCount];
                int fieldPartsFound = 0;
                for (int fieldIdx = 0; fieldIdx < customFields.Length; fieldIdx++)
                {
                    if (fieldPartCount == 1 && customFields[fieldIdx].Name == baseCustomFieldName)
                    {
                        return customFields[fieldIdx].Value;
                    }


                    string baseNameAndDelimiter = baseCustomFieldName + '#';
                    if (customFields[fieldIdx].Name.StartsWith(baseNameAndDelimiter))
                    {
                        int partIdx;
                        if (Int32.TryParse(customFields[fieldIdx].Name.Substring(baseNameAndDelimiter.Length), out partIdx) == false)
                        {
                            // We have a collision of Custom Field Names where one set of custom field names
                            // is a leading substring of another.  (Example: "MyCustomField" and "MyCustomFieldIs".
                            // The developer must avoid this.
                            throw new System.InvalidOperationException(
                                String.Format("Custom Field Name Collision. Base name: {0}",
                                baseCustomFieldName));
                        }

                        fieldParts[partIdx] = customFields[fieldIdx].Value;

                        fieldPartsFound++;
                        if (fieldPartsFound == fieldPartCount)
                        {
                            break; // No need to troll through the rest of the custom fields, we have them all
                        }
                    }
                }

                StringBuilder token = new StringBuilder(fieldParts[0], fieldPartCount * MaxFieldLength); // field parts are 100 chars max
                for (int partIdx = 1; partIdx < fieldPartCount; partIdx++)
                {
                    token.Append(fieldParts[partIdx]);
                }

                return token.ToString();
            }

            [XmlElement]
            public string Name { get; set; }

            [XmlElement]
            public string Show { get; set; }

            [XmlElement]
            public string Required { get; set; }

            [XmlElement]
            public string Value { get; set; }

            [XmlArray]
            public string[] ListItems { get; set; }

            /// <summary>
            /// Provides a count of custom fields that comprise a chunked token
            /// </summary>
            /// <param name="customFields"></param>
            /// <param name="baseCustomFieldName"></param>
            /// <returns>Count of custom fields comprising a chunked token</returns>
            private static int GetCustomFieldPartCount(CustomField[] customFields, string baseCustomFieldName)
            {
                int fieldNameCount = 0;
                for (int fieldIdx = 0; fieldIdx < customFields.Length; fieldIdx++)
                {
                    // Handle the case where the custom field part contains the whole token (count = 1)
                    if (customFields[fieldIdx].Name == baseCustomFieldName)
                    {
                        if (fieldNameCount != 0)
                        {
                            // We have a collision of Custom Field Names where one set of custom field names
                            // collides with a standalone field name. (Example: "MyCustomField" and "MyCustomField#0".
                            // This should never happen unless possibly a hash character ('#') ends a base field name.
                            throw new System.InvalidOperationException(
                                String.Format("Custom Field Name Collision. Base name: {0}",
                                baseCustomFieldName));
                        }

                        return 1;
                    }

                    string baseNameAndDelimiter = baseCustomFieldName + '#';
                    if (customFields[fieldIdx].Name.StartsWith(baseNameAndDelimiter))
                    {
                        try
                        {
                            int partIdx = Int32.Parse(customFields[fieldIdx].Name.Substring(baseNameAndDelimiter.Length));
                        }
                        catch (FormatException)
                        {
                            // We have a collision of Custom Field Names where one set of custom field names
                            // is a leading substring of another and it contains the hash character delimiter.  
                            // (Example: "MyCustomField" and "MyCustomFieldIs".
                            // The developer must avoid this.
                            throw new System.InvalidOperationException(
                                String.Format("Custom Field Name Collision. Base name: {0}",
                                baseCustomFieldName));
                        }

                        fieldNameCount++;
                    }
                }

                return fieldNameCount;
            }
        }

        /// <summary>
        /// RecipientStatus is an XML serializable class for handling the data contained in the request body
        /// of a DocuSign Envelope notification event.  We use it to deserialize that data into an object
        /// that we can use.  The object is contained within EnvelopeStatus XML.
        [XmlType]
        [Serializable]
        public class RecipientStatus
        {
            [XmlElement]
            public string Type { get; set; }

            [XmlElement]
            public string Email { get; set; }

            [XmlElement]
            public string UserName { get; set; }

            [XmlElement(DataType = "int", Type = typeof(Int32))]
            public int RoutingOrder { get; set; }

            [XmlElement(DataType = "dateTime", Type = typeof(DateTime))]
            public DateTime Sent { get; set; }

            [XmlElement(DataType = "dateTime", Type = typeof(DateTime))]
            public DateTime Delivered { get; set; }

            [XmlElement(DataType = "dateTime", Type = typeof(DateTime))]
            public DateTime Signed { get; set; }

            [XmlIgnore]
            public string DeclineReason { get; set; }

            [XmlElement]
            public string Status { get; set; }

            [XmlIgnore]
            public string RecipientIPAddress { get; set; }

            [XmlElement]
            public RecipientStatusCustomFields CustomFields { get; set; }

            [XmlIgnore]
            public string TabStatuses { get; set; }

            [XmlElement]
            public string AccountStatus { get; set; }

            [XmlElement]
            public string RecipientId { get; set; }
        }

        /// <summary>
        /// DocumentStatus is an XML serializable class for handling the data contained in the request body
        /// of a DocuSign Envelope notification event.  We use it to deserialize that data into an object
        /// that we can use.  The object is contained within EnvelopeStatus XML.
        [XmlType]
        [Serializable]
        public class DocumentStatus
        {
            [XmlElement(DataType = "int", Type = typeof(Int32))]
            public int ID { get; set; }

            [XmlElement]
            public string Name { get; set; }

            [XmlElement]
            public string TemplateName { get; set; }

            [XmlElement(DataType = "int", Type = typeof(Int32))]
            public int Sequence { get; set; }
        }
    }
}
