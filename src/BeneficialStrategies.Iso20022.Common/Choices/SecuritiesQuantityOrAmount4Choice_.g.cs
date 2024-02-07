﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesQuantityOrAmount4Choice.  ISO2002 ID# _Hvo4mbXQEeiTob_PrFFUxA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between securities quantities or an amount.
/// </summary>
[KnownType(typeof(SecuritiesQuantityOrAmount4Choice.SecuritiesQuantity))]
[KnownType(typeof(SecuritiesQuantityOrAmount4Choice.InstructedAmount))]
public abstract partial record SecuritiesQuantityOrAmount4Choice_ : IIsoXmlSerilizable<SecuritiesQuantityOrAmount4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SecuritiesQuantityOrAmount4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "SctiesQty" => SecuritiesQuantityOrAmount4Choice.SecuritiesQuantity.Deserialize(elementWithPayload),
             "InstdAmt" => SecuritiesQuantityOrAmount4Choice.InstructedAmount.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SecuritiesQuantityOrAmount4Choice choice.")
        };
    }
}
