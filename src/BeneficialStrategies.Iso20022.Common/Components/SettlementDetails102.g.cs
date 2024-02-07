﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDetails102.  ISO2002 ID# _t-54W4FvEeWtPe6Crjmeug.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
/// </summary>
public partial record SettlementDetails102
     : IIsoXmlSerilizable<SettlementDetails102>
{
    #nullable enable
    
    /// <summary>
    /// Indicates the date as known by the two parties to be used for matching purposes when settlement of securities occurs.
    /// </summary>
    public required IsoISODateTime TradeDate { get; init; } 
    /// <summary>
    /// Provides details on either the delivering or receiving settlement parties.
    /// </summary>
    public SettlementParties5Choice_? SettlementParties { get; init; } 
    /// <summary>
    /// Indicates the collateral ownership.
    /// </summary>
    public required CollateralOwnership2 CollateralOwnership { get; init; } 
    
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
        writer.WriteStartElement(null, "TradDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(TradeDate)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (SettlementParties is SettlementParties5Choice_ SettlementPartiesValue)
        {
            writer.WriteStartElement(null, "SttlmPties", xmlNamespace );
            SettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CollOwnrsh", xmlNamespace );
        CollateralOwnership.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static SettlementDetails102 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
