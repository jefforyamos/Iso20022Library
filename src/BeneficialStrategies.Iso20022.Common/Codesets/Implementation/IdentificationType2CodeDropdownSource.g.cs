﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for IdentificationType2Code.  ISO2002 ID# _sowHEIA5EeSUJZYcWGKkkw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the source of the leg identification.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IIdentificationType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_sowHEIA5EeSUJZYcWGKkkw")]
public partial class IdentificationType2CodeDropdownSource : EnumMetadataManager<IdentificationType2Code,IIdentificationType2CodeDropdownRow,IdentificationType2CodeDropdownRow>
{
    public IdentificationType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new IdentificationType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
