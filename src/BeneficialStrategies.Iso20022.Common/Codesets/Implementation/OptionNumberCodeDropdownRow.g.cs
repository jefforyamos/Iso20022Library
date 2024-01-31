﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OptionNumberCode.  ISO2002 ID# _aP_AENp-Ed-ak6NoX_4Aeg_1603970622.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code identifying special corporate action option numbers.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OptionNumberCodeDropdownSource"/>.
/// Implements <seealso cref="IOptionNumberCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aP_AENp-Ed-ak6NoX_4Aeg_1603970622")]
public partial class OptionNumberCodeDropdownRow : EnumMetadataItem<OptionNumberCode>, IOptionNumberCodeDropdownRow
{
    /// <summary>
    /// Code identifying special corporate action option numbers.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OptionNumberCodeDropdownRow(OptionNumberCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
