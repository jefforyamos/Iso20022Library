﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNarrative30.  ISO2002 ID# _rbxzgWLLEeWR9ZSfjmHwUA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the registration details.
/// </summary>
public partial record CorporateActionNarrative30
     : IIsoXmlSerilizable<CorporateActionNarrative30>
{
    #nullable enable
    
    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    public IsoMax350Text? RegistrationDetails { get; init; } 
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    public IsoMax350Text? PartyContactNarrative { get; init; } 
    /// <summary>
    /// Provides information required for the certification/breakdown.
    /// </summary>
    public IsoMax350Text? CertificationBreakdown { get; init; } 
    
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
        if (RegistrationDetails is IsoMax350Text RegistrationDetailsValue)
        {
            writer.WriteStartElement(null, "RegnDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(RegistrationDetailsValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (PartyContactNarrative is IsoMax350Text PartyContactNarrativeValue)
        {
            writer.WriteStartElement(null, "PtyCtctNrrtv", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(PartyContactNarrativeValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (CertificationBreakdown is IsoMax350Text CertificationBreakdownValue)
        {
            writer.WriteStartElement(null, "CertfctnBrkdwn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(CertificationBreakdownValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static CorporateActionNarrative30 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
