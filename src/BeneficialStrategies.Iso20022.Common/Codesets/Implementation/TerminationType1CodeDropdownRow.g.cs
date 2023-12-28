﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TerminationType1Code.  ISO2002 ID# _Yll619p-Ed-ak6NoX_4Aeg_2070054481.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the timing or method for terminating the agreement - for repos.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TerminationType1CodeDropdownSource"/>.
/// Implements <seealso cref="ITerminationType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yll619p-Ed-ak6NoX_4Aeg_2070054481")]
public partial class TerminationType1CodeDropdownRow : EnumMetadataItem<TerminationType1Code>, ITerminationType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the timing or method for terminating the agreement - for repos.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TerminationType1CodeDropdownRow(TerminationType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
