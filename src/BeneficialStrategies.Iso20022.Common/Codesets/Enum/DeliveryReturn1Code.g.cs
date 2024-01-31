﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeliveryReturn1Code.  ISO2002 ID# _azTIg9p-Ed-ak6NoX_4Aeg_-1245884336.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of delivery return.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_azTIg9p-Ed-ak6NoX_4Aeg_-1245884336")]
[Description(@"Specifies the type of delivery return.")]
[DerivedFrom(typeof(DeliveryReturnCode))]
public enum DeliveryReturn1Code
{
    /// <summary>
    /// Original delivery is not recognized.
    /// Encoded/decoded by serializers as "UNRE".
    /// </summary>
    [EnumMember(Value = "UNRE")]
    [IsoId("_azTIhNp-Ed-ak6NoX_4Aeg_-959595290")]
    [Description(@"Original delivery is not recognized.")]
    UnrecognisedDelivery = DeliveryReturnCode.UnrecognisedDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Wrong quantity delivered in the original instruction.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_azTIhdp-Ed-ak6NoX_4Aeg_-917110811")]
    [Description(@"Wrong quantity delivered in the original instruction.")]
    WrongQuantity = DeliveryReturnCode.WrongQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Wrong settlement amount settled in the original delivery.
    /// Encoded/decoded by serializers as "DMON".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_azTIhtp-Ed-ak6NoX_4Aeg_-872782203")]
    [Description(@"Wrong settlement amount settled in the original delivery.")]
    WrongSettlementAmount = DeliveryReturnCode.WrongSettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Only a portion of the original transaction quantity was delivered by the Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_azTIh9p-Ed-ak6NoX_4Aeg_-845078527")]
    [Description(@"Only a portion of the original transaction quantity was delivered by the Central Securities Depository (CSD).")]
    PartialDelivery = DeliveryReturnCode.PartialDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account information is missing in the original delivery.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_azc5gNp-Ed-ak6NoX_4Aeg_-829378346")]
    [Description(@"Account information is missing in the original delivery.")]
    AccountMissing = DeliveryReturnCode.AccountMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Due bill information missing in the original delivery.
    /// Encoded/decoded by serializers as "DUEB".
    /// </summary>
    [EnumMember(Value = "DUEB")]
    [IsoId("_azc5gdp-Ed-ak6NoX_4Aeg_-573562488")]
    [Description(@"Due bill information missing in the original delivery.")]
    DueBiillMissing = DeliveryReturnCode.DueBiillMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Portion of the original transaction quantity was returned by the receiver.
    /// Encoded/decoded by serializers as "PARD".
    /// </summary>
    [EnumMember(Value = "PARD")]
    [IsoId("_azc5gtp-Ed-ak6NoX_4Aeg_-502450366")]
    [Description(@"Portion of the original transaction quantity was returned by the receiver.")]
    PartialReturn = DeliveryReturnCode.PartialReturn, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DeliveryReturn1CodeMetadataExtensions
{
    private static readonly DeliveryReturn1CodeDropdownSource _dropdownSource = new DeliveryReturn1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDeliveryReturn1CodeDropdownRow GetMetadata(this DeliveryReturn1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


