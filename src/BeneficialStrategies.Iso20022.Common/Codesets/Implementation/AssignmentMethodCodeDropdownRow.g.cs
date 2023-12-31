﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AssignmentMethodCode.  ISO2002 ID# _bfaAlNp-Ed-ak6NoX_4Aeg_-1937835864.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method under which assignment was conducted.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AssignmentMethodCodeDropdownSource"/>.
/// Implements <seealso cref="IAssignmentMethodCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bfaAlNp-Ed-ak6NoX_4Aeg_-1937835864")]
public partial class AssignmentMethodCodeDropdownRow : EnumMetadataItem<AssignmentMethodCode>, IAssignmentMethodCodeDropdownRow
{
    /// <summary>
    /// Method under which assignment was conducted.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AssignmentMethodCodeDropdownRow(AssignmentMethodCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
