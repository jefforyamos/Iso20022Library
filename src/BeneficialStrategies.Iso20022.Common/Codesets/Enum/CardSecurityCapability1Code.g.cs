﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardSecurityCapability1Code.  ISO2002 ID# _zyCVQJiuEeefZKJHxQTztg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Card security code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zyCVQJiuEeefZKJHxQTztg")]
[Description(@"Card security code list.")]
[DerivedFrom(typeof(CardSecurityCapabilityCode))]
public enum CardSecurityCapability1Code
{
    /// <summary>
    /// Card contains an integrated circuit card.
    /// Encoded/decoded by serializers as "ICCD".
    /// </summary>
    [EnumMember(Value = "ICCD")]
    [IsoId("_19rGYZiuEeefZKJHxQTztg")]
    [Description(@"Card contains an integrated circuit card.")]
    ICC = CardSecurityCapabilityCode.ICC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card does not contain a card security code in the magstripe
    /// Encoded/decoded by serializers as "MWOS".
    /// </summary>
    [EnumMember(Value = "MWOS")]
    [IsoId("_2MaF8piuEeefZKJHxQTztg")]
    [Description(@"Card does not contain a card security code in the magstripe")]
    MagneticStripeWithoutSecurityCode = CardSecurityCapabilityCode.MagneticStripeWithoutSecurityCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card contains a card security code in the magstripe
    /// Encoded/decoded by serializers as "MSWS".
    /// </summary>
    [EnumMember(Value = "MSWS")]
    [IsoId("_2ZZZEpiuEeefZKJHxQTztg")]
    [Description(@"Card contains a card security code in the magstripe")]
    MagneticStripeWithSecurityCode = CardSecurityCapabilityCode.MagneticStripeWithSecurityCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of card defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_2mahYpiuEeefZKJHxQTztg")]
    [Description(@"Other type of card defined at national level.")]
    OtherNational = CardSecurityCapabilityCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of card defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_24fI0piuEeefZKJHxQTztg")]
    [Description(@"Other type of card defined at private level.")]
    OtherPrivate = CardSecurityCapabilityCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Off line PIN card
    /// Encoded/decoded by serializers as "OLPN".
    /// </summary>
    [EnumMember(Value = "OLPN")]
    [IsoId("_5L7VoZivEeefZKJHxQTztg")]
    [Description(@"Off line PIN card")]
    OffLinePIN = CardSecurityCapabilityCode.OffLinePIN, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardSecurityCapability1CodeMetadataExtensions
{
    private static readonly CardSecurityCapability1CodeDropdownSource _dropdownSource = new CardSecurityCapability1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardSecurityCapability1CodeDropdownRow GetMetadata(this CardSecurityCapability1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


