﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardProductTypeCode.  ISO2002 ID# _SaRAQGtZEeSKOvNNYJQdoQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of card product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SaRAQGtZEeSKOvNNYJQdoQ")]
[Description(@"Type of card product.")]
[Derivations(typeof(CardProductType1Code))]
public enum CardProductTypeCode
{
    /// <summary>
    /// Cards issued as a means of business expenditure, for instance business card or corporate card. The user could be a company, an individual for business expenses or a self employed for business purposes.
    /// Encoded/decoded by serializers as "COMM".
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_W0DrAGtZEeSKOvNNYJQdoQ")]
    [Description(@"Cards issued as a means of business expenditure, for instance business card or corporate card. The user could be a company, an individual for business expenses or a self employed for business purposes.")]
    CommercialCard,
    
    /// <summary>
    /// Cards issued as a means of personal expenditure. The user is always an individual.
    /// Encoded/decoded by serializers as "CONS".
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_bxmjEGtZEeSKOvNNYJQdoQ")]
    [Description(@"Cards issued as a means of personal expenditure. The user is always an individual.")]
    ConsumerCard,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardProductTypeCodeMetadataExtensions
{
    private static readonly CardProductTypeCodeDropdownSource _dropdownSource = new CardProductTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardProductTypeCodeDropdownRow GetMetadata(this CardProductTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


