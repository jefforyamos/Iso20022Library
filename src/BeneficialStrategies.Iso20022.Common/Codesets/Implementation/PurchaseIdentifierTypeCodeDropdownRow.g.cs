﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PurchaseIdentifierTypeCode.  ISO2002 ID# _dsO7g_JOEeiJn9rM2Znz2w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of identifier used in the Purchase Identifier field. 
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PurchaseIdentifierTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IPurchaseIdentifierTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dsO7g_JOEeiJn9rM2Znz2w")]
public partial class PurchaseIdentifierTypeCodeDropdownRow : EnumMetadataItem<PurchaseIdentifierTypeCode>, IPurchaseIdentifierTypeCodeDropdownRow
{
    /// <summary>
    /// Identifies the type of identifier used in the Purchase Identifier field. 
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PurchaseIdentifierTypeCodeDropdownRow(PurchaseIdentifierTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
