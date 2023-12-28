﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValidationRuleStatus2Code.  ISO2002 ID# _RDOJRh-yEeuxStysDTgLiw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status for the cross-element validation rules.
/// 
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RDOJRh-yEeuxStysDTgLiw")]
[Description(@"Specifies the status for the cross-element validation rules.  Usage: the code set is used when the formal validation rules make reference of an external code sets.")]
[DerivedFrom(typeof(ValidationRuleCode))]
public enum ValidationRuleStatus2Code
{
    /// <summary>
    /// Accepted technical validation.
    /// Encoded/decoded by serializers as "AcceptedTechnicalValidation".
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_nXe9cSAeEeuSiN6KdHu9iw")]
    [Description(@"Accepted technical validation.")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// Accepted customer profile.
    /// Encoded/decoded by serializers as "AcceptedCustomerProfile".
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_nXe9cyAeEeuSiN6KdHu9iw")]
    [Description(@"Accepted customer profile.")]
    AcceptedCustomerProfile,
    
    /// <summary>
    /// Accepted settlement in process.
    /// Encoded/decoded by serializers as "AcceptedSettlementInProcess".
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_nXe9dSAeEeuSiN6KdHu9iw")]
    [Description(@"Accepted settlement in process.")]
    AcceptedSettlementInProcess,
    
    /// <summary>
    /// Accepted settlement completed.
    /// Encoded/decoded by serializers as "AcceptedSettlementCompleted".
    /// </summary>
    [EnumMember(Value = "ACSC")]
    [IsoId("_nXe9dyAeEeuSiN6KdHu9iw")]
    [Description(@"Accepted settlement completed.")]
    AcceptedSettlementCompleted,
    
    /// <summary>
    /// Accepted cancellation request.
    /// Encoded/decoded by serializers as "AcceptedCancellationRequest".
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("_nXe9eSAeEeuSiN6KdHu9iw")]
    [Description(@"Accepted cancellation request.")]
    AcceptedCancellationRequest,
    
    /// <summary>
    /// Accepted with change.
    /// Encoded/decoded by serializers as "AcceptedWithChange".
    /// </summary>
    [EnumMember(Value = "ACWC")]
    [IsoId("_nXe9eyAeEeuSiN6KdHu9iw")]
    [Description(@"Accepted with change.")]
    AcceptedWithChange,
    
    /// <summary>
    /// Pending.
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_nXe9fSAeEeuSiN6KdHu9iw")]
    [Description(@"Pending.")]
    Pending,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ValidationRuleStatus2CodeMetadataExtensions
{
    private static readonly ValidationRuleStatus2CodeDropdownSource _dropdownSource = new ValidationRuleStatus2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IValidationRuleStatus2CodeDropdownRow GetMetadata(this ValidationRuleStatus2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


