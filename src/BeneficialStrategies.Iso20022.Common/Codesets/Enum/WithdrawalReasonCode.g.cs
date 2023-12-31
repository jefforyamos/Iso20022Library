﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for WithdrawalReasonCode.  ISO2002 ID# _1vTlA5EkEeKcLcxonNWTXg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason that an alleged trade is withdrawn.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1vTlA5EkEeKcLcxonNWTXg")]
[Description(@"Specifies the reason that an alleged trade is withdrawn.")]
[Derivations(typeof(WithdrawalReason1Code))]
// External derivations that should be provided by the proper interface are: 
public enum WithdrawalReasonCode
{
    /// <summary>
    /// Alleged trade is rescinded.
    /// Encoded/decoded by serializers as "RSCD".
    /// </summary>
    [EnumMember(Value = "RSCD")]
    [IsoId("_N4ADUJElEeKcLcxonNWTXg")]
    [Description(@"Alleged trade is rescinded.")]
    Rescinded,
    
    /// <summary>
    /// Alleged trade is rejected.
    /// Encoded/decoded by serializers as "RJCT".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_OBsK0JElEeKcLcxonNWTXg")]
    [Description(@"Alleged trade is rejected.")]
    Rejected,
    
    /// <summary>
    /// Alleged trade is withdrawn due to an amendment.
    /// Encoded/decoded by serializers as "WTDN".
    /// </summary>
    [EnumMember(Value = "WTDN")]
    [IsoId("_OKLYcJElEeKcLcxonNWTXg")]
    [Description(@"Alleged trade is withdrawn due to an amendment.")]
    Withdrawn,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class WithdrawalReasonCodeMetadataExtensions
{
    private static readonly WithdrawalReasonCodeDropdownSource _dropdownSource = new WithdrawalReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IWithdrawalReasonCodeDropdownRow GetMetadata(this WithdrawalReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


