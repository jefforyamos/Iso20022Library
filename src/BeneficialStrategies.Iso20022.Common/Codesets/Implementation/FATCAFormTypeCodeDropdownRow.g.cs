﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FATCAFormTypeCode.  ISO2002 ID# _qRYe4QjLEeS5F6qHcKOrew.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of Foreign Account Tax Compliance Act (FATCA) form.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FATCAFormTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IFATCAFormTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qRYe4QjLEeS5F6qHcKOrew")]
public partial class FATCAFormTypeCodeDropdownRow : EnumMetadataItem<FATCAFormTypeCode>, IFATCAFormTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of Foreign Account Tax Compliance Act (FATCA) form.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FATCAFormTypeCodeDropdownRow(FATCAFormTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
