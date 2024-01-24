﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalEncryptedElementIdentificationCode.  ISO2002 ID# _aG9UEVdTEeqBUKlIwxdUog.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the element that has been encrypted, as published in an external data to encrypt type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// These codes have the same value as the tag assignments shown in ISO 13492 for the data encryption dataset.  The codes are variable in length and conform to ISO/IEC 8825-1.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalEncryptedElementIdentificationCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aG9UEVdTEeqBUKlIwxdUog")]
public partial class ExternalEncryptedElementIdentificationCodeDropdownSource : EnumMetadataManager<ExternalEncryptedElementIdentificationCode,IExternalEncryptedElementIdentificationCodeDropdownRow,ExternalEncryptedElementIdentificationCodeDropdownRow>
{
    public ExternalEncryptedElementIdentificationCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalEncryptedElementIdentificationCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
