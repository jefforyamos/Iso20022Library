﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AddendumTaxTypeCode.  ISO2002 ID# _o7g-JvJ7EeiJn9rM2Znz2w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the specific type of tax(es) applicable to a transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AddendumTaxTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IAddendumTaxTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_o7g-JvJ7EeiJn9rM2Znz2w")]
public partial class AddendumTaxTypeCodeDropdownRow : EnumMetadataItem<AddendumTaxTypeCode>, IAddendumTaxTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the specific type of tax(es) applicable to a transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AddendumTaxTypeCodeDropdownRow(AddendumTaxTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}