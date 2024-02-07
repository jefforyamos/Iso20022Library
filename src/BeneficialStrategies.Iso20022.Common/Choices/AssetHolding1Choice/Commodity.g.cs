﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Commodity.  ISO2002 ID# _SUOCgBYIEeejf-cbr8l5qw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AssetHolding1Choice;

/// <summary>
/// Mark-to-market pre-haircut value of other commodity collateral.
/// </summary>
public partial record Commodity : AssetHolding1Choice_
     , IIsoXmlSerilizable<Commodity>
{
    #nullable enable
    
    /// <summary>
    /// Mark-to-market pre-haircut value.
    /// </summary>
    public required IsoActiveCurrencyAnd24Amount MarketValue { get; init; } 
    /// <summary>
    /// Specifies the type of commodity.
    /// </summary>
    public required AssetClassDetailedSubProductType1Choice_ CommodityType { get; init; } 
    
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
        writer.WriteStartElement(null, "MktVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd24Amount(MarketValue)); // data type ActiveCurrencyAnd24Amount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CmmdtyTp", xmlNamespace );
        CommodityType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new Commodity Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
