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
    /// ??
    /// Encoded/decoded by serializers as "BlockingTillMeetingDate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vqyAYTUIEe2tRf29bleifQ")]
    [Description(@"??")]
    BlockingTillMeetingDate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unknown".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xUSU0TUIEe2tRf29bleifQ")]
    [Description(@"??")]
    Unknown,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NarrativeUnblockingDate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xjoYYTUIEe2tRf29bleifQ")]
    [Description(@"??")]
    NarrativeUnblockingDate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BlockingTillRecordDate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yZbX8TUIEe2tRf29bleifQ")]
    [Description(@"??")]
    BlockingTillRecordDate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BlockingTillPremiumPaymentDate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_p3ogkTUJEe2tRf29bleifQ")]
    [Description(@"??")]
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

