﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BalanceFormat12Choice.  ISO2002 ID# _KADDNRuyEeyhRdHRjakS2w.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between balance, eligible balance and not eligible balance formats.
/// </summary>
[KnownType(typeof(BalanceFormat12Choice.Balance))]
[KnownType(typeof(BalanceFormat12Choice.EligibleBalance))]
[KnownType(typeof(BalanceFormat12Choice.NotEligibleBalance))]
[KnownType(typeof(BalanceFormat12Choice.FullPeriodUnits))]
[KnownType(typeof(BalanceFormat12Choice.PartWayPeriodUnits))]
public abstract partial record BalanceFormat12Choice_ : IIsoXmlSerilizable<BalanceFormat12Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static BalanceFormat12Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Bal" => BalanceFormat12Choice.Balance.Deserialize(elementWithPayload),
             "ElgblBal" => BalanceFormat12Choice.EligibleBalance.Deserialize(elementWithPayload),
             "NotElgblBal" => BalanceFormat12Choice.NotEligibleBalance.Deserialize(elementWithPayload),
             "FullPrdUnits" => BalanceFormat12Choice.FullPeriodUnits.Deserialize(elementWithPayload),
             "PartWayPrdUnits" => BalanceFormat12Choice.PartWayPeriodUnits.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid BalanceFormat12Choice choice.")
        };
    }
}
