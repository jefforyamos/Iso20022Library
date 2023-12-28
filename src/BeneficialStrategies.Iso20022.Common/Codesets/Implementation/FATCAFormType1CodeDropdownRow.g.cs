﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FATCAFormType1Code.  ISO2002 ID# _kZxV0AjMEeS5F6qHcKOrew.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of Foreign Account Tax Compliance Act (FATCA) form.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FATCAFormType1CodeDropdownSource"/>.
/// Implements <seealso cref="IFATCAFormType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_kZxV0AjMEeS5F6qHcKOrew")]
public partial class FATCAFormType1CodeDropdownRow : EnumMetadataItem<FATCAFormType1Code>, IFATCAFormType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of Foreign Account Tax Compliance Act (FATCA) form.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FATCAFormType1CodeDropdownRow(FATCAFormType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}