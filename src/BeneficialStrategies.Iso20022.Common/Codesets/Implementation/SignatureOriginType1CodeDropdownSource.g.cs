﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SignatureOriginType1Code.  ISO2002 ID# _-s3AAMnAEeWI4cSIO9foRA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the origin of the signature.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISignatureOriginType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-s3AAMnAEeWI4cSIO9foRA")]
public partial class SignatureOriginType1CodeDropdownSource : EnumMetadataManager<SignatureOriginType1Code,ISignatureOriginType1CodeDropdownRow,SignatureOriginType1CodeDropdownRow>
{
    public SignatureOriginType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SignatureOriginType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
