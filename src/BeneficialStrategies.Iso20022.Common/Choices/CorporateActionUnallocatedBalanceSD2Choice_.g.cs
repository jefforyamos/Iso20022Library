﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionUnallocatedBalanceSD2Choice.  ISO2002 ID# _20nwsaIQEeS6IulNYwkZBg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice amongst various balance types related to unallocated payment.
/// </summary>
[KnownType(typeof(CorporateActionUnallocatedBalanceSD2Choice.TotalEligibleBalance))]
[KnownType(typeof(CorporateActionUnallocatedBalanceSD2Choice.BorrowedBalance))]
[KnownType(typeof(CorporateActionUnallocatedBalanceSD2Choice.CollateralInBalance))]
[KnownType(typeof(CorporateActionUnallocatedBalanceSD2Choice.CollateralOutBalance))]
[KnownType(typeof(CorporateActionUnallocatedBalanceSD2Choice.OnLoanBalance))]
[KnownType(typeof(CorporateActionUnallocatedBalanceSD2Choice.PendingDeliveryBalance))]
[KnownType(typeof(CorporateActionUnallocatedBalanceSD2Choice.PendingReceiptBalance))]
public abstract partial record CorporateActionUnallocatedBalanceSD2Choice_ : IIsoXmlSerilizable<CorporateActionUnallocatedBalanceSD2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CorporateActionUnallocatedBalanceSD2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "TtlElgblBal" => CorporateActionUnallocatedBalanceSD2Choice.TotalEligibleBalance.Deserialize(elementWithPayload),
             "BrrwdBal" => CorporateActionUnallocatedBalanceSD2Choice.BorrowedBalance.Deserialize(elementWithPayload),
             "CollInBal" => CorporateActionUnallocatedBalanceSD2Choice.CollateralInBalance.Deserialize(elementWithPayload),
             "CollOutBal" => CorporateActionUnallocatedBalanceSD2Choice.CollateralOutBalance.Deserialize(elementWithPayload),
             "OnLnBal" => CorporateActionUnallocatedBalanceSD2Choice.OnLoanBalance.Deserialize(elementWithPayload),
             "PdgDlvryBal" => CorporateActionUnallocatedBalanceSD2Choice.PendingDeliveryBalance.Deserialize(elementWithPayload),
             "PdgRctBal" => CorporateActionUnallocatedBalanceSD2Choice.PendingReceiptBalance.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CorporateActionUnallocatedBalanceSD2Choice choice.")
        };
    }
}
