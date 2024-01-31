﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CRSFormType1Code.  ISO2002 ID# _TYFa4ENwEeaS-NnwLNvMPg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of Common Reporting Standard (CRS) form.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CRSFormType1CodeDropdownSource"/>.
/// Implements <seealso cref="ICRSFormType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TYFa4ENwEeaS-NnwLNvMPg")]
public partial class CRSFormType1CodeDropdownRow : EnumMetadataItem<CRSFormType1Code>, ICRSFormType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of Common Reporting Standard (CRS) form.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CRSFormType1CodeDropdownRow(CRSFormType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
