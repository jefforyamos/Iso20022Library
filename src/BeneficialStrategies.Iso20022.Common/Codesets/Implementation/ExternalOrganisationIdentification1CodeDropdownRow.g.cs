﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalOrganisationIdentification1Code.  ISO2002 ID# _ame0hNp-Ed-ak6NoX_4Aeg_-1667686354.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external organisation identification scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalOrganisationIdentification1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalOrganisationIdentification1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ame0hNp-Ed-ak6NoX_4Aeg_-1667686354")]
public partial class ExternalOrganisationIdentification1CodeDropdownRow : EnumMetadataItem<ExternalOrganisationIdentification1Code>, IExternalOrganisationIdentification1CodeDropdownRow
{
    /// <summary>
    /// Specifies the external organisation identification scheme name code in the format of character string with a maximum length of 4 characters.
    /// The list of valid codes is an external code list published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalOrganisationIdentification1CodeDropdownRow(ExternalOrganisationIdentification1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
