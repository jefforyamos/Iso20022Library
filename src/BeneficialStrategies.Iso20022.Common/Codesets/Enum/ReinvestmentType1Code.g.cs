﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReinvestmentType1Code.  ISO2002 ID# _TstrIMkgEeeiAIB1i4AlQw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides details on the  type of the cash reinvestment in a given currency.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TstrIMkgEeeiAIB1i4AlQw")]
[Description(@"Provides details on the  type of the cash reinvestment in a given currency.")]
[DerivedFrom(typeof(ReinvestmentTypeCode))]
public enum ReinvestmentType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U2eIgckgEeeiAIB1i4AlQw")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherCommingledPool".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U8uhgskgEeeiAIB1i4AlQw")]
    [Description(@"??")]
    OtherCommingledPool,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegisteredMoneyMarketFund".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VAKQAckgEeeiAIB1i4AlQw")]
    [Description(@"??")]
    RegisteredMoneyMarketFund,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RepurchaseAgreementMarket".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VIzOoskgEeeiAIB1i4AlQw")]
    [Description(@"??")]
    RepurchaseAgreementMarket,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuritiesDirectPurchase".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VPz1kskgEeeiAIB1i4AlQw")]
    [Description(@"??")]
    SecuritiesDirectPurchase,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReinvestmentType1CodeMetadataExtensions
{
    private static readonly ReinvestmentType1CodeDropdownSource _dropdownSource = new ReinvestmentType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReinvestmentType1CodeDropdownRow GetMetadata(this ReinvestmentType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

