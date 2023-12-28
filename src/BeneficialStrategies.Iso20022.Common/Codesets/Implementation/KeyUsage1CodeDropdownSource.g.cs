﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for KeyUsage1Code.  ISO2002 ID# _KSJO8H1DEeCF8NjrBemJWQ_1886720027.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Allowed usages of the key.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IKeyUsage1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KSJO8H1DEeCF8NjrBemJWQ_1886720027")]
public partial class KeyUsage1CodeDropdownSource : EnumMetadataManager<KeyUsage1Code,IKeyUsage1CodeDropdownRow,KeyUsage1CodeDropdownRow>
{
    public KeyUsage1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new KeyUsage1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
