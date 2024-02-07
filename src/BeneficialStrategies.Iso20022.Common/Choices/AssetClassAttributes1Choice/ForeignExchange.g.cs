﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ForeignExchange.  ISO2002 ID# _id4oJu94EeW7gabYEJmWIA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassAttributes1Choice;

/// <summary>
/// Asset class is a non-financial instrument of type foreign exchange.
/// </summary>
public partial record ForeignExchange : AssetClassAttributes1Choice_
     , IIsoXmlSerilizable<ForeignExchange>
{
    #nullable enable
    
    /// <summary>
    /// Underlying currency 2 of the currency pair (the currency 1 will be populated in the notional currency).
    /// </summary>
    public required ActiveOrHistoricCurrencyCode OtherNotionalCurrency { get; init; } 
    
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
        writer.WriteStartElement(null, "OthrNtnlCcy", xmlNamespace );
        writer.WriteValue(OtherNotionalCurrency.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new ForeignExchange Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
