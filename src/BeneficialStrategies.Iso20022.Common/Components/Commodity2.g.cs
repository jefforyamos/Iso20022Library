﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Commodity2.  ISO2002 ID# _l0hO0BYHEeejf-cbr8l5qw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial instrument representing ownership of an amount of a commodity.
/// </summary>
public partial record Commodity2
     : IIsoXmlSerilizable<Commodity2>
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
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MktVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd24Amount(MarketValue)); // data type ActiveCurrencyAnd24Amount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CmmdtyTp", xmlNamespace );
        CommodityType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static Commodity2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
