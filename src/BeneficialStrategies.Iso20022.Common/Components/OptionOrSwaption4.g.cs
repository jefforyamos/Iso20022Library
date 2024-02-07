﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OptionOrSwaption4.  ISO2002 ID# _5YqYgagAEeW_OId9wS8dsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Option or swaption related attributes.
/// </summary>
public partial record OptionOrSwaption4
     : IIsoXmlSerilizable<OptionOrSwaption4>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of the Option whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset).
    /// </summary>
    public OptionType2Code? OptionType { get; init; } 
    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    public SecuritiesTransactionPrice3Choice_? StrikePrice { get; init; } 
    /// <summary>
    /// Indication as to whether the option may be exercised only at a fixed date (European, and Asian style), a series of pre-specified dates (Bermudan) or at any time during the life of the contract (American style). This field does not have to be populated for ISIN instruments.
    /// </summary>
    public OptionStyle6Code? OptionExerciseStyle { get; init; } 
    /// <summary>
    /// In case of swaptions, maturity date of the underlying swap.
    /// </summary>
    public IsoISODate? MaturityDateOfUnderlying { get; init; } 
    
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
        if (OptionType is OptionType2Code OptionTypeValue)
        {
            writer.WriteStartElement(null, "OptnTp", xmlNamespace );
            writer.WriteValue(OptionTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (StrikePrice is SecuritiesTransactionPrice3Choice_ StrikePriceValue)
        {
            writer.WriteStartElement(null, "StrkPric", xmlNamespace );
            StrikePriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionExerciseStyle is OptionStyle6Code OptionExerciseStyleValue)
        {
            writer.WriteStartElement(null, "OptnExrcStyle", xmlNamespace );
            writer.WriteValue(OptionExerciseStyleValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (MaturityDateOfUnderlying is IsoISODate MaturityDateOfUnderlyingValue)
        {
            writer.WriteStartElement(null, "MtrtyDtOfUndrlyg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(MaturityDateOfUnderlyingValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static OptionOrSwaption4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
