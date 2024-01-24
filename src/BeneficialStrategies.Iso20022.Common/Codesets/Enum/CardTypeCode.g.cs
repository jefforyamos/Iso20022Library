﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardTypeCode.  ISO2002 ID# _a1-pFdp-Ed-ak6NoX_4Aeg_309816465.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of payment card.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a1-pFdp-Ed-ak6NoX_4Aeg_309816465")]
[Description(@"Specifies the type of payment card.")]
[Derivations(typeof(CardType1Code))]
public enum CardTypeCode
{
    /// <summary>
    /// Card where the holder has been granted a line of credit. The card enables the holder to make purchases and withdraw cash up to a pre-arranged ceiling.
    /// Encoded/decoded by serializers as "CRDT".
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_a1-pFtp-Ed-ak6NoX_4Aeg_309816466")]
    [Description(@"Card where the holder has been granted a line of credit. The card enables the holder to make purchases and withdraw cash up to a pre-arranged ceiling.")]
    CreditCard,
    
    /// <summary>
    /// Card enabling the holder to have its purchases directly charged to its account. The card may also combine other functions, for example, cash card or cheque guaranteed card.
    /// Encoded/decoded by serializers as "DBIT".
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_a2IaENp-Ed-ak6NoX_4Aeg_309816467")]
    [Description(@"Card enabling the holder to have its purchases directly charged to its account. The card may also combine other functions, for example, cash card or cheque guaranteed card.")]
    DebitCard,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardTypeCodeMetadataExtensions
{
    private static readonly CardTypeCodeDropdownSource _dropdownSource = new CardTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardTypeCodeDropdownRow GetMetadata(this CardTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


