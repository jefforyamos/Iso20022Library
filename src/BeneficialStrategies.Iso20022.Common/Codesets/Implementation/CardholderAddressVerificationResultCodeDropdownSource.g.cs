﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardholderAddressVerificationResultCode.  ISO2002 ID# _TWF26gEcEeCQm6a_G2yO_w_1762343535.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Result of the cardholder verification address checks on the street number and the postal code from the cardholder's address.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardholderAddressVerificationResultCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TWF26gEcEeCQm6a_G2yO_w_1762343535")]
public partial class CardholderAddressVerificationResultCodeDropdownSource : EnumMetadataManager<CardholderAddressVerificationResultCode,ICardholderAddressVerificationResultCodeDropdownRow,CardholderAddressVerificationResultCodeDropdownRow>
{
    public CardholderAddressVerificationResultCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardholderAddressVerificationResultCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
