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
    /// ??
    /// Encoded/decoded by serializers as "ICC".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_19rGYZiuEeefZKJHxQTztg")]
    [Description(@"??")]
    ICC,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MagneticStripeWithoutSecurityCode".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2MaF8piuEeefZKJHxQTztg")]
    [Description(@"??")]
    MagneticStripeWithoutSecurityCode,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MagneticStripeWithSecurityCode".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2ZZZEpiuEeefZKJHxQTztg")]
    [Description(@"??")]
    MagneticStripeWithSecurityCode,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2mahYpiuEeefZKJHxQTztg")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_24fI0piuEeefZKJHxQTztg")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OffLinePIN".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_5L7VoZivEeefZKJHxQTztg")]
    [Description(@"??")]
    OffLinePIN,
    
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


