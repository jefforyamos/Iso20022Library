﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PresentmentType1Code.  ISO2002 ID# _pTnR0EWeEempSe_3C1a9EQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies which elements types must be presented in an e-invoice.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PresentmentType1CodeDropdownSource"/>.
/// Implements <seealso cref="IPresentmentType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pTnR0EWeEempSe_3C1a9EQ")]
public partial class PresentmentType1CodeDropdownRow : EnumMetadataItem<PresentmentType1Code>, IPresentmentType1CodeDropdownRow
{
    /// <summary>
    /// Specifies which elements types must be presented in an e-invoice.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PresentmentType1CodeDropdownRow(PresentmentType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
