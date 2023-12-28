﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for IntermediateSecurityDistributionType2Code.  ISO2002 ID# _aaQ9cdp-Ed-ak6NoX_4Aeg_-1418652702.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of intermediate security distribution.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aaQ9cdp-Ed-ak6NoX_4Aeg_-1418652702")]
[Description(@"Specifies the type of intermediate security distribution.")]
[DerivedFrom(typeof(IntermediateSecurityDistributionTypeCode))]
public enum IntermediateSecurityDistributionType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReverseRights".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaQ9ctp-Ed-ak6NoX_4Aeg_-1090801611")]
    [Description(@"??")]
    ReverseRights,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BonusRights".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaQ9c9p-Ed-ak6NoX_4Aeg_-1090801593")]
    [Description(@"??")]
    BonusRights,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DividendReinvestment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaQ9dNp-Ed-ak6NoX_4Aeg_-1090801568")]
    [Description(@"??")]
    DividendReinvestment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DividendOption".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaQ9ddp-Ed-ak6NoX_4Aeg_-1090801551")]
    [Description(@"??")]
    DividendOption,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SubscriptionRights".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaQ9dtp-Ed-ak6NoX_4Aeg_-1090801291")]
    [Description(@"??")]
    SubscriptionRights,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OpenOfferRights".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aaQ9d9p-Ed-ak6NoX_4Aeg_-1090801274")]
    [Description(@"??")]
    OpenOfferRights,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class IntermediateSecurityDistributionType2CodeMetadataExtensions
{
    private static readonly IntermediateSecurityDistributionType2CodeDropdownSource _dropdownSource = new IntermediateSecurityDistributionType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IIntermediateSecurityDistributionType2CodeDropdownRow GetMetadata(this IntermediateSecurityDistributionType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

