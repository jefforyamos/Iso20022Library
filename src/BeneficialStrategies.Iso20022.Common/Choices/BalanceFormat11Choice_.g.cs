﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BalanceFormat11Choice.  ISO2002 ID# _JBUKmxuyEeyhRdHRjakS2w.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between balance, eligible balance and not eligible balance formats.
/// </summary>
[KnownType(typeof(BalanceFormat11Choice.Balance))]
[KnownType(typeof(BalanceFormat11Choice.EligibleBalance))]
[KnownType(typeof(BalanceFormat11Choice.NotEligibleBalance))]
public abstract partial record BalanceFormat11Choice_ : IIsoXmlSerilizable<BalanceFormat11Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static BalanceFormat11Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Bal" => BalanceFormat11Choice.Balance.Deserialize(elementWithPayload),
             "ElgblBal" => BalanceFormat11Choice.EligibleBalance.Deserialize(elementWithPayload),
             "NotElgblBal" => BalanceFormat11Choice.NotEligibleBalance.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid BalanceFormat11Choice choice.")
        };
    }
}
