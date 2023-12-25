﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalDebtorActivationStatusReasonCode.  ISO2002 ID# _pe4x5OIwEeqbls7Gk4-ckA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the debtor activation status reason code, as published in an external debtor activation status reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pe4x5OIwEeqbls7Gk4-ckA")]
[Description(@"Specifies the debtor activation status reason code, as published in an external debtor activation status reason code set. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalDebtorActivationStatusReasonCode
{
    /// <summary>
    /// Already existing creditor.
    /// </summary>
    [EnumMember(Value = "ACRD")]
    [IsoId("_uvoJJvRYEeuLhpyIdtJzwg")]
    [Description(@"Already existing creditor.")]
    ACRD,
    
    /// <summary>
    /// Duplication.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uvoJKfRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    AM05,
    
    /// <summary>
    /// Invalid file format.
    /// </summary>
    [EnumMember(Value = "FF01")]
    [IsoId("_uvxTEPRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid file format.")]
    FF01,
    
    /// <summary>
    /// Reference is not unique.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uvxTE_RYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    RF01,
    
    /// <summary>
    /// Regulatory Reason.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uvxTFvRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RR04,
    
    /// <summary>
    /// Invalid character set.
    /// </summary>
    [EnumMember(Value = "RR10")]
    [IsoId("_uv7EEPRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid character set.")]
    RR10,
    
    /// <summary>
    /// Technical rejection.
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_uv7EE_RYEeuLhpyIdtJzwg")]
    [Description(@"Technical rejection.")]
    TRJT,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalDebtorActivationStatusReasonCodeMetadataExtensions
{
    private static readonly ExternalDebtorActivationStatusReasonCodeDropdownSource _dropdownSource = new ExternalDebtorActivationStatusReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalDebtorActivationStatusReasonCodeDropdownRow GetMetadata(this ExternalDebtorActivationStatusReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


