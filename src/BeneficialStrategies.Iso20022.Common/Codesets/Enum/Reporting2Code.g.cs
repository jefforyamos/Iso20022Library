﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Reporting2Code.  ISO2002 ID# _ZTMAotp-Ed-ak6NoX_4Aeg_-582451382.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies information with regards to reporting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTMAotp-Ed-ak6NoX_4Aeg_-582451382")]
[Description(@"Specifies information with regards to reporting.")]
[DerivedFrom(typeof(ReportingCode))]
public enum Reporting2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StockExchange".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZTMAo9p-Ed-ak6NoX_4Aeg_-495638960")]
    [Description(@"??")]
    StockExchange,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegulatoryOrganisation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZTMApNp-Ed-ak6NoX_4Aeg_-255523631")]
    [Description(@"??")]
    RegulatoryOrganisation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeferredReport".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZTMApdp-Ed-ak6NoX_4Aeg_-210271843")]
    [Description(@"??")]
    DeferredReport,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Reporting2CodeMetadataExtensions
{
    private static readonly Reporting2CodeDropdownSource _dropdownSource = new Reporting2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReporting2CodeDropdownRow GetMetadata(this Reporting2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


