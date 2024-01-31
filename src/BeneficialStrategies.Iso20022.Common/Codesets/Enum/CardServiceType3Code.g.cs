﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardServiceType3Code.  ISO2002 ID# _Tf3TcHvNEeSCJdwgzb6SFw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of key exchange.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Tf3TcHvNEeSCJdwgzb6SFw")]
[Description(@"Type of key exchange.")]
[DerivedFrom(typeof(CardServiceTypeCode))]
public enum CardServiceType3Code
{
    /// <summary>
    /// Convey the key to the receiver.
    /// Encoded/decoded by serializers as "KYDL".
    /// </summary>
    [EnumMember(Value = "KYDL")]
    [IsoId("_a-8UIXvNEeSCJdwgzb6SFw")]
    [Description(@"Convey the key to the receiver.")]
    DeliverKey = CardServiceTypeCode.DeliverKey, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request the keys that the receiver must send in the response.
    /// Encoded/decoded by serializers as "KYCG".
    /// </summary>
    [EnumMember(Value = "KYCG")]
    [IsoId("_baEJ43vNEeSCJdwgzb6SFw")]
    [Description(@"Request the keys that the receiver must send in the response.")]
    KeyChange = CardServiceTypeCode.KeyChange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request the receiver to verify the key check value.
    /// Encoded/decoded by serializers as "KYVF".
    /// </summary>
    [EnumMember(Value = "KYVF")]
    [IsoId("_ugAgAXvNEeSCJdwgzb6SFw")]
    [Description(@"Request the receiver to verify the key check value.")]
    KeyVerification = CardServiceTypeCode.KeyVerification, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardServiceType3CodeMetadataExtensions
{
    private static readonly CardServiceType3CodeDropdownSource _dropdownSource = new CardServiceType3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardServiceType3CodeDropdownRow GetMetadata(this CardServiceType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


