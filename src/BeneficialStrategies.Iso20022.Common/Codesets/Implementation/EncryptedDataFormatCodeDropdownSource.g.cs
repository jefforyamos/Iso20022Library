﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EncryptedDataFormatCode.  ISO2002 ID# _lupawAHwEeiJObvChJn-OA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Format used to encrypt the data.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEncryptedDataFormatCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_lupawAHwEeiJObvChJn-OA")]
public partial class EncryptedDataFormatCodeDropdownSource : EnumMetadataManager<EncryptedDataFormatCode,IEncryptedDataFormatCodeDropdownRow,EncryptedDataFormatCodeDropdownRow>
{
    public EncryptedDataFormatCodeDropdownSource()
        : base( (enumValue, memberInfo) => new EncryptedDataFormatCodeDropdownRow(enumValue, memberInfo))
    {
    }
}