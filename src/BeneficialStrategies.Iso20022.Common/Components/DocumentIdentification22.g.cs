﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentIdentification22.  ISO2002 ID# _SuJtIgEcEeCQm6a_G2yO_w_-589377651.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a document by a unique identification and a date of issue.
/// </summary>
public partial record DocumentIdentification22
     : IIsoXmlSerilizable<DocumentIdentification22>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the document.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Date of issuance of the document.
    /// </summary>
    public IsoISODate? DateOfIssue { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (DateOfIssue is IsoISODate DateOfIssueValue)
        {
            writer.WriteStartElement(null, "DtOfIsse", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(DateOfIssueValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static DocumentIdentification22 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
