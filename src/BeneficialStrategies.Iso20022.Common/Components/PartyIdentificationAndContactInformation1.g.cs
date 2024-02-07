﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndContactInformation1.  ISO2002 ID# _Pb-D5Np-Ed-ak6NoX_4Aeg_196982310.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a person, or a non-financial institution.
/// </summary>
public partial record PartyIdentificationAndContactInformation1
     : IIsoXmlSerilizable<PartyIdentificationAndContactInformation1>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required PartyIdentification8 PartyIdentification { get; init; } 
    /// <summary>
    /// Information needed to contact a physical person related to the party, such as name, phone number, email address.
    /// </summary>
    public ContactIdentification1? ContactInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "PtyId", xmlNamespace );
        PartyIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ContactInformation is ContactIdentification1 ContactInformationValue)
        {
            writer.WriteStartElement(null, "CtctInf", xmlNamespace );
            ContactInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PartyIdentificationAndContactInformation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
