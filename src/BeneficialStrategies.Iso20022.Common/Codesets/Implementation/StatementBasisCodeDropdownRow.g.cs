﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StatementBasisCode.  ISO2002 ID# _ZQD0Itp-Ed-ak6NoX_4Aeg_836087748.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of balances on which the statement is prepared.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StatementBasisCodeDropdownSource"/>.
/// Implements <seealso cref="IStatementBasisCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZQD0Itp-Ed-ak6NoX_4Aeg_836087748")]
public partial class StatementBasisCodeDropdownRow : EnumMetadataItem<StatementBasisCode>, IStatementBasisCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of balances on which the statement is prepared.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StatementBasisCodeDropdownRow(StatementBasisCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
