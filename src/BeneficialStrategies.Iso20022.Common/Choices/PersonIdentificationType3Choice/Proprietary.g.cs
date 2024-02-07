﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _RjH9oNp-Ed-ak6NoX_4Aeg_-142125348.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PersonIdentificationType3Choice;

/// <summary>
/// Person identification expressed as a proprietary code.
/// </summary>
public partial record Proprietary : PersonIdentificationType3Choice_
     , IIsoXmlSerilizable<Proprietary>
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    public required IsoMax4AlphaNumericText Identification { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public IsoMax35Text? SchemeName { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public required IsoMax35Text Issuer { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoMax4AlphaNumericText(Identification)); // data type Max4AlphaNumericText System.String
        writer.WriteEndElement();
        if (SchemeName is IsoMax35Text SchemeNameValue)
        {
            writer.WriteStartElement(null, "SchmeNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SchemeNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Issr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Issuer)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static new Proprietary Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
