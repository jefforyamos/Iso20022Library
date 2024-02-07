﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmortisedValue.  ISO2002 ID# _ptGAlTi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity43Choice;

/// <summary>
/// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond's principal amount.
/// </summary>
public partial record AmortisedValue : FinancialInstrumentQuantity43Choice_
     , IIsoXmlSerilizable<AmortisedValue>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Number of monetary units specified in a currency where the unit of currency is implied by the context and compliant with ISO 4217. The decimal separator is a dot.|Note: a zero amount is considered a positive amount.
    /// </summary>
    public required IsoRestrictedFINImpliedCurrencyAndAmount Value { get; init; } 
    
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
        writer.WriteStartElement(null, "AmtsdVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINImpliedCurrencyAndAmount(Value)); // data type RestrictedFINImpliedCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static new AmortisedValue Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
