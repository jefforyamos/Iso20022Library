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
[Derivations(typeof(PairedReconciled3Code))]
// External derivations that should be provided by the proper interface are: 
public enum PairedReconciledV2Code
{
    /// <summary>
    /// Both loan and collateral matched.
    /// Encoded/decoded by serializers as "RECO".
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_YsCg2Zh8EeumhIk_Pv20Lg")]
    [Description(@"Both loan and collateral matched.")]
    Reconciled,
    
    /// <summary>
    /// Loan is paired, but not reconciled.
    /// Encoded/decoded by serializers as "PARD".
    /// </summary>
    [EnumMember(Value = "PARD")]
    [IsoId("_YsCg2Jh8EeumhIk_Pv20Lg")]
    [Description(@"Loan is paired, but not reconciled.")]
    Paired,
    
    /// <summary>
    /// Loan is unpaired.
    /// Encoded/decoded by serializers as "UNPR".
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_YsCg25h8EeumhIk_Pv20Lg")]
    [Description(@"Loan is unpaired.")]
    Unpaired,
    
    /// <summary>
    /// Loan paired and matched.
    /// Encoded/decoded by serializers as "LNRC".
    /// </summary>
    [EnumMember(Value = "LNRC")]
    [IsoId("_YsCg2ph8EeumhIk_Pv20Lg")]
    [Description(@"Loan paired and matched.")]
    LoanReconciled,
    
    /// <summary>
    /// Collateral associated with the loan(s) matched.
    /// Encoded/decoded by serializers as "CLRC".
    /// </summary>
    [EnumMember(Value = "CLRC")]
    [IsoId("_YsCg15h8EeumhIk_Pv20Lg")]
    [Description(@"Collateral associated with the loan(s) matched.")]
    CollateralReconciled,
    
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


