﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for IdentificationType1Code.  ISO2002 ID# _Huj2wIA6EeSUJZYcWGKkkw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the source of the party identification.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IIdentificationType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Huj2wIA6EeSUJZYcWGKkkw")]
public partial class IdentificationType1CodeDropdownSource : EnumMetadataManager<IdentificationType1Code,IIdentificationType1CodeDropdownRow,IdentificationType1CodeDropdownRow>
{
    public IdentificationType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new IdentificationType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
