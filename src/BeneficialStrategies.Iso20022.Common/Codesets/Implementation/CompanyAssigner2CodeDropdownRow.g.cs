﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CompanyAssigner2Code.  ISO2002 ID# _jzqUkGMaEeexSYCBvAp_qA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Party in charge of assigning an identification to a company.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CompanyAssigner2CodeDropdownSource"/>.
/// Implements <seealso cref="ICompanyAssigner2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jzqUkGMaEeexSYCBvAp_qA")]
public partial class CompanyAssigner2CodeDropdownRow : EnumMetadataItem<CompanyAssigner2Code>, ICompanyAssigner2CodeDropdownRow
{
    /// <summary>
    /// Party in charge of assigning an identification to a company.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CompanyAssigner2CodeDropdownRow(CompanyAssigner2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
