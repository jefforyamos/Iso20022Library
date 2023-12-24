﻿
//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EventFrequencyCode.  Iso ID# _akGO4dp-Ed-ak6NoX_4Aeg_1216168726.
// 



using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[Serializable]
[IsoId("_akGO4dp-Ed-ak6NoX_4Aeg_1216168726")]
[Description(@"Specifies the regularity of an event.")]
public enum EventFrequencyCode
{


    /// <summary>
    /// Event takes place every year or once a year.
    /// </summary>
    [IsoId("_akGO4tp-Ed-ak6NoX_4Aeg_1616054653")]
    [Description(@"Event takes place every year or once a year.")]
    YEAR,


    /// <summary>
    /// Event takes place every six months or two times a year.
    /// </summary>
    [IsoId("_akGO49p-Ed-ak6NoX_4Aeg_1616054748")]
    [Description(@"Event takes place every six months or two times a year.")]
    SEMI,


    /// <summary>
    /// Event takes place every three months or four times a year.
    /// </summary>
    [IsoId("_akP_4Np-Ed-ak6NoX_4Aeg_1616054713")]
    [Description(@"Event takes place every three months or four times a year.")]
    QUTR,


    /// <summary>
    /// Event takes place every two months.
    /// </summary>
    [IsoId("_akP_4dp-Ed-ak6NoX_4Aeg_-408295373")]
    [Description(@"Event takes place every two months.")]
    TOMN,


    /// <summary>
    /// Event takes place every month or once a month.
    /// </summary>
    [IsoId("_akP_4tp-Ed-ak6NoX_4Aeg_1616054695")]
    [Description(@"Event takes place every month or once a month.")]
    MNTH,


    /// <summary>
    /// Event takes place two times a month.
    /// </summary>
    [IsoId("_akP_49p-Ed-ak6NoX_4Aeg_-524659604")]
    [Description(@"Event takes place two times a month.")]
    TWMN,


    /// <summary>
    /// Event takes place every two weeks.
    /// </summary>
    [IsoId("_akP_5Np-Ed-ak6NoX_4Aeg_-468324283")]
    [Description(@"Event takes place every two weeks.")]
    TOWK,


    /// <summary>
    /// Event takes place once a week.
    /// </summary>
    [IsoId("_akP_5dp-Ed-ak6NoX_4Aeg_1616054773")]
    [Description(@"Event takes place once a week.")]
    WEEK,


    /// <summary>
    /// Event takes place every day.
    /// </summary>
    [IsoId("_akP_5tp-Ed-ak6NoX_4Aeg_1616055081")]
    [Description(@"Event takes place every day.")]
    DAIL,


    /// <summary>
    /// Event takes place several times a day.
    /// </summary>
    [IsoId("_akP_59p-Ed-ak6NoX_4Aeg_1616055117")]
    [Description(@"Event takes place several times a day.")]
    INDA,


    /// <summary>
    /// Event takes place overnight.
    /// </summary>
    [IsoId("_akP_6Np-Ed-ak6NoX_4Aeg_1616055152")]
    [Description(@"Event takes place overnight.")]
    OVNG,


    /// <summary>
    /// Event takes place as necessary.
    /// </summary>
    [IsoId("_akP_6dp-Ed-ak6NoX_4Aeg_1616055116")]
    [Description(@"Event takes place as necessary.")]
    ADHO,


    /// <summary>
    /// Event takes place on demand.
    /// </summary>
    [IsoId("_akZw4Np-Ed-ak6NoX_4Aeg_1729647252")]
    [Description(@"Event takes place on demand.")]
    ONDE,


    /// <summary>
    /// Event cannot take place, because, for example, the fund is closed.
    /// </summary>
    [IsoId("_akZw4dp-Ed-ak6NoX_4Aeg_-959050215")]
    [Description(@"Event cannot take place, because, for example, the fund is closed.")]
    CLOS,


    /// <summary>
    /// Event takes place every four months or three times a year.
    /// </summary>
    [IsoId("_I3_rIBUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place every four months or three times a year.")]
    FOMN,


    /// <summary>
    /// Event takes place every two years.
    /// </summary>
    [IsoId("_UTZ-gBUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place every two years.")]
    TYEA,


    /// <summary>
    /// Event does not take place.
    /// </summary>
    [IsoId("_dhDyoCDAEeWPMvNwVtiMsA")]
    [Description(@"Event does not take place.")]
    NONE,


    /// <summary>
    /// Unspecified frequency of event.
    /// </summary>
    [IsoId("_NyR1YCPAEemWJojmIXiyUw")]
    [Description(@"Unspecified frequency of event.")]
    OTHR,

}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EventFrequencyCodeMetadataExtensions
{
    private static readonly EventFrequencyCodeDropdownSource _dropdownSource = new EventFrequencyCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEventFrequencyCodeDropdownRow GetMetadata(this EventFrequencyCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



/// <summary>
/// The values that should be expected from a single row of dropdown data.
/// </summary>
public partial interface IEventFrequencyCodeDropdownRow : IEnumMetadataDropdownRow<EventFrequencyCode>
{
}


/// <summary>
/// Default implementation of <seealso cref="IEventFrequencyCodeDropdownRow"/> that contains metadata embedded in the code.
/// </summary>
public partial class EventFrequencyCodeDropdownRow : EnumMetadataItem<EventFrequencyCode>, IEventFrequencyCodeDropdownRow
{
    /// <summary>
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EventFrequencyCodeDropdownRow(EventFrequencyCode value, MemberInfo memberInfo) : base( value, memberInfo)
    {
    }
}


/// <summary>
/// Used to inject dependencies that require dropdown choice values.
/// Understood to be uniquely a source of choices appropriate for a valid <seealso cref="EventFrequencyCode"/>.
/// </summary>
public partial interface IEventFrequencyCodeDropdownSource : IDropdownDataSource<IEventFrequencyCodeDropdownRow>
{
}


/// <summary>
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEventFrequencyCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
public partial class EventFrequencyCodeDropdownSource : EnumMetadataManager<EventFrequencyCode,IEventFrequencyCodeDropdownRow,EventFrequencyCodeDropdownRow>
{
    public EventFrequencyCodeDropdownSource()
        : base( (enumValue, memberInfo) => new EventFrequencyCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
