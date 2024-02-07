﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AgentType1.  ISO2002 ID# _4zG7sKHHEeagRbKvRt3LnA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies one or more agents involved in a transaction, with their role.
/// </summary>
public partial record AgentType1
     : IIsoXmlSerilizable<AgentType1>
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
    /// </summary>
    public IsoAnyBICIdentifier? AnyBIC { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _Wf_bUaHIEeagRbKvRt3LnA
    /// <summary>
    /// Specifies the role of the party in the payment chain.
    /// </summary>
    public required PaymentsPartyType1Code Role { get; init; } 
    
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
        // Not sure how to serialize AnyBIC, multiplicity Unknown
        writer.WriteStartElement(null, "Role", xmlNamespace );
        writer.WriteValue(Role.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static AgentType1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
