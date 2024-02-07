﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _skrJe83wEee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.RateType72Choice;

/// <summary>
/// Proprietary identification of the type of gross dividend rate.
/// </summary>
public partial record Proprietary : RateType72Choice_
     , IIsoXmlSerilizable<Proprietary>
{
    #nullable enable
    
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required IsoExact4AlphaNumericText Identification { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public required IsoMax4AlphaNumericText Issuer { get; init; } 
    /// <summary>
    /// Short textual description of the scheme.
    /// </summary>
    public IsoMax4AlphaNumericText? SchemeName { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoExact4AlphaNumericText(Identification)); // data type Exact4AlphaNumericText System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Issr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax4AlphaNumericText(Issuer)); // data type Max4AlphaNumericText System.String
        writer.WriteEndElement();
        if (SchemeName is IsoMax4AlphaNumericText SchemeNameValue)
        {
            writer.WriteStartElement(null, "SchmeNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax4AlphaNumericText(SchemeNameValue)); // data type Max4AlphaNumericText System.String
            writer.WriteEndElement();
        }
    }
    public static new Proprietary Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
