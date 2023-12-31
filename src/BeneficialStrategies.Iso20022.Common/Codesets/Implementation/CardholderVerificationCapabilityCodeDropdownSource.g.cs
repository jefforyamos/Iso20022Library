﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardholderVerificationCapabilityCode.  ISO2002 ID# _TWPA1AEcEeCQm6a_G2yO_w_1625416412.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Cardholder verification capabilities of the POI (Personal Identification Number) performing the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardholderVerificationCapabilityCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TWPA1AEcEeCQm6a_G2yO_w_1625416412")]
public partial class CardholderVerificationCapabilityCodeDropdownSource : EnumMetadataManager<CardholderVerificationCapabilityCode,ICardholderVerificationCapabilityCodeDropdownRow,CardholderVerificationCapabilityCodeDropdownRow>
{
    public CardholderVerificationCapabilityCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardholderVerificationCapabilityCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
