﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ModifiedStatusReason1Code.  ISO2002 ID# _0mgfgglIEeGATtfOBToyew_-1343301078.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies that the transaction has been modified.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IModifiedStatusReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0mgfgglIEeGATtfOBToyew_-1343301078")]
public partial class ModifiedStatusReason1CodeDropdownSource : EnumMetadataManager<ModifiedStatusReason1Code,IModifiedStatusReason1CodeDropdownRow,ModifiedStatusReason1CodeDropdownRow>
{
    public ModifiedStatusReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ModifiedStatusReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
