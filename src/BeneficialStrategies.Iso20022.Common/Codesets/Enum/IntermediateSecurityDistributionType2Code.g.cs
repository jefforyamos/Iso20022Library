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
    /// Distribution of reverser rights.
    /// Encoded/decoded by serializers as "BIDS".
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("_aaQ9ctp-Ed-ak6NoX_4Aeg_-1090801611")]
    [Description(@"Distribution of reverser rights.")]
    ReverseRights = IntermediateSecurityDistributionTypeCode.ReverseRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of bonus rights.
    /// Encoded/decoded by serializers as "BONU".
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_aaQ9c9p-Ed-ak6NoX_4Aeg_-1090801593")]
    [Description(@"Distribution of bonus rights.")]
    BonusRights = IntermediateSecurityDistributionTypeCode.BonusRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of dividend reinvestment securities.
    /// Encoded/decoded by serializers as "DRIP".
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_aaQ9dNp-Ed-ak6NoX_4Aeg_-1090801568")]
    [Description(@"Distribution of dividend reinvestment securities.")]
    DividendReinvestment = IntermediateSecurityDistributionTypeCode.DividendReinvestment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of dividend option.
    /// Encoded/decoded by serializers as "DVOP".
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("_aaQ9ddp-Ed-ak6NoX_4Aeg_-1090801551")]
    [Description(@"Distribution of dividend option.")]
    DividendOption = IntermediateSecurityDistributionTypeCode.DividendOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of subscription rights.
    /// Encoded/decoded by serializers as "EXRI".
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("_aaQ9dtp-Ed-ak6NoX_4Aeg_-1090801291")]
    [Description(@"Distribution of subscription rights.")]
    SubscriptionRights = IntermediateSecurityDistributionTypeCode.SubscriptionRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of open offer rights.
    /// Encoded/decoded by serializers as "PRIO".
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("_aaQ9d9p-Ed-ak6NoX_4Aeg_-1090801274")]
    [Description(@"Distribution of open offer rights.")]
    OpenOfferRights = IntermediateSecurityDistributionTypeCode.OpenOfferRights, // same ordinal as derivation source for type conversions
    
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


