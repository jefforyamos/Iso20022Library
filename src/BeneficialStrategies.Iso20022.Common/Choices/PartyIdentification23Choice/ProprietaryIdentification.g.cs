﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryIdentification.  ISO2002 ID# _QReIg9p-Ed-ak6NoX_4Aeg_-1086683041.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification23Choice;

/// <summary>
/// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
/// </summary>
public partial record ProprietaryIdentification : PartyIdentification23Choice_
     , IIsoXmlSerilizable<ProprietaryIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public IsoMax35Text? SchemeName { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (SchemeName is IsoMax35Text SchemeNameValue)
        {
            writer.WriteStartElement(null, "SchmeNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SchemeNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Issuer is IsoMax35Text IssuerValue)
        {
            writer.WriteStartElement(null, "Issr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(IssuerValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static new ProprietaryIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
