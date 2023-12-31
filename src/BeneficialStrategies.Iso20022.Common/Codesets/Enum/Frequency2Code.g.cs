﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Frequency2Code.  ISO2002 ID# _asJXqNp-Ed-ak6NoX_4Aeg_1505345791.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_asJXqNp-Ed-ak6NoX_4Aeg_1505345791")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency2Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as "Annual".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_asTIoNp-Ed-ak6NoX_4Aeg_1506269390")]
    [Description(@"Event takes place every year or once a year.")]
    Annual,
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as "Monthly".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_asTIodp-Ed-ak6NoX_4Aeg_1506270304")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly,
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as "Quarterly".
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_asTIotp-Ed-ak6NoX_4Aeg_1506270784")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly,
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as "SemiAnnual".
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_asTIo9p-Ed-ak6NoX_4Aeg_1506271251")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual,
    
    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as "Weekly".
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_asTIpNp-Ed-ak6NoX_4Aeg_1506271732")]
    [Description(@"Event takes place once a week.")]
    Weekly,
    
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as "Daily".
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_asTIpdp-Ed-ak6NoX_4Aeg_1506271774")]
    [Description(@"Event takes place every day.")]
    Daily,
    
    /// <summary>
    /// Event takes place on request or as necessary.
    /// Encoded/decoded by serializers as "Adhoc".
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_asTIptp-Ed-ak6NoX_4Aeg_1507192308")]
    [Description(@"Event takes place on request or as necessary.")]
    Adhoc,
    
    /// <summary>
    /// Event takes place several times a day.
    /// Encoded/decoded by serializers as "IntraDay".
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_asTIp9p-Ed-ak6NoX_4Aeg_1507192896")]
    [Description(@"Event takes place several times a day.")]
    IntraDay,
    
    /// <summary>
    /// Event takes place overnight.
    /// Encoded/decoded by serializers as "Overnight".
    /// </summary>
    [EnumMember(Value = "OVNG")]
    [IsoId("_asTIqNp-Ed-ak6NoX_4Aeg_-886985582")]
    [Description(@"Event takes place overnight.")]
    Overnight,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Frequency2CodeMetadataExtensions
{
    private static readonly Frequency2CodeDropdownSource _dropdownSource = new Frequency2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFrequency2CodeDropdownRow GetMetadata(this Frequency2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


