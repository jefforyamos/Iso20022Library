﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DiscretionInstructions1.  ISO2002 ID# _SyZ0PNp-Ed-ak6NoX_4Aeg_1464463754.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates on an order that the trader wishes to display one price in the market but will accept trades at another price.
/// </summary>
public partial record DiscretionInstructions1
     : IIsoXmlSerilizable<DiscretionInstructions1>
{
    #nullable enable
    
    /// <summary>
    /// Information for the executing party about the price to be obtained for an order. It is expressed as an offset from a reference price such as the market price or last trade price.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Offset { get; init; } 
    /// <summary>
    /// Indicates whether the offset should be added or subtracted from the related price.
    /// </summary>
    public required IsoPlusOrMinusIndicator OffsetSign { get; init; } 
    /// <summary>
    /// Identify the type of price an offset is related to. The offset can either be added or subtracted.
    /// </summary>
    public required TypeOfDiscretionPrice1Code RelatedPriceType { get; init; } 
    /// <summary>
    /// Describes whether discretion price is static/fixed or floats.
    /// </summary>
    public required MoveType1Code MoveType { get; init; } 
    /// <summary>
    /// Specifies the nature of the resulting discretion price (e.g. or better limit, strict limit etc).
    /// </summary>
    public required IsoMax35Text LimitType { get; init; } 
    /// <summary>
    /// If the calculated discretion price is not a valid tick price, specifies how to round the price (e.g. to be more or less aggressive).
    /// </summary>
    public required IsoMax35Text RoundDirection { get; init; } 
    /// <summary>
    /// The scope of "related to" price of the discretion (e.g. local, global etc).
    /// </summary>
    public required PriceProtectionScope2Code Scope { get; init; } 
    /// <summary>
    /// Describes the type of Discretion Offset.
    /// </summary>
    public required OffsetType1Code OffsetType { get; init; } 
    
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
        writer.WriteStartElement(null, "Offset", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(Offset)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OffsetSgn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoPlusOrMinusIndicator(OffsetSign)); // data type PlusOrMinusIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RltdPricTp", xmlNamespace );
        writer.WriteValue(RelatedPriceType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MvTp", xmlNamespace );
        writer.WriteValue(MoveType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LmtTp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(LimitType)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RndDrctn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(RoundDirection)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Scp", xmlNamespace );
        writer.WriteValue(Scope.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OffsetTp", xmlNamespace );
        writer.WriteValue(OffsetType.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static DiscretionInstructions1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
