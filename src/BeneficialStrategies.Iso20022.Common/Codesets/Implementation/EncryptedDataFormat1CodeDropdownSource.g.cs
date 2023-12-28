﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EncryptedDataFormat1Code.  ISO2002 ID# _f43y0AHzEeiJObvChJn-OA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Format used for encrypted data.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEncryptedDataFormat1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_f43y0AHzEeiJObvChJn-OA")]
public partial class EncryptedDataFormat1CodeDropdownSource : EnumMetadataManager<EncryptedDataFormat1Code,IEncryptedDataFormat1CodeDropdownRow,EncryptedDataFormat1CodeDropdownRow>
{
    public EncryptedDataFormat1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EncryptedDataFormat1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}