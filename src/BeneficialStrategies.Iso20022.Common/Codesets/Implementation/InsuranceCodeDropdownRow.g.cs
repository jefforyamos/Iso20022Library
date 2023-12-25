﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InsuranceCode.  ISO2002 ID# _gQ8SUxQaEeKebsB9eKJSkA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of insurance.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InsuranceCodeDropdownSource"/>.
/// Implements <seealso cref="IInsuranceCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_gQ8SUxQaEeKebsB9eKJSkA")]
public partial class InsuranceCodeDropdownRow : EnumMetadataItem<InsuranceCode>, IInsuranceCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of insurance.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InsuranceCodeDropdownRow(InsuranceCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
