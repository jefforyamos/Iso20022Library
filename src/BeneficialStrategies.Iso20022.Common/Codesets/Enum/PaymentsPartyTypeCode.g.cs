﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentsPartyTypeCode.  ISO2002 ID# _0lBckKHFEeagRbKvRt3LnA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// CodeSet identifying parties involved in a payments transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0lBckKHFEeagRbKvRt3LnA")]
[Description(@"CodeSet identifying parties involved in a payments transaction.")]
[Derivations(typeof(PaymentsPartyType1Code),typeof(PaymentsPartyType2Code))]
public enum PaymentsPartyTypeCode
{
    /// <summary>
    /// Debtor agent, creditor agent or financial institution between debtor agent and creditor agent.
    /// Encoded/decoded by serializers as "ALPA".
    /// </summary>
    [EnumMember(Value = "ALPA")]
    [IsoId("_LWHZUKHHEeagRbKvRt3LnA")]
    [Description(@"Debtor agent, creditor agent or financial institution between debtor agent and creditor agent.")]
    AllPaymentsParties,
    
    /// <summary>
    /// Debtor agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.
    /// Encoded/decoded by serializers as "DADE".
    /// </summary>
    [EnumMember(Value = "DADE")]
    [IsoId("_uLQHgFyYEeewBcMu1EH_Gg")]
    [Description(@"Debtor agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.")]
    DebtorAgentOrDebtor,
    
    /// <summary>
    /// Creditor agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.
    /// Encoded/decoded by serializers as "CACR".
    /// </summary>
    [EnumMember(Value = "CACR")]
    [IsoId("_1m_gUFyYEeewBcMu1EH_Gg")]
    [Description(@"Creditor agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.")]
    CreditorAgentOrCreditor,
    
    /// <summary>
    /// Intermediary agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.
    /// Encoded/decoded by serializers as "INAG".
    /// </summary>
    [EnumMember(Value = "INAG")]
    [IsoId("_4ya6gFyYEeewBcMu1EH_Gg")]
    [Description(@"Intermediary agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.")]
    IntermediaryAgent,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentsPartyTypeCodeMetadataExtensions
{
    private static readonly PaymentsPartyTypeCodeDropdownSource _dropdownSource = new PaymentsPartyTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentsPartyTypeCodeDropdownRow GetMetadata(this PaymentsPartyTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


