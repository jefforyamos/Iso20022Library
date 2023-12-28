﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SecuritiesStatementType1Code.  ISO2002 ID# _ZF7Astp-Ed-ak6NoX_4Aeg_-1354761740.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the statement is an accounting or a custody statement.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SecuritiesStatementType1CodeDropdownSource"/>.
/// Implements <seealso cref="ISecuritiesStatementType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZF7Astp-Ed-ak6NoX_4Aeg_-1354761740")]
public partial class SecuritiesStatementType1CodeDropdownRow : EnumMetadataItem<SecuritiesStatementType1Code>, ISecuritiesStatementType1CodeDropdownRow
{
    /// <summary>
    /// Specifies whether the statement is an accounting or a custody statement.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SecuritiesStatementType1CodeDropdownRow(SecuritiesStatementType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
