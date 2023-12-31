﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardType1Code.  ISO2002 ID# _zd5TUg93EeGeV5vP7Mvdig_-963241833.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of payment card.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zd5TUg93EeGeV5vP7Mvdig_-963241833")]
[Description(@"Specifies the type of payment card.")]
[DerivedFrom(typeof(CardTypeCode))]
public enum CardType1Code
{
    /// <summary>
    /// Card where the holder has been granted a line of credit. The card enables the holder to make purchases and withdraw cash up to a pre-arranged ceiling.
    /// Encoded/decoded by serializers as "CreditCard".
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_zd5TUw93EeGeV5vP7Mvdig_-1511071309")]
    [Description(@"Card where the holder has been granted a line of credit. The card enables the holder to make purchases and withdraw cash up to a pre-arranged ceiling.")]
    CreditCard,
    
    /// <summary>
    /// Card enabling the holder to have its purchases directly charged to its account. The card may also combine other functions, for example, cash card or cheque guaranteed card.
    /// Encoded/decoded by serializers as "DebitCard".
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_zd5TVA93EeGeV5vP7Mvdig_-502422457")]
    [Description(@"Card enabling the holder to have its purchases directly charged to its account. The card may also combine other functions, for example, cash card or cheque guaranteed card.")]
    DebitCard,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardType1CodeMetadataExtensions
{
    private static readonly CardType1CodeDropdownSource _dropdownSource = new CardType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardType1CodeDropdownRow GetMetadata(this CardType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


