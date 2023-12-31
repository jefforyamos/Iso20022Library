﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CryptographicKeyType4Code.  ISO2002 ID# _NwgesItJEeSxlKlAGYErFg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Category of the cryptographic key.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICryptographicKeyType4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NwgesItJEeSxlKlAGYErFg")]
public partial class CryptographicKeyType4CodeDropdownSource : EnumMetadataManager<CryptographicKeyType4Code,ICryptographicKeyType4CodeDropdownRow,CryptographicKeyType4CodeDropdownRow>
{
    public CryptographicKeyType4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CryptographicKeyType4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
