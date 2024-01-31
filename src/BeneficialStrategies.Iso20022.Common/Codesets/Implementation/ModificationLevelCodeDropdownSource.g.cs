﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ModificationLevelCode.  ISO2002 ID# _ZzzfsQ3mEeWc7_0KPiuk6w.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction or position level.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IModificationLevelCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZzzfsQ3mEeWc7_0KPiuk6w")]
public partial class ModificationLevelCodeDropdownSource : EnumMetadataManager<ModificationLevelCode,IModificationLevelCodeDropdownRow,ModificationLevelCodeDropdownRow>
{
    public ModificationLevelCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ModificationLevelCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
