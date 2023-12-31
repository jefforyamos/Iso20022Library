﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardholderAddressVerificationResult1Code.  ISO2002 ID# _TSXNegEcEeCQm6a_G2yO_w_859983869.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Result of the Cardholder verification address checks on the street number and the Postal Code from the Cardholder's Address.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardholderAddressVerificationResult1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TSXNegEcEeCQm6a_G2yO_w_859983869")]
public partial class CardholderAddressVerificationResult1CodeDropdownSource : EnumMetadataManager<CardholderAddressVerificationResult1Code,ICardholderAddressVerificationResult1CodeDropdownRow,CardholderAddressVerificationResult1CodeDropdownRow>
{
    public CardholderAddressVerificationResult1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardholderAddressVerificationResult1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
