﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TerminalIntegrationCategoryCode.  ISO2002 ID# _qt8lnWXOEem9Y55YJ70L8g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Terminal category code of the place where the merchant actually performed the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TerminalIntegrationCategoryCodeDropdownSource"/>.
/// Implements <seealso cref="ITerminalIntegrationCategoryCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qt8lnWXOEem9Y55YJ70L8g")]
public partial class TerminalIntegrationCategoryCodeDropdownRow : EnumMetadataItem<TerminalIntegrationCategoryCode>, ITerminalIntegrationCategoryCodeDropdownRow
{
    /// <summary>
    /// Terminal category code of the place where the merchant actually performed the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TerminalIntegrationCategoryCodeDropdownRow(TerminalIntegrationCategoryCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
