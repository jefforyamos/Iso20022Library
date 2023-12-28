﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalPurpose1Code.  ISO2002 ID# _amolgNp-Ed-ak6NoX_4Aeg_1652079816.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external purpose code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalPurpose1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_amolgNp-Ed-ak6NoX_4Aeg_1652079816")]
public partial class ExternalPurpose1CodeDropdownSource : EnumMetadataManager<ExternalPurpose1Code,IExternalPurpose1CodeDropdownRow,ExternalPurpose1CodeDropdownRow>
{
    public ExternalPurpose1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalPurpose1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}