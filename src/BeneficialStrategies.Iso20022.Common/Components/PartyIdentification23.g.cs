﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification23.  ISO2002 ID# _QQkwqNp-Ed-ak6NoX_4Aeg_-647119755.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of identification of a party. The party can be identified by providing a BIC or a proprietary code.
/// Optionally, the client account number can also be provided.
/// </summary>
public partial record PartyIdentification23
     : IIsoXmlSerilizable<PartyIdentification23>
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
    /// </summary>
    public required IsoAnyBICIdentifier BICOrBEI { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    public required GenericIdentification1 ProprietaryIdentification { get; init; } 
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public NameAndAddress5? NameAndAddress { get; init; } 
    
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
        writer.WriteStartElement(null, "BICOrBEI", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoAnyBICIdentifier(BICOrBEI)); // data type AnyBICIdentifier System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PrtryId", xmlNamespace );
        ProprietaryIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (NameAndAddress is NameAndAddress5 NameAndAddressValue)
        {
            writer.WriteStartElement(null, "NmAndAdr", xmlNamespace );
            NameAndAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PartyIdentification23 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
