﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StatementBasis3Code.  ISO2002 ID# _qaaAUMRxEeij-rSPpvD-Tw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the basis on which the statement is prepared expressed as a code.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StatementBasis3CodeDropdownSource"/>.
/// Implements <seealso cref="IStatementBasis3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qaaAUMRxEeij-rSPpvD-Tw")]
public partial class StatementBasis3CodeDropdownRow : EnumMetadataItem<StatementBasis3Code>, IStatementBasis3CodeDropdownRow
{
    /// <summary>
    /// Specifies the basis on which the statement is prepared expressed as a code.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StatementBasis3CodeDropdownRow(StatementBasis3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
