﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementParties35.  ISO2002 ID# _zjvwkTchEeOA3chqL9a4Rw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
public partial record SettlementParties35
     : IIsoXmlSerilizable<SettlementParties35>
{
    #nullable enable
    
    /// <summary>
    /// Parties through which settlement is to take place.
    /// </summary>
    public required SettlementParties32 StandingSettlementParties { get; init; } 
    /// <summary>
    /// Identifier needed for settlement purposes. This identifier could be, for example, an identifier that identifies an institution or agent at a CDS or ICSD (Depository Trust Clearing Corporation (DTC) Institution ID or DTC Agent ID). It could also be a local tax identification number or an ‘investor identification’, as mandated by local market practice.
    /// </summary>
    public GenericIdentification49? LocalMarketIdentification { get; init; } 
    /// <summary>
    /// Registration information required for settlement. For some markets, for example, Spain (Iberclear) registration details are mandatory and should be part of the SSI. In some cases, the name of the institution is different than what's provided in the BIC Directory. If this is the case, the name should be provided.
    /// </summary>
    public PartyIdentification99Choice_? RegistrationDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "StgSttlmPties", xmlNamespace );
        StandingSettlementParties.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (LocalMarketIdentification is GenericIdentification49 LocalMarketIdentificationValue)
        {
            writer.WriteStartElement(null, "LclMktId", xmlNamespace );
            LocalMarketIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RegistrationDetails is PartyIdentification99Choice_ RegistrationDetailsValue)
        {
            writer.WriteStartElement(null, "RegnDtls", xmlNamespace );
            RegistrationDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SettlementParties35 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
