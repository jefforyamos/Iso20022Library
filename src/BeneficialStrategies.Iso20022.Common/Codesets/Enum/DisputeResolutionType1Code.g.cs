﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DisputeResolutionType1Code.  ISO2002 ID# _YcWfRdp-Ed-ak6NoX_4Aeg_-299139141.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the disputed collateral amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YcWfRdp-Ed-ak6NoX_4Aeg_-299139141")]
[Description(@"Specifies the nature of the disputed collateral amount.")]
[DerivedFrom(typeof(DisputeResolutionTypeCode))]
public enum DisputeResolutionType1Code
{
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the collateral.
    /// Encoded/decoded by serializers as "RECO".
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_YcWfRtp-Ed-ak6NoX_4Aeg_-1118092822")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the collateral.")]
    ReconcileCollateral = DisputeResolutionTypeCode.ReconcileCollateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the minimum transfer amount.
    /// Encoded/decoded by serializers as "RMTA".
    /// </summary>
    [EnumMember(Value = "RMTA")]
    [IsoId("_YcWfR9p-Ed-ak6NoX_4Aeg_2050150903")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the minimum transfer amount.")]
    ReconcileMinimumTransferAmount = DisputeResolutionTypeCode.ReconcileMinimumTransferAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the rounding.
    /// Encoded/decoded by serializers as "RERO".
    /// </summary>
    [EnumMember(Value = "RERO")]
    [IsoId("_YcWfSNp-Ed-ak6NoX_4Aeg_-716740705")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the rounding.")]
    ReconcileRounding = DisputeResolutionTypeCode.ReconcileRounding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the valuation frequency.
    /// Encoded/decoded by serializers as "REVF".
    /// </summary>
    [EnumMember(Value = "REVF")]
    [IsoId("_YcgQQNp-Ed-ak6NoX_4Aeg_-754726748")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the valuation frequency.")]
    ReconcileValuationFrequency = DisputeResolutionTypeCode.ReconcileValuationFrequency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the initial margin.
    /// Encoded/decoded by serializers as "RESA".
    /// </summary>
    [EnumMember(Value = "RESA")]
    [IsoId("_YcgQQdp-Ed-ak6NoX_4Aeg_-1509476622")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the initial margin.")]
    ReconcileSegregatedIndependentAmount = DisputeResolutionTypeCode.ReconcileSegregatedIndependentAmount, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DisputeResolutionType1CodeMetadataExtensions
{
    private static readonly DisputeResolutionType1CodeDropdownSource _dropdownSource = new DisputeResolutionType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDisputeResolutionType1CodeDropdownRow GetMetadata(this DisputeResolutionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


