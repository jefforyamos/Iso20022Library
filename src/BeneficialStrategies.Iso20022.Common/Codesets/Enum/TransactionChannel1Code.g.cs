﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionChannel1Code.  ISO2002 ID# _TUAMOQEcEeCQm6a_G2yO_w_2033954837.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of the communication channels used by the cardholder to the acceptor system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUAMOQEcEeCQm6a_G2yO_w_2033954837")]
[Description(@"Identifies the type of the communication channels used by the cardholder to the acceptor system.")]
[DerivedFrom(typeof(TransactionChannelCode))]
public enum TransactionChannel1Code
{
    /// <summary>
    /// Mail order.
    /// Encoded/decoded by serializers as "MAIL".
    /// </summary>
    [EnumMember(Value = "MAIL")]
    [IsoId("_TUAMOgEcEeCQm6a_G2yO_w_421671046")]
    [Description(@"Mail order.")]
    MailOrder = TransactionChannelCode.MailOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Telephone order.
    /// Encoded/decoded by serializers as "TLPH".
    /// </summary>
    [EnumMember(Value = "TLPH")]
    [IsoId("_TUAMOwEcEeCQm6a_G2yO_w_-391479472")]
    [Description(@"Telephone order.")]
    TelephoneOrder = TransactionChannelCode.TelephoneOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Electronic commerce.
    /// Encoded/decoded by serializers as "ECOM".
    /// </summary>
    [EnumMember(Value = "ECOM")]
    [IsoId("_TUAMPAEcEeCQm6a_G2yO_w_-106195051")]
    [Description(@"Electronic commerce.")]
    ElectronicCommerce = TransactionChannelCode.ElectronicCommerce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment on television.
    /// Encoded/decoded by serializers as "TVPY".
    /// </summary>
    [EnumMember(Value = "TVPY")]
    [IsoId("_TUAMPQEcEeCQm6a_G2yO_w_654570102")]
    [Description(@"Payment on television.")]
    TelevisionPayment = TransactionChannelCode.TelevisionPayment, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionChannel1CodeMetadataExtensions
{
    private static readonly TransactionChannel1CodeDropdownSource _dropdownSource = new TransactionChannel1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionChannel1CodeDropdownRow GetMetadata(this TransactionChannel1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


