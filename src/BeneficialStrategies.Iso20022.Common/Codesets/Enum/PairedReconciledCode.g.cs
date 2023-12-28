﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PairedReconciledCode.  ISO2002 ID# _8y6XACmsEeerta_tWXAsWQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Common report status for all individual reports sent / received.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8y6XACmsEeerta_tWXAsWQ")]
[Description(@"Common report status for all individual reports sent / received.")]
public enum PairedReconciledCode
{
    /// <summary>
    /// Reconciled.
    /// Encoded/decoded by serializers as "RECO".
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_AjtvICmtEeerta_tWXAsWQ")]
    [Description(@"Reconciled.")]
    Reconciled,
    
    /// <summary>
    /// Paired.
    /// Encoded/decoded by serializers as "PARD".
    /// </summary>
    [EnumMember(Value = "PARD")]
    [IsoId("_BvjQICmtEeerta_tWXAsWQ")]
    [Description(@"Paired.")]
    Paired,
    
    /// <summary>
    /// Status should be reported when the loan is unpaired.
    /// Encoded/decoded by serializers as "UNPR".
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_U0AQkGofEeu35dLEXN5XLw")]
    [Description(@"Status should be reported when the loan is unpaired.")]
    Unpaired,
    
    /// <summary>
    /// Status should be reported when the loan was paired and matched.
    /// Encoded/decoded by serializers as "LNRC".
    /// </summary>
    [EnumMember(Value = "LNRC")]
    [IsoId("_C-AocHBLEeuTl53AHNKO7w")]
    [Description(@"Status should be reported when the loan was paired and matched.")]
    LoanReconciled,
    
    /// <summary>
    /// Status should be reported when the collateral associated with the loan(s) was matched.
    /// Encoded/decoded by serializers as "CLRC".
    /// </summary>
    [EnumMember(Value = "CLRC")]
    [IsoId("_S6_CgHBLEeuTl53AHNKO7w")]
    [Description(@"Status should be reported when the collateral associated with the loan(s) was matched.")]
    CollateralReconciled,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PairedReconciledCodeMetadataExtensions
{
    private static readonly PairedReconciledCodeDropdownSource _dropdownSource = new PairedReconciledCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPairedReconciledCodeDropdownRow GetMetadata(this PairedReconciledCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

