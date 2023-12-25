﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalDebtorActivationCancellationReasonCode.  ISO2002 ID# _90jEzPGAEemQ7oqCO5NTQw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the debtor activation cancellation reason code, as published in an external debtor activation cancellation reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_90jEzPGAEemQ7oqCO5NTQw")]
[Description(@"Specifies the debtor activation cancellation reason code, as published in an external debtor activation cancellation reason code set. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalDebtorActivationCancellationReasonCode
{
    /// <summary>
    /// Duplication.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uvBsMPRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    AM05,
    
    /// <summary>
    /// Reference is not unique.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uvBsM_RYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    RF01,
    
    /// <summary>
    /// Regulatory Reason.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uvK2IPRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RR04,
    
    /// <summary>
    /// Technical rejection.
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_90jEzfGAEemQ7oqCO5NTQw")]
    [Description(@"Technical rejection.")]
    TRJT,
    
    /// <summary>
    /// Unknown creditor.
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_uvUnIPRYEeuLhpyIdtJzwg")]
    [Description(@"Unknown creditor.")]
    UCRD,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalDebtorActivationCancellationReasonCodeMetadataExtensions
{
    private static readonly ExternalDebtorActivationCancellationReasonCodeDropdownSource _dropdownSource = new ExternalDebtorActivationCancellationReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalDebtorActivationCancellationReasonCodeDropdownRow GetMetadata(this ExternalDebtorActivationCancellationReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


