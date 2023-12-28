﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReportSortedType1Code.  ISO2002 ID# _VeXEKNp-Ed-ak6NoX_4Aeg_-2144991913.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of criterion used to sort a report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VeXEKNp-Ed-ak6NoX_4Aeg_-2144991913")]
[Description(@"Specifies the type of criterion used to sort a report.")]
[DerivedFrom(typeof(ReportSortedTypeCode))]
public enum ReportSortedType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Country".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VeXEKdp-Ed-ak6NoX_4Aeg_-2144991903")]
    [Description(@"??")]
    Country,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Party".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Veg1INp-Ed-ak6NoX_4Aeg_-2144991902")]
    [Description(@"??")]
    Party,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Currency".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Veg1Idp-Ed-ak6NoX_4Aeg_-2144991901")]
    [Description(@"??")]
    Currency,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReportSortedType1CodeMetadataExtensions
{
    private static readonly ReportSortedType1CodeDropdownSource _dropdownSource = new ReportSortedType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReportSortedType1CodeDropdownRow GetMetadata(this ReportSortedType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

