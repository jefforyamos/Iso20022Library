﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AmountType1Choice.  ISO2002 ID# _PrUuhtp-Ed-ak6NoX_4Aeg_-1333132724.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Amount of money to be transferred between the debtor and creditor, expressed in debtor's account currency or converted in another currency.
/// </summary>
[KnownType(typeof(AmountType1Choice.InstructedAmount))]
[KnownType(typeof(AmountType1Choice.EquivalentAmount))]
public abstract partial record AmountType1Choice_ : IIsoXmlSerilizable<AmountType1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AmountType1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "InstdAmt" => AmountType1Choice.InstructedAmount.Deserialize(elementWithPayload),
             "EqvtAmt" => AmountType1Choice.EquivalentAmount.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AmountType1Choice choice.")
        };
    }
}
