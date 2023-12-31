﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DateType10Code.  ISO2002 ID# _sW5NwDUIEe2tRf29bleifQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Date is specified as a fixed code value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sW5NwDUIEe2tRf29bleifQ")]
[Description(@"Date is specified as a fixed code value.")]
[DerivedFrom(typeof(DateTypeCode))]
public enum DateType10Code
{
    /// <summary>
    /// Blocking occurs until and inclusive of the meeting date.
    /// Encoded/decoded by serializers as "BlockingTillMeetingDate".
    /// </summary>
    [EnumMember(Value = "MEET")]
    [IsoId("_vqyAYTUIEe2tRf29bleifQ")]
    [Description(@"Blocking occurs until and inclusive of the meeting date.")]
    BlockingTillMeetingDate,
    
    /// <summary>
    /// Date is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as "Unknown".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_xUSU0TUIEe2tRf29bleifQ")]
    [Description(@"Date is unknown by the sender or has not been established.")]
    Unknown,
    
    /// <summary>
    /// Refer to additional information element for the date until when the securities are blocked.
    /// Encoded/decoded by serializers as "NarrativeUnblockingDate".
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_xjoYYTUIEe2tRf29bleifQ")]
    [Description(@"Refer to additional information element for the date until when the securities are blocked.")]
    NarrativeUnblockingDate,
    
    /// <summary>
    /// Blocking occurs until and inclusive of the record date of the event.
    /// Encoded/decoded by serializers as "BlockingTillRecordDate".
    /// </summary>
    [EnumMember(Value = "RDTE")]
    [IsoId("_yZbX8TUIEe2tRf29bleifQ")]
    [Description(@"Blocking occurs until and inclusive of the record date of the event.")]
    BlockingTillRecordDate,
    
    /// <summary>
    /// Unblocking will occur on payment date of the premium.
    /// Encoded/decoded by serializers as "BlockingTillPremiumPaymentDate".
    /// </summary>
    [EnumMember(Value = "PPYD")]
    [IsoId("_p3ogkTUJEe2tRf29bleifQ")]
    [Description(@"Unblocking will occur on payment date of the premium.")]
    BlockingTillPremiumPaymentDate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DateType10CodeMetadataExtensions
{
    private static readonly DateType10CodeDropdownSource _dropdownSource = new DateType10CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDateType10CodeDropdownRow GetMetadata(this DateType10Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


