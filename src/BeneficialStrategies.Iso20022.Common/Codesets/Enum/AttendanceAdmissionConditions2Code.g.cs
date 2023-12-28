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
    /// Any attendee must be a shareholder themselves.
    /// Encoded/decoded by serializers as "AllowedForShareholder".
    /// </summary>
    [EnumMember(Value = "MASH")]
    [IsoId("_X7kGQfNhEeqRfth943bvEA")]
    [Description(@"Any attendee must be a shareholder themselves.")]
    AllowedForShareholder,
    
    /// <summary>
    /// Attendee must be a shareholder registered in company stock ledger book.
    /// Encoded/decoded by serializers as "AllowedIfRegisteredInStockLedger".
    /// </summary>
    [EnumMember(Value = "MASL")]
    [IsoId("_YBXMQfNhEeqRfth943bvEA")]
    [Description(@"Attendee must be a shareholder registered in company stock ledger book.")]
    AllowedIfRegisteredInStockLedger,
    
    /// <summary>
    /// Attendees acting on behalf of registered holder must have a valid power of attorney (POA) and/or proof of holding.
    /// Encoded/decoded by serializers as "AllowedOnBehalf".
    /// </summary>
    [EnumMember(Value = "MAPO")]
    [IsoId("_YGuNYfNhEeqRfth943bvEA")]
    [Description(@"Attendees acting on behalf of registered holder must have a valid power of attorney (POA) and/or proof of holding.")]
    AllowedOnBehalf,
    
    /// <summary>
    /// Attendees will be placed on a attendee list and must bring photographic identification with them.
    /// Encoded/decoded by serializers as "AllowedWithAttendeeList".
    /// </summary>
    [EnumMember(Value = "MAAL")]
    [IsoId("_YLn7gfNhEeqRfth943bvEA")]
    [Description(@"Attendees will be placed on a attendee list and must bring photographic identification with them.")]
    AllowedWithAttendeeList,
    
    /// <summary>
    /// Attendees will be placed on a attendee list or issued with a letter of representation, and must bring photographic identification with them.
    /// Encoded/decoded by serializers as "AllowedWithLetterOfRepresentation".
    /// </summary>
    [EnumMember(Value = "MALR")]
    [IsoId("_YRbokfNhEeqRfth943bvEA")]
    [Description(@"Attendees will be placed on a attendee list or issued with a letter of representation, and must bring photographic identification with them.")]
    AllowedWithLetterOfRepresentation,
    
    /// <summary>
    /// Attendees must request proof of holding and register for attendance directly with Issuer.
    /// Encoded/decoded by serializers as "AllowedWithProof".
    /// </summary>
    [EnumMember(Value = "MAHI")]
    [IsoId("_YWV9wfNhEeqRfth943bvEA")]
    [Description(@"Attendees must request proof of holding and register for attendance directly with Issuer.")]
    AllowedWithProof,
    
    /// <summary>
    /// Attendees will be issued an admission ticket and must bring photographic identification with them.
    /// Encoded/decoded by serializers as "AllowedWithTicket".
    /// </summary>
    [EnumMember(Value = "MATK")]
    [IsoId("_YaNKEfNhEeqRfth943bvEA")]
    [Description(@"Attendees will be issued an admission ticket and must bring photographic identification with them.")]
    AllowedWithTicket,
    
    /// <summary>
    /// Attendee must be a delegate of the shareholder registered in the company stock ledger book.
    /// Encoded/decoded by serializers as "DelegateAllowedIfRegisteredInStockLedger".
    /// </summary>
    [EnumMember(Value = "MADS")]
    [IsoId("_YeOHYfNhEeqRfth943bvEA")]
    [Description(@"Attendee must be a delegate of the shareholder registered in the company stock ledger book.")]
    DelegateAllowedIfRegisteredInStockLedger,
    
    /// <summary>
    /// Meeting attendance is not possible.
    /// Encoded/decoded by serializers as "NotPossible".
    /// </summary>
    [EnumMember(Value = "MANP")]
    [IsoId("_YhpO0fNhEeqRfth943bvEA")]
    [Description(@"Meeting attendance is not possible.")]
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


