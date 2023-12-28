﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InterestRateIndexTenorCode_TO_MERGE.  ISO2002 ID# _XWoxEI9EEeqMo4JxiuZGSw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the tenor of the interest rate index.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XWoxEI9EEeqMo4JxiuZGSw")]
[Description(@"Specifies the tenor of the interest rate index.")]
public enum InterestRateIndexTenorCode_TO_MERGE
{
    /// <summary>
    /// Tenor is 1 day.
    /// Encoded/decoded by serializers as "DAIL".
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_dTDsMI9EEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 1 day.")]
    Day1,
    
    /// <summary>
    /// Tenor is IntraDay.
    /// Encoded/decoded by serializers as "INDA".
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_h9fbAI9EEeqMo4JxiuZGSw")]
    [Description(@"Tenor is IntraDay.")]
    IntraDay,
    
    /// <summary>
    /// Tenor is 1 month.
    /// Encoded/decoded by serializers as "MNTH".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_mqKlgI9EEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 1 month.")]
    Month1,
    
    /// <summary>
    /// Tenor is 12 months.
    /// Encoded/decoded by serializers as "YEAR".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_vrs3cI9EEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 12 months.")]
    Month12,
    
    /// <summary>
    /// Tenor is 2 months.
    /// Encoded/decoded by serializers as "TOMN".
    /// </summary>
    [EnumMember(Value = "TOMN")]
    [IsoId("_34kyQI9EEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 2 months.")]
    Month2,
    
    /// <summary>
    /// Tenor is 3 months.
    /// Encoded/decoded by serializers as "QUTR".
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_9JZLoI9EEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 3 months.")]
    Month3,
    
    /// <summary>
    /// Tenor is 4 months.
    /// Encoded/decoded by serializers as "FOMN".
    /// </summary>
    [EnumMember(Value = "FOMN")]
    [IsoId("_KvIBgI9FEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 4 months.")]
    Month4,
    
    /// <summary>
    /// Tenor is 6 months.
    /// Encoded/decoded by serializers as "SEMI".
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_Q3SSkI9FEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 6 months.")]
    Month6,
    
    /// <summary>
    /// OnDemand
    /// Encoded/decoded by serializers as "ONDE".
    /// </summary>
    [EnumMember(Value = "ONDE")]
    [IsoId("_YXrh4I9FEeqMo4JxiuZGSw")]
    [Description(@"OnDemand")]
    OnDemand,
    
    /// <summary>
    /// Tenor is other unspecified time unit.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ctSQMI9FEeqMo4JxiuZGSw")]
    [Description(@"Tenor is other unspecified time unit.")]
    Other,
    
    /// <summary>
    /// Tenor is overnght.
    /// Encoded/decoded by serializers as "OVNG".
    /// </summary>
    [EnumMember(Value = "OVNG")]
    [IsoId("_tFspEI9FEeqMo4JxiuZGSw")]
    [Description(@"Tenor is overnght.")]
    Overnight,
    
    /// <summary>
    /// Tenor is 1 week.	
    /// Encoded/decoded by serializers as "WEEK".
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_xlIBwI9FEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 1 week.	")]
    Week1,
    
    /// <summary>
    /// Tenor is 2 weeks.
    /// Encoded/decoded by serializers as "TOWK".
    /// </summary>
    [EnumMember(Value = "TOWK")]
    [IsoId("_2D9kkI9FEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 2 weeks.")]
    Week2,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InterestRateIndexTenorCode_TO_MERGEMetadataExtensions
{
    private static readonly InterestRateIndexTenorCode_TO_MERGEDropdownSource _dropdownSource = new InterestRateIndexTenorCode_TO_MERGEDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInterestRateIndexTenorCode_TO_MERGEDropdownRow GetMetadata(this InterestRateIndexTenorCode_TO_MERGE code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


