﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SignatureType2Code.  ISO2002 ID# _kjV1YF-dEeavlvCtut5bgg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of signature.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISignatureType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_kjV1YF-dEeavlvCtut5bgg")]
public partial class SignatureType2CodeDropdownSource : EnumMetadataManager<SignatureType2Code,ISignatureType2CodeDropdownRow,SignatureType2CodeDropdownRow>
{
    public SignatureType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SignatureType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
