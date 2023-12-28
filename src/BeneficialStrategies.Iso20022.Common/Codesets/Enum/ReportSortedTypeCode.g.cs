﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReportSortedTypeCode.  ISO2002 ID# _VqbxRNp-Ed-ak6NoX_4Aeg_-2144991898.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of criterion is a country.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VqbxRNp-Ed-ak6NoX_4Aeg_-2144991898")]
[Description(@"Type of criterion is a country.")]
public enum ReportSortedTypeCode
{
    /// <summary>
    /// Type of criterion is a nation.
    /// Encoded/decoded by serializers as "COUN".
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_VqbxRdp-Ed-ak6NoX_4Aeg_-2144991897")]
    [Description(@"Type of criterion is a nation.")]
    Country,
    
    /// <summary>
    /// Type of criterion is an entity, eg, a financial institution.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_VqbxRtp-Ed-ak6NoX_4Aeg_-2144991896")]
    [Description(@"Type of criterion is an entity, eg, a financial institution.")]
    Party,
    
    /// <summary>
    /// Type of criterion is a currency, eg, the euro.
    /// Encoded/decoded by serializers as "CURR".
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_VqbxR9p-Ed-ak6NoX_4Aeg_-2144991895")]
    [Description(@"Type of criterion is a currency, eg, the euro.")]
    Currency,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReportSortedTypeCodeMetadataExtensions
{
    private static readonly ReportSortedTypeCodeDropdownSource _dropdownSource = new ReportSortedTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReportSortedTypeCodeDropdownRow GetMetadata(this ReportSortedTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


