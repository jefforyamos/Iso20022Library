﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for IntermediateSecurityDistributionType1Code.  ISO2002 ID# _aZ-Ch9p-Ed-ak6NoX_4Aeg_1639683801.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of intermediate security distribution.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aZ-Ch9p-Ed-ak6NoX_4Aeg_1639683801")]
[Description(@"Specifies the type of intermediate security distribution.")]
[DerivedFrom(typeof(IntermediateSecurityDistributionTypeCode))]
public enum IntermediateSecurityDistributionType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReverseRights".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZ-CiNp-Ed-ak6NoX_4Aeg_1639683803")]
    [Description(@"??")]
    ReverseRights,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BonusRights".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaHMcNp-Ed-ak6NoX_4Aeg_1639683831")]
    [Description(@"??")]
    BonusRights,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DividendReinvestment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaHMcdp-Ed-ak6NoX_4Aeg_1639683832")]
    [Description(@"??")]
    DividendReinvestment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashDividend".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaHMctp-Ed-ak6NoX_4Aeg_1639683862")]
    [Description(@"??")]
    CashDividend,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DividendOption".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaHMc9p-Ed-ak6NoX_4Aeg_1639683863")]
    [Description(@"??")]
    DividendOption,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SubscriptionRights".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaHMdNp-Ed-ak6NoX_4Aeg_1639683864")]
    [Description(@"??")]
    SubscriptionRights,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OpenOfferRights".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaHMddp-Ed-ak6NoX_4Aeg_1639683885")]
    [Description(@"??")]
    OpenOfferRights,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ScripDividendOrPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaHMdtp-Ed-ak6NoX_4Aeg_1639683893")]
    [Description(@"??")]
    ScripDividendOrPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StockDividend".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaHMd9p-Ed-ak6NoX_4Aeg_1639683894")]
    [Description(@"??")]
    StockDividend,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InterestPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaHMeNp-Ed-ak6NoX_4Aeg_1639684133")]
    [Description(@"??")]
    InterestPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LiquidationDividendOrPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaHMedp-Ed-ak6NoX_4Aeg_1639684141")]
    [Description(@"??")]
    LiquidationDividendOrPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SpinOff".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaQ9cNp-Ed-ak6NoX_4Aeg_1639684164")]
    [Description(@"??")]
    SpinOff,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class IntermediateSecurityDistributionType1CodeMetadataExtensions
{
    private static readonly IntermediateSecurityDistributionType1CodeDropdownSource _dropdownSource = new IntermediateSecurityDistributionType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IIntermediateSecurityDistributionType1CodeDropdownRow GetMetadata(this IntermediateSecurityDistributionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

