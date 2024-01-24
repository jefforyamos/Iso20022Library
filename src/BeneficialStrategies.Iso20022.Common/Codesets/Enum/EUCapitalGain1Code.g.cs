﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EUCapitalGain1Code.  ISO2002 ID# _VkUiMdp-Ed-ak6NoX_4Aeg_-990874327.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June) for an income realised upon sale, a refund or redemption of shares and units etc.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VkUiMdp-Ed-ak6NoX_4Aeg_-990874327")]
[Description(@"Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June) for an income realised upon sale, a refund or redemption of shares and units etc.")]
[DerivedFrom(typeof(EUCapitalGainCode))]
public enum EUCapitalGain1Code
{
    /// <summary>
    /// Capital gain is in the scope of the directive.
    /// Encoded/decoded by serializers as "EUSI".
    /// </summary>
    [EnumMember(Value = "EUSI")]
    [IsoId("_VkUiMtp-Ed-ak6NoX_4Aeg_-834797746")]
    [Description(@"Capital gain is in the scope of the directive.")]
    CapitalGainInScope = EUCapitalGainCode.CapitalGainInScope, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Capital gain is out of the scope of the directive.
    /// Encoded/decoded by serializers as "EUSO".
    /// </summary>
    [EnumMember(Value = "EUSO")]
    [IsoId("_VkUiM9p-Ed-ak6NoX_4Aeg_-834797728")]
    [Description(@"Capital gain is out of the scope of the directive.")]
    CapitalGainOutScope = EUCapitalGainCode.CapitalGainOutScope, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unknown whether capital gain is in or out of the scope of the directive.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_VkUiNNp-Ed-ak6NoX_4Aeg_-834797727")]
    [Description(@"Unknown whether capital gain is in or out of the scope of the directive.")]
    CapitalGainUnknown = EUCapitalGainCode.CapitalGainUnknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Another type of EU capital gain.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VkUiNdp-Ed-ak6NoX_4Aeg_-1526082672")]
    [Description(@"Another type of EU capital gain.")]
    Other = EUCapitalGainCode.Other, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EUCapitalGain1CodeMetadataExtensions
{
    private static readonly EUCapitalGain1CodeDropdownSource _dropdownSource = new EUCapitalGain1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEUCapitalGain1CodeDropdownRow GetMetadata(this EUCapitalGain1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


