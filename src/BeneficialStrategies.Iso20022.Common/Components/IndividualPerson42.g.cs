﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IndividualPerson42.  ISO2002 ID# _RwgGofNrEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an 'artificial person').
/// </summary>
public partial record IndividualPerson42
     : IIsoXmlSerilizable<IndividualPerson42>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the proxy.
    /// </summary>
    public PartyIdentification232Choice_? PreassignedProxy { get; init; } 
    /// <summary>
    /// Organisation represented by the person, or for which the person works.
    /// </summary>
    public PartyIdentification129Choice_? EmployingParty { get; init; } 
    /// <summary>
    /// Details related to the attendance card.
    /// </summary>
    public required AttendanceCard3 AttendanceCardDetails { get; init; } 
    
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
        if (PreassignedProxy is PartyIdentification232Choice_ PreassignedProxyValue)
        {
            writer.WriteStartElement(null, "PrssgndPrxy", xmlNamespace );
            PreassignedProxyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EmployingParty is PartyIdentification129Choice_ EmployingPartyValue)
        {
            writer.WriteStartElement(null, "EmplngPty", xmlNamespace );
            EmployingPartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AttndncCardDtls", xmlNamespace );
        AttendanceCardDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static IndividualPerson42 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
