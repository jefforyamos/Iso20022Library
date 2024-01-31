﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalPersonIdentification1Code.  ISO2002 ID# _ame0hdp-Ed-ak6NoX_4Aeg_-1698163033.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external person identification scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalPersonIdentification1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ame0hdp-Ed-ak6NoX_4Aeg_-1698163033")]
public partial class ExternalPersonIdentification1CodeDropdownSource : EnumMetadataManager<ExternalPersonIdentification1Code,IExternalPersonIdentification1CodeDropdownRow,ExternalPersonIdentification1CodeDropdownRow>
{
    public ExternalPersonIdentification1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalPersonIdentification1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
