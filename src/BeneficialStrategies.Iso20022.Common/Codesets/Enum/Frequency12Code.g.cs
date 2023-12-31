﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Frequency12Code.  ISO2002 ID# _FLwRoOkXEemeDPHh-U9b6w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FLwRoOkXEemeDPHh-U9b6w")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency12Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as "Annual".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_Ll31YekXEemeDPHh-U9b6w")]
    [Description(@"Event takes place every year or once a year.")]
    Annual,
    
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as "Daily".
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_L6HAAukXEemeDPHh-U9b6w")]
    [Description(@"Event takes place every day.")]
    Daily,
    
    /// <summary>
    /// Event takes place every two weeks.
    /// Encoded/decoded by serializers as "Fortnightly".
    /// </summary>
    [EnumMember(Value = "FRTN")]
    [IsoId("_Mky7wukXEemeDPHh-U9b6w")]
    [Description(@"Event takes place every two weeks.")]
    Fortnightly,
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as "Monthly".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_M1KTAukXEemeDPHh-U9b6w")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly,
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as "Quarterly".
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_NUZzwukXEemeDPHh-U9b6w")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly,
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as "SemiAnnual".
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_NrAV4ukXEemeDPHh-U9b6w")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual,
    
    /// <summary>
    /// Event takes place every ten business days.
    /// Encoded/decoded by serializers as "TenDays".
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_OCN8AukXEemeDPHh-U9b6w")]
    [Description(@"Event takes place every ten business days.")]
    TenDays,
    
    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as "Weekly".
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_OV_zoukXEemeDPHh-U9b6w")]
    [Description(@"Event takes place once a week.")]
    Weekly,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Frequency12CodeMetadataExtensions
{
    private static readonly Frequency12CodeDropdownSource _dropdownSource = new Frequency12CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFrequency12CodeDropdownRow GetMetadata(this Frequency12Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


