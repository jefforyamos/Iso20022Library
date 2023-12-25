﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PreferredContactMethodCode.  ISO2002 ID# _6UHyCJqlEeGSON8vddiWzQ_1695397384.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Preferred method used to reach the individual contact within an organisation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPreferredContactMethodCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6UHyCJqlEeGSON8vddiWzQ_1695397384")]
public partial class PreferredContactMethodCodeDropdownSource : EnumMetadataManager<PreferredContactMethodCode,IPreferredContactMethodCodeDropdownRow,PreferredContactMethodCodeDropdownRow>
{
    public PreferredContactMethodCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PreferredContactMethodCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
