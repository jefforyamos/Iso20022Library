﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RetailerService6Code.  ISO2002 ID# _kRZ9oN6PEeiwsev40qZGEQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of specific services for ReportRequest.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kRZ9oN6PEeiwsev40qZGEQ")]
[Description(@"List of specific services for ReportRequest.")]
[DerivedFrom(typeof(RetailerServiceCode))]
public enum RetailerService6Code
{
    /// <summary>
    /// The Sale System requests to the POI System a report on a list of transactions.
    /// Encoded/decoded by serializers as "RPTQ".
    /// </summary>
    [EnumMember(Value = "RPTQ")]
    [IsoId("_potZgd6PEeiwsev40qZGEQ")]
    [Description(@"The Sale System requests to the POI System a report on a list of transactions.")]
    AdministrativeReportTransactionRequest = RetailerServiceCode.AdministrativeReportTransactionRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Sale System requests to the POI System a report on the totals figures of the POI system.
    /// Encoded/decoded by serializers as "RPAQ".
    /// </summary>
    [EnumMember(Value = "RPAQ")]
    [IsoId("_qOCUId6PEeiwsev40qZGEQ")]
    [Description(@"The Sale System requests to the POI System a report on the totals figures of the POI system.")]
    AdministrativeReportGetTotalsRequest = RetailerServiceCode.AdministrativeReportGetTotalsRequest, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RetailerService6CodeMetadataExtensions
{
    private static readonly RetailerService6CodeDropdownSource _dropdownSource = new RetailerService6CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRetailerService6CodeDropdownRow GetMetadata(this RetailerService6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


