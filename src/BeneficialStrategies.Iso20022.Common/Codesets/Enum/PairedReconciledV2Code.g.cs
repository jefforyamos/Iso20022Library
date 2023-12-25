﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PairedReconciledV2Code.  ISO2002 ID# _YsCg1ph8EeumhIk_Pv20Lg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Common report status for all individual reports sent / received.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YsCg1ph8EeumhIk_Pv20Lg")]
[Description(@"Common report status for all individual reports sent / received.")]
public enum PairedReconciledV2Code
{
    /// <summary>
    /// Both loan and collateral matched.
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_YsCg2Zh8EeumhIk_Pv20Lg")]
    [Description(@"Both loan and collateral matched.")]
    RECO,
    
    /// <summary>
    /// Loan is paired, but not reconciled.
    /// </summary>
    [EnumMember(Value = "PARD")]
    [IsoId("_YsCg2Jh8EeumhIk_Pv20Lg")]
    [Description(@"Loan is paired, but not reconciled.")]
    PARD,
    
    /// <summary>
    /// Loan is unpaired.
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_YsCg25h8EeumhIk_Pv20Lg")]
    [Description(@"Loan is unpaired.")]
    UNPR,
    
    /// <summary>
    /// Loan paired and matched.
    /// </summary>
    [EnumMember(Value = "LNRC")]
    [IsoId("_YsCg2ph8EeumhIk_Pv20Lg")]
    [Description(@"Loan paired and matched.")]
    LNRC,
    
    /// <summary>
    /// Collateral associated with the loan(s) matched.
    /// </summary>
    [EnumMember(Value = "CLRC")]
    [IsoId("_YsCg15h8EeumhIk_Pv20Lg")]
    [Description(@"Collateral associated with the loan(s) matched.")]
    CLRC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PairedReconciledV2CodeMetadataExtensions
{
    private static readonly PairedReconciledV2CodeDropdownSource _dropdownSource = new PairedReconciledV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPairedReconciledV2CodeDropdownRow GetMetadata(this PairedReconciledV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


