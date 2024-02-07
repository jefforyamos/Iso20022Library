﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PriceAndDirection1.  ISO2002 ID# _m-cPtfNBEeCuA5Tr22BnwA_127397945.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Price and an indication of whether it is a increase or a decrease.
/// </summary>
public partial record PriceAndDirection1
     : IIsoXmlSerilizable<PriceAndDirection1>
{
    #nullable enable
    
    /// <summary>
    /// Currency and value.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAnd13DecimalAmount Value { get; init; } 
    /// <summary>
    /// Indicates that the value is positive or negative.
    /// </summary>
    public IsoPlusOrMinusIndicator? Sign { get; init; } 
    
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
        writer.WriteStartElement(null, "Val", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAnd13DecimalAmount(Value)); // data type ActiveOrHistoricCurrencyAnd13DecimalAmount System.Decimal
        writer.WriteEndElement();
        if (Sign is IsoPlusOrMinusIndicator SignValue)
        {
            writer.WriteStartElement(null, "Sgn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPlusOrMinusIndicator(SignValue)); // data type PlusOrMinusIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static PriceAndDirection1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
