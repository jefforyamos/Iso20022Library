﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DayBookingInstruction1Code.  ISO2002 ID# _aytSpNp-Ed-ak6NoX_4Aeg_1419752225.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes of the nature of execution booking process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aytSpNp-Ed-ak6NoX_4Aeg_1419752225")]
[Description(@"Describes of the nature of execution booking process.")]
[DerivedFrom(typeof(DayBookingInstructionCode))]
public enum DayBookingInstruction1Code
{
    /// <summary>
    /// Can trigger booking without reference to the order initiator.
    /// Encoded/decoded by serializers as "Auto".
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_aytSpdp-Ed-ak6NoX_4Aeg_1465007733")]
    [Description(@"Can trigger booking without reference to the order initiator.")]
    Auto,
    
    /// <summary>
    /// Speak with order initiator before booking.
    /// Encoded/decoded by serializers as "SpeakFirst".
    /// </summary>
    [EnumMember(Value = "TALK")]
    [IsoId("_aytSptp-Ed-ak6NoX_4Aeg_1465007750")]
    [Description(@"Speak with order initiator before booking.")]
    SpeakFirst,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DayBookingInstruction1CodeMetadataExtensions
{
    private static readonly DayBookingInstruction1CodeDropdownSource _dropdownSource = new DayBookingInstruction1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDayBookingInstruction1CodeDropdownRow GetMetadata(this DayBookingInstruction1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


