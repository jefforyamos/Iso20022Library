﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryIdentification.  ISO2002 ID# _F-iyNR9REeuFz_FaCzCLgQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification234Choice;

/// <summary>
/// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
/// </summary>
public partial record ProprietaryIdentification : PartyIdentification234Choice_
     , IIsoXmlSerilizable<ProprietaryIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required IsoRestrictedFINXMax34Text Identification { get; init; } 
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
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax34Text(Identification)); // data type RestrictedFINXMax34Text System.String
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
    public static new ProprietaryIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
