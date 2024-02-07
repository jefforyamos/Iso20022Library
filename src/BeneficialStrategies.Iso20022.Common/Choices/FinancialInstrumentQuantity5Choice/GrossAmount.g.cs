﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for GrossAmount.  ISO2002 ID# _Soaxxdp-Ed-ak6NoX_4Aeg_1036647225.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity5Choice;

/// <summary>
/// Amount of money used to derive the quantity of investment fund units to be sold, including all charges, commissions, and tax.
/// </summary>
public partial record GrossAmount : FinancialInstrumentQuantity5Choice_
     , IIsoXmlSerilizable<GrossAmount>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// A number of monetary units specified in an active or a historic currency where the unit of currency is explicit and compliant with ISO 4217.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Value { get; init; } 
    
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
        writer.WriteStartElement(null, "GrssAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(Value)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static new GrossAmount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
