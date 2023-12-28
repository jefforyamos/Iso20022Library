﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Eligibility1Code.  ISO2002 ID# _ahHzZNp-Ed-ak6NoX_4Aeg_-1375297258.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of investor. The rules that apply to each type of client are different.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ahHzZNp-Ed-ak6NoX_4Aeg_-1375297258")]
[Description(@"Identifies the type of investor. The rules that apply to each type of client are different.")]
[DerivedFrom(typeof(EligibilityCode))]
public enum Eligibility1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EligibleCounterparty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ahHzZdp-Ed-ak6NoX_4Aeg_-1307879388")]
    [Description(@"??")]
    EligibleCounterparty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RetailClient".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ahHzZtp-Ed-ak6NoX_4Aeg_-1307879371")]
    [Description(@"??")]
    RetailClient,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProfessionalClient".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ahHzZ9p-Ed-ak6NoX_4Aeg_-1307879327")]
    [Description(@"??")]
    ProfessionalClient,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Eligibility1CodeMetadataExtensions
{
    private static readonly Eligibility1CodeDropdownSource _dropdownSource = new Eligibility1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEligibility1CodeDropdownRow GetMetadata(this Eligibility1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


