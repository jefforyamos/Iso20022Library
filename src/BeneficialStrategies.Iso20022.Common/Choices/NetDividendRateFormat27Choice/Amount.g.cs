﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _cteBQ5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat27Choice;

/// <summary>
/// Number of monetary units specified in a currency.
/// </summary>
public partial record Amount : NetDividendRateFormat27Choice_
     , IIsoXmlSerilizable<Amount>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// A number of monetary units specified in an active currency where the unit of currency is explicit and compliant with ISO 4217. The number of fractional digits (or minor unit of currency) is not checked as per ISO 4217: It must be lesser than or equal to 13.|Note: The decimal separator is a dot.
    /// </summary>
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount Value { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAnd13DecimalAmount(Value)); // data type RestrictedFINActiveCurrencyAnd13DecimalAmount System.Decimal
        writer.WriteEndElement();
    }
    public static new Amount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
