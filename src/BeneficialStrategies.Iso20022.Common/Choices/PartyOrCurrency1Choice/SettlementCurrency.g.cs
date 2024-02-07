﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SettlementCurrency.  ISO2002 ID# _n9oL79QiEeKvJeoOII0e7w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PartyOrCurrency1Choice;

/// <summary>
/// Currency for the settlement.
/// </summary>
public partial record SettlementCurrency : PartyOrCurrency1Choice_
     , IIsoXmlSerilizable<SettlementCurrency>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// A code allocated to a currency by a Maintenance Agency under an international identification scheme as described in the latest edition of the international standard ISO 4217 "Codes for the representation of currencies and funds".
    /// </summary>
    public required ActiveCurrencyCode Value { get; init; } 
    
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
        writer.WriteStartElement(null, "SttlmCcy", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new SettlementCurrency Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
