﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransactionQuantities1Choice.  ISO2002 ID# _RU0b5tp-Ed-ak6NoX_4Aeg_-584387568.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the quantities (eg of securities) in the underlying transaction.
/// </summary>
[KnownType(typeof(TransactionQuantities1Choice.Quantity))]
[KnownType(typeof(TransactionQuantities1Choice.Proprietary))]
public abstract partial record TransactionQuantities1Choice_ : IIsoXmlSerilizable<TransactionQuantities1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static TransactionQuantities1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Qty" => TransactionQuantities1Choice.Quantity.Deserialize(elementWithPayload),
             "Prtry" => TransactionQuantities1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid TransactionQuantities1Choice choice.")
        };
    }
}
