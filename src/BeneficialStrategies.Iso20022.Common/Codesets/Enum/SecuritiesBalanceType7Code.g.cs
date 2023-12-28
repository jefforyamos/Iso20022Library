﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesBalanceType7Code.  ISO2002 ID# _ZCpqQNp-Ed-ak6NoX_4Aeg_1990824949.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZCpqQNp-Ed-ak6NoX_4Aeg_1990824949")]
[Description(@"Specifies the nature of the securities or investment fund balance.")]
[DerivedFrom(typeof(SecuritiesBalanceTypeV2Code))]
public enum SecuritiesBalanceType7Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EligibleForCollateralPurposes".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZCpqQdp-Ed-ak6NoX_4Aeg_1990825070")]
    [Description(@"??")]
    EligibleForCollateralPurposes,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unclassified".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZCpqQtp-Ed-ak6NoX_4Aeg_1990825425")]
    [Description(@"??")]
    Unclassified,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxExempt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZCpqQ9p-Ed-ak6NoX_4Aeg_1990825442")]
    [Description(@"??")]
    TaxExempt,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonTaxExempt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZCpqRNp-Ed-ak6NoX_4Aeg_1990825476")]
    [Description(@"??")]
    NonTaxExempt,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Registered".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZCpqRdp-Ed-ak6NoX_4Aeg_1990825477")]
    [Description(@"??")]
    Registered,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StreetPosition".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZCpqRtp-Ed-ak6NoX_4Aeg_1990825494")]
    [Description(@"??")]
    StreetPosition,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unregistered".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZCpqR9p-Ed-ak6NoX_4Aeg_1990825495")]
    [Description(@"??")]
    Unregistered,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Issued".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZCpqSNp-Ed-ak6NoX_4Aeg_-740716487")]
    [Description(@"??")]
    Issued,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QuasiIssued".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZCpqSdp-Ed-ak6NoX_4Aeg_-740716214")]
    [Description(@"??")]
    QuasiIssued,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesBalanceType7CodeMetadataExtensions
{
    private static readonly SecuritiesBalanceType7CodeDropdownSource _dropdownSource = new SecuritiesBalanceType7CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesBalanceType7CodeDropdownRow GetMetadata(this SecuritiesBalanceType7Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


