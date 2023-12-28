﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentsPartyType2Code.  ISO2002 ID# _C4Fi8FyZEeewBcMu1EH_Gg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// CodeSet identifying parties involved in a payments transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_C4Fi8FyZEeewBcMu1EH_Gg")]
[Description(@"CodeSet identifying parties involved in a payments transaction.")]
[DerivedFrom(typeof(PaymentsPartyTypeCode))]
public enum PaymentsPartyType2Code
{
    /// <summary>
    /// Creditor agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.
    /// Encoded/decoded by serializers as "CreditorAgentOrCreditor".
    /// </summary>
    [EnumMember(Value = "CACR")]
    [IsoId("_IKhF4VyZEeewBcMu1EH_Gg")]
    [Description(@"Creditor agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.")]
    CreditorAgentOrCreditor,
    
    /// <summary>
    /// Debtor agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.
    /// Encoded/decoded by serializers as "DebtorAgentOrDebtor".
    /// </summary>
    [EnumMember(Value = "DADE")]
    [IsoId("_IRPY8VyZEeewBcMu1EH_Gg")]
    [Description(@"Debtor agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.")]
    DebtorAgentOrDebtor,
    
    /// <summary>
    /// Intermediary agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.
    /// Encoded/decoded by serializers as "IntermediaryAgent".
    /// </summary>
    [EnumMember(Value = "INAG")]
    [IsoId("_IWyAQVyZEeewBcMu1EH_Gg")]
    [Description(@"Intermediary agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.")]
    IntermediaryAgent,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentsPartyType2CodeMetadataExtensions
{
    private static readonly PaymentsPartyType2CodeDropdownSource _dropdownSource = new PaymentsPartyType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentsPartyType2CodeDropdownRow GetMetadata(this PaymentsPartyType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


