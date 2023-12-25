﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CorporateActionTransactionCategoryCode.  ISO2002 ID# _10mR0TL3EeKU9IrkkToqcw_816572354.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transaction category to which the corporate action event type belongs to for reporting purposes.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CorporateActionTransactionCategoryCodeDropdownSource"/>.
/// Implements <seealso cref="ICorporateActionTransactionCategoryCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_10mR0TL3EeKU9IrkkToqcw_816572354")]
public partial class CorporateActionTransactionCategoryCodeDropdownRow : EnumMetadataItem<CorporateActionTransactionCategoryCode>, ICorporateActionTransactionCategoryCodeDropdownRow
{
    /// <summary>
    /// Specifies the transaction category to which the corporate action event type belongs to for reporting purposes.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CorporateActionTransactionCategoryCodeDropdownRow(CorporateActionTransactionCategoryCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
