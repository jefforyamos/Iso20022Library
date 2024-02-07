﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DuePayableAmount.  ISO2002 ID# _QGJCQ9p-Ed-ak6NoX_4Aeg_-888106466.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ReferredDocumentAmount1Choice;

/// <summary>
/// Amount specified is the exact amount due and payable to the creditor.
/// </summary>
public partial record DuePayableAmount : ReferredDocumentAmount1Choice_
     , IIsoXmlSerilizable<DuePayableAmount>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217. The decimal separator is a dot.|Note: A zero amount is considered a positive amount.
    /// </summary>
    public required IsoCurrencyAndAmount Value { get; init; } 
    
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
        writer.WriteStartElement(null, "DuePyblAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoCurrencyAndAmount(Value)); // data type CurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static new DuePayableAmount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
