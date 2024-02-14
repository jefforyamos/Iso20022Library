﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TimeUnitCode.  ISO2002 ID# _YmCmwNp-Ed-ak6NoX_4Aeg_-22472882.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the time unit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YmCmwNp-Ed-ak6NoX_4Aeg_-22472882")]
[Description(@"Specifies the time unit.")]
[Derivations(typeof(TimeUnit1Code))]
public enum TimeUnitCode
{
    /// <summary>
    /// Time unit is second.
    /// Encoded/decoded by serializers as &quot;SECO&quot;.
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_YmCmwdp-Ed-ak6NoX_4Aeg_-1938121752")]
    [Description(@"Time unit is second.")]
    Second,
    
    /// <summary>
    /// Time unit is minute.
    /// Encoded/decoded by serializers as &quot;MINU&quot;.
    /// </summary>
    [EnumMember(Value = "MINU")]
    [IsoId("_YmCmwtp-Ed-ak6NoX_4Aeg_-1937198231")]
    [Description(@"Time unit is minute.")]
    Minute,
    
    /// <summary>
    /// Time unit is hour.
    /// Encoded/decoded by serializers as &quot;HOUR&quot;.
    /// </summary>
    [EnumMember(Value = "HOUR")]
    [IsoId("_YmCmw9p-Ed-ak6NoX_4Aeg_-1936275233")]
    [Description(@"Time unit is hour.")]
    Hour,
    
    /// <summary>
    /// Time unit is calendar day.
    /// Encoded/decoded by serializers as &quot;DAYC&quot;.
    /// </summary>
    [EnumMember(Value = "DAYC")]
    [IsoId("_YmCmxNp-Ed-ak6NoX_4Aeg_-1927962536")]
    [Description(@"Time unit is calendar day.")]
    CalendarDay,
    
    /// <summary>
    /// Time unit is week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_YmCmxdp-Ed-ak6NoX_4Aeg_-1927039439")]
    [Description(@"Time unit is week.")]
    Week,
    
    /// <summary>
    /// Time unit is month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_YmCmxtp-Ed-ak6NoX_4Aeg_-1926116410")]
    [Description(@"Time unit is month.")]
    Month,
    
    /// <summary>
    /// Time unit is year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_YmCmx9p-Ed-ak6NoX_4Aeg_-1925193661")]
    [Description(@"Time unit is year.")]
    Year,
    
}
