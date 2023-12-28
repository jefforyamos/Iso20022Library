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
    /// ??
    /// Encoded/decoded by serializers as "AcceptedTechnicalValidation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nXe9cSAeEeuSiN6KdHu9iw")]
    [Description(@"??")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedCustomerProfile".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nXe9cyAeEeuSiN6KdHu9iw")]
    [Description(@"??")]
    AcceptedCustomerProfile,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedSettlementInProcess".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nXe9dSAeEeuSiN6KdHu9iw")]
    [Description(@"??")]
    AcceptedSettlementInProcess,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedSettlementCompleted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nXe9dyAeEeuSiN6KdHu9iw")]
    [Description(@"??")]
    AcceptedSettlementCompleted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedCancellationRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nXe9eSAeEeuSiN6KdHu9iw")]
    [Description(@"??")]
    AcceptedCancellationRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedWithChange".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nXe9eyAeEeuSiN6KdHu9iw")]
    [Description(@"??")]
    AcceptedWithChange,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nXe9fSAeEeuSiN6KdHu9iw")]
    [Description(@"??")]
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

