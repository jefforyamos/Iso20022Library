﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectedStatusReason4Code.  ISO2002 ID# _ViiZhdp-Ed-ak6NoX_4Aeg_-901743273.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ViiZhdp-Ed-ak6NoX_4Aeg_-901743273")]
[Description(@"Specifies the reason for a rejected status.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
public enum RejectedStatusReason4Code
{
    /// <summary>
    /// Instruction has been received after the cut-off time.
    /// Encoded/decoded by serializers as "CUTO".
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("_ViiZhtp-Ed-ak6NoX_4Aeg_-640387122")]
    [Description(@"Instruction has been received after the cut-off time.")]
    CutOffTime = RejectedStatusReasonCode.CutOffTime, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructing party is not allowed to request a cancellation.
    /// Encoded/decoded by serializers as "NALC".
    /// </summary>
    [EnumMember(Value = "NALC")]
    [IsoId("_ViiZh9p-Ed-ak6NoX_4Aeg_-640386732")]
    [Description(@"Instructing party is not allowed to request a cancellation.")]
    NotAllowedToCancel = RejectedStatusReasonCode.NotAllowedToCancel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as "NSLA".
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_ViiZiNp-Ed-ak6NoX_4Aeg_-640386347")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA = RejectedStatusReasonCode.NotCompliantWithSLA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Legally impossible to cancel.
    /// Encoded/decoded by serializers as "LEGL".
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("_VirjcNp-Ed-ak6NoX_4Aeg_-640386174")]
    [Description(@"Legally impossible to cancel.")]
    LegallyImpossible = RejectedStatusReasonCode.LegallyImpossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Another reason for the status rejected.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Virjcdp-Ed-ak6NoX_4Aeg_277257123")]
    [Description(@"Another reason for the status rejected.")]
    Other = RejectedStatusReasonCode.Other, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectedStatusReason4CodeMetadataExtensions
{
    private static readonly RejectedStatusReason4CodeDropdownSource _dropdownSource = new RejectedStatusReason4CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectedStatusReason4CodeDropdownRow GetMetadata(this RejectedStatusReason4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


