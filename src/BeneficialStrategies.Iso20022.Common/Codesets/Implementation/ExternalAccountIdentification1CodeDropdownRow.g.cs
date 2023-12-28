﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalAccountIdentification1Code.  ISO2002 ID# _amL5ktp-Ed-ak6NoX_4Aeg_-2079691647.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external account identification scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalAccountIdentification1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalAccountIdentification1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_amL5ktp-Ed-ak6NoX_4Aeg_-2079691647")]
public partial class ExternalAccountIdentification1CodeDropdownRow : EnumMetadataItem<ExternalAccountIdentification1Code>, IExternalAccountIdentification1CodeDropdownRow
{
    /// <summary>
    /// Specifies the external account identification scheme name code in the format of character string with a maximum length of 4 characters.
    /// The list of valid codes is an external code list published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalAccountIdentification1CodeDropdownRow(ExternalAccountIdentification1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
