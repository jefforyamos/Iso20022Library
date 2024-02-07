﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _nZ98bRFaEeKp2ZN13DI_pA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat7Choice;

/// <summary>
/// Number of monetary units specified in a currency.
/// </summary>
public partial record Amount : GrossDividendRateFormat7Choice_
     , IIsoXmlSerilizable<Amount>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// A number of monetary units specified in an active currency where the unit of currency is explicit and compliant with ISO 4217. The number of fractional digits (or minor unit of currency) is not checked as per ISO 4217: It must be lesser than or equal to 13.|Note: The decimal separator is a dot.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(Value)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
        writer.WriteEndElement();
    }
    public static new Amount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
