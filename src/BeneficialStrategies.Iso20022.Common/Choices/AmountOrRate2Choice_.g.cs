﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AmountOrRate2Choice.  ISO2002 ID# _Ac_TddokEeC60axPepSq7g_1944068516.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between an amount or a rate.
/// </summary>
[KnownType(typeof(AmountOrRate2Choice.Amount))]
[KnownType(typeof(AmountOrRate2Choice.Rate))]
public abstract partial record AmountOrRate2Choice_ : IIsoXmlSerilizable<AmountOrRate2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AmountOrRate2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Amt" => AmountOrRate2Choice.Amount.Deserialize(elementWithPayload),
             "Rate" => AmountOrRate2Choice.Rate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AmountOrRate2Choice choice.")
        };
    }
}
