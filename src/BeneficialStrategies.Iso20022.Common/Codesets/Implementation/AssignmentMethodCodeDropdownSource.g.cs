﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssignmentMethodCode.  ISO2002 ID# _bfaAlNp-Ed-ak6NoX_4Aeg_-1937835864.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method under which assignment was conducted.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssignmentMethodCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bfaAlNp-Ed-ak6NoX_4Aeg_-1937835864")]
public partial class AssignmentMethodCodeDropdownSource : EnumMetadataManager<AssignmentMethodCode,IAssignmentMethodCodeDropdownRow,AssignmentMethodCodeDropdownRow>
{
    public AssignmentMethodCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssignmentMethodCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
