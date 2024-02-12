﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Frequency2Code.  ISO2002 ID# _asJXqNp-Ed-ak6NoX_4Aeg_1505345791.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Encoded/decoded by serializers as "YEAR".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_asTIoNp-Ed-ak6NoX_4Aeg_1506269390")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = FrequencyCode.Annual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as "MNTH".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_asTIodp-Ed-ak6NoX_4Aeg_1506270304")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = FrequencyCode.Monthly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as "QURT".
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_asTIotp-Ed-ak6NoX_4Aeg_1506270784")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = FrequencyCode.Quarterly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as "MIAN".
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_asTIo9p-Ed-ak6NoX_4Aeg_1506271251")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = FrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as "WEEK".
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_asTIpNp-Ed-ak6NoX_4Aeg_1506271732")]
    [Description(@"Event takes place once a week.")]
    Weekly = FrequencyCode.Weekly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as "DAIL".
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_asTIpdp-Ed-ak6NoX_4Aeg_1506271774")]
    [Description(@"Event takes place every day.")]
    Daily = FrequencyCode.Daily, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place on request or as necessary.
    /// Encoded/decoded by serializers as "ADHO".
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_asTIptp-Ed-ak6NoX_4Aeg_1507192308")]
    [Description(@"Event takes place on request or as necessary.")]
    Adhoc = FrequencyCode.Adhoc, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place several times a day.
    /// Encoded/decoded by serializers as "INDA".
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_asTIp9p-Ed-ak6NoX_4Aeg_1507192896")]
    [Description(@"Event takes place several times a day.")]
    IntraDay = FrequencyCode.IntraDay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place overnight.
    /// Encoded/decoded by serializers as "OVNG".
    /// </summary>
    [EnumMember(Value = "OVNG")]
    [IsoId("_asTIqNp-Ed-ak6NoX_4Aeg_-886985582")]
    [Description(@"Event takes place overnight.")]
    Overnight = FrequencyCode.Overnight, // same ordinal as derivation source for type conversions
    
}
