﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Intermediary39.  ISO2002 ID# _9npJ5zbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
public partial record Intermediary39
     : IIsoXmlSerilizable<Intermediary39>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    public required PartyIdentification113 Identification { get; init; } 
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    public Account22? Account { get; init; } 
    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; init; } 
    /// <summary>
    /// Capacity of the party executing an order.
    /// </summary>
    public TradingCapacity8Code? TradingPartyCapacity { get; init; } 
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    public InvestmentFundRole2Choice_? Role { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Account is Account22 AccountValue)
        {
            writer.WriteStartElement(null, "Acct", xmlNamespace );
            AccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OrderOriginatorEligibility is OrderOriginatorEligibility1Code OrderOriginatorEligibilityValue)
        {
            writer.WriteStartElement(null, "OrdrOrgtrElgblty", xmlNamespace );
            writer.WriteValue(OrderOriginatorEligibilityValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (TradingPartyCapacity is TradingCapacity8Code TradingPartyCapacityValue)
        {
            writer.WriteStartElement(null, "TradgPtyCpcty", xmlNamespace );
            writer.WriteValue(TradingPartyCapacityValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Role is InvestmentFundRole2Choice_ RoleValue)
        {
            writer.WriteStartElement(null, "Role", xmlNamespace );
            RoleValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Intermediary39 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
