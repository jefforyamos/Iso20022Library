﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OrganisationTypeCode.  ISO2002 ID# _--ww8CCeEeWJd9HF2tO7BA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of organisation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OrganisationTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IOrganisationTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_--ww8CCeEeWJd9HF2tO7BA")]
public partial class OrganisationTypeCodeDropdownRow : EnumMetadataItem<OrganisationTypeCode>, IOrganisationTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies a type of organisation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OrganisationTypeCodeDropdownRow(OrganisationTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
