﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AttendanceAdmissionConditions2Code.  ISO2002 ID# _Vuhm8PNhEeqRfth943bvEA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions for physical admittance to a general meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vuhm8PNhEeqRfth943bvEA")]
[Description(@"Specifies the conditions for physical admittance to a general meeting.")]
[DerivedFrom(typeof(AttendanceAdmissionConditionsCode))]
public enum AttendanceAdmissionConditions2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AllowedForShareholder".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_X7kGQfNhEeqRfth943bvEA")]
    [Description(@"??")]
    AllowedForShareholder,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AllowedIfRegisteredInStockLedger".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YBXMQfNhEeqRfth943bvEA")]
    [Description(@"??")]
    AllowedIfRegisteredInStockLedger,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AllowedOnBehalf".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YGuNYfNhEeqRfth943bvEA")]
    [Description(@"??")]
    AllowedOnBehalf,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AllowedWithAttendeeList".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YLn7gfNhEeqRfth943bvEA")]
    [Description(@"??")]
    AllowedWithAttendeeList,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AllowedWithLetterOfRepresentation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YRbokfNhEeqRfth943bvEA")]
    [Description(@"??")]
    AllowedWithLetterOfRepresentation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AllowedWithProof".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YWV9wfNhEeqRfth943bvEA")]
    [Description(@"??")]
    AllowedWithProof,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AllowedWithTicket".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YaNKEfNhEeqRfth943bvEA")]
    [Description(@"??")]
    AllowedWithTicket,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DelegateAllowedIfRegisteredInStockLedger".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YeOHYfNhEeqRfth943bvEA")]
    [Description(@"??")]
    DelegateAllowedIfRegisteredInStockLedger,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotPossible".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YhpO0fNhEeqRfth943bvEA")]
    [Description(@"??")]
    NotPossible,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AttendanceAdmissionConditions2CodeMetadataExtensions
{
    private static readonly AttendanceAdmissionConditions2CodeDropdownSource _dropdownSource = new AttendanceAdmissionConditions2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAttendanceAdmissionConditions2CodeDropdownRow GetMetadata(this AttendanceAdmissionConditions2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

