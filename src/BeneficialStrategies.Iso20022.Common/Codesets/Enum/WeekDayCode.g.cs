﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for WeekDayCode.  ISO2002 ID# _vVeyEA3eEeW9YKj3GUmIEw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the day of the week of the delivery.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vVeyEA3eEeW9YKj3GUmIEw")]
[Description(@"Specifies the day of the week of the delivery.")]
[Derivations(typeof(WeekDay2Code),typeof(WeekDay3Code))]
public enum WeekDayCode
{
    /// <summary>
    /// Weekdays.
    /// Encoded/decoded by serializers as "WDAY".
    /// </summary>
    [EnumMember(Value = "WDAY")]
    [IsoId("_xLwXMA3eEeW9YKj3GUmIEw")]
    [Description(@"Weekdays.")]
    Weekdays,
    
    /// <summary>
    /// Weekend.
    /// Encoded/decoded by serializers as "WEND".
    /// </summary>
    [EnumMember(Value = "WEND")]
    [IsoId("_nCYr8BVcEeWLrt6TQWUeiw")]
    [Description(@"Weekend.")]
    Weekend,
    
    /// <summary>
    /// Monday.
    /// Encoded/decoded by serializers as "MOND".
    /// </summary>
    [EnumMember(Value = "MOND")]
    [IsoId("_nKkXkBVcEeWLrt6TQWUeiw")]
    [Description(@"Monday.")]
    Monday,
    
    /// <summary>
    /// Tuesday.
    /// Encoded/decoded by serializers as "TUED".
    /// </summary>
    [EnumMember(Value = "TUED")]
    [IsoId("_nKkXkRVcEeWLrt6TQWUeiw")]
    [Description(@"Tuesday.")]
    Tuesday,
    
    /// <summary>
    /// Wednesday.
    /// Encoded/decoded by serializers as "WEDD".
    /// </summary>
    [EnumMember(Value = "WEDD")]
    [IsoId("_nKkXkhVcEeWLrt6TQWUeiw")]
    [Description(@"Wednesday.")]
    Wednesday,
    
    /// <summary>
    /// Thursday.
    /// Encoded/decoded by serializers as "THUD".
    /// </summary>
    [EnumMember(Value = "THUD")]
    [IsoId("_nKkXkxVcEeWLrt6TQWUeiw")]
    [Description(@"Thursday.")]
    Thursday,
    
    /// <summary>
    /// Friday.
    /// Encoded/decoded by serializers as "FRID".
    /// </summary>
    [EnumMember(Value = "FRID")]
    [IsoId("_nTC-IBVcEeWLrt6TQWUeiw")]
    [Description(@"Friday.")]
    Friday,
    
    /// <summary>
    /// Saturday.
    /// Encoded/decoded by serializers as "SATD".
    /// </summary>
    [EnumMember(Value = "SATD")]
    [IsoId("_nTC-IRVcEeWLrt6TQWUeiw")]
    [Description(@"Saturday.")]
    Saturday,
    
    /// <summary>
    /// Sunday.
    /// Encoded/decoded by serializers as "SUND".
    /// </summary>
    [EnumMember(Value = "SUND")]
    [IsoId("_na7u0BVcEeWLrt6TQWUeiw")]
    [Description(@"Sunday.")]
    Sunday,
    
    /// <summary>
    /// All Days of the week.
    /// Encoded/decoded by serializers as "ALLD".
    /// </summary>
    [EnumMember(Value = "ALLD")]
    [IsoId("_vbnBQJDoEeiZrojxmnmDSQ")]
    [Description(@"All Days of the week.")]
    AllDays,
    
    /// <summary>
    /// Days of the week Including bank holidays.
    /// Encoded/decoded by serializers as "IBHL".
    /// </summary>
    [EnumMember(Value = "IBHL")]
    [IsoId("__ggBMJDoEeiZrojxmnmDSQ")]
    [Description(@"Days of the week Including bank holidays.")]
    DaysIncludingBankHolidays,
    
    /// <summary>
    /// Days of the week excluding bank holidays.
    /// Encoded/decoded by serializers as "XBHL".
    /// </summary>
    [EnumMember(Value = "XBHL")]
    [IsoId("_feUBoZDpEeiZrojxmnmDSQ")]
    [Description(@"Days of the week excluding bank holidays.")]
    DaysExcludingBankHolidays,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class WeekDayCodeMetadataExtensions
{
    private static readonly WeekDayCodeDropdownSource _dropdownSource = new WeekDayCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IWeekDayCodeDropdownRow GetMetadata(this WeekDayCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


