﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CSCResult1Code.  ISO2002 ID# _TS9qZgEcEeCQm6a_G2yO_w_2096541332.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the printed CSC (Card Security Code) validation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CSCResult1CodeDropdownSource"/>.
/// Implements <seealso cref="ICSCResult1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TS9qZgEcEeCQm6a_G2yO_w_2096541332")]
public partial class CSCResult1CodeDropdownRow : EnumMetadataItem<CSCResult1Code>, ICSCResult1CodeDropdownRow
{
    /// <summary>
    /// Result of the printed CSC (Card Security Code) validation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CSCResult1CodeDropdownRow(CSCResult1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
