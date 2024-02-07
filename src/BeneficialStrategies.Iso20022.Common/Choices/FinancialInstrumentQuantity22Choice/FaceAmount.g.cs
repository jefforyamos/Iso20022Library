﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FaceAmount.  ISO2002 ID# _N-fhVwU-EeGZxNLgzisRtw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity22Choice;

/// <summary>
/// Quantity expressed as an amount representing the face amount, that is, the principal, of a debt instrument.
/// </summary>
public partial record FaceAmount : FinancialInstrumentQuantity22Choice_
     , IIsoXmlSerilizable<FaceAmount>
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
        writer.WriteStartElement(null, "FaceAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINImpliedCurrencyAndAmount(Value)); // data type RestrictedFINImpliedCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static new FaceAmount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
