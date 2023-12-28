﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ModificationRejection2Code.  ISO2002 ID# _aMHMs9p-Ed-ak6NoX_4Aeg_-2138458517.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for rejecting a modification reject.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IModificationRejection2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aMHMs9p-Ed-ak6NoX_4Aeg_-2138458517")]
public partial class ModificationRejection2CodeDropdownSource : EnumMetadataManager<ModificationRejection2Code,IModificationRejection2CodeDropdownRow,ModificationRejection2CodeDropdownRow>
{
    public ModificationRejection2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ModificationRejection2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}