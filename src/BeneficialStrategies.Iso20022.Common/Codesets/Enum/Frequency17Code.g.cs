﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Frequency17Code.  ISO2002 ID# _fppBkclPEeuJ35KoBRZFOg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fppBkclPEeuJ35KoBRZFOg")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency17Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as "Annual".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_fusgsclPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place every year or once a year.")]
    Annual,
    
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as "Daily".
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_futHx8lPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place every day.")]
    Daily,
    
    /// <summary>
    /// Event takes place every two weeks.
    /// Encoded/decoded by serializers as "Fortnightly".
    /// </summary>
    [EnumMember(Value = "FRTN")]
    [IsoId("_futHz8lPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place every two weeks.")]
    Fortnightly,
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as "Monthly".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_futH0clPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly,
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as "Quarterly".
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_futH38lPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly,
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as "SemiAnnual".
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_futH7clPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual,
    
    /// <summary>
    /// Event takes place every ten business days.
    /// Encoded/decoded by serializers as "TenDays".
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_futH9clPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place every ten business days.")]
    TenDays,
    
    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as "Weekly".
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_futH98lPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place once a week.")]
    Weekly,
    
    /// <summary>
    /// Event takes place on request or as necessary.
    /// Encoded/decoded by serializers as "Adhoc".
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_pdb24MlPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place on request or as necessary.")]
    Adhoc,
    
    /// <summary>
    /// Event associated with a shift.
    /// Encoded/decoded by serializers as "Shift".
    /// </summary>
    [EnumMember(Value = "SHFT")]
    [IsoId("_1TaJ4clQEeuJ35KoBRZFOg")]
    [Description(@"Event associated with a shift.")]
    Shift,
    
    /// <summary>
    /// Event takes place on demand.
    /// Encoded/decoded by serializers as "OnDemand".
    /// </summary>
    [EnumMember(Value = "ODMD")]
    [IsoId("_1uI-EclQEeuJ35KoBRZFOg")]
    [Description(@"Event takes place on demand.")]
    OnDemand,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Frequency17CodeMetadataExtensions
{
    private static readonly Frequency17CodeDropdownSource _dropdownSource = new Frequency17CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFrequency17CodeDropdownRow GetMetadata(this Frequency17Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


