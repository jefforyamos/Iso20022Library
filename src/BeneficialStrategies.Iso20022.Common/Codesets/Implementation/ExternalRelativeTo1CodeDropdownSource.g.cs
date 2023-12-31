﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalRelativeTo1Code.  ISO2002 ID# _-MYPEm7iEeKo25nLKvGr8w_-593632971.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external relative to code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalRelativeTo1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-MYPEm7iEeKo25nLKvGr8w_-593632971")]
public partial class ExternalRelativeTo1CodeDropdownSource : EnumMetadataManager<ExternalRelativeTo1Code,IExternalRelativeTo1CodeDropdownRow,ExternalRelativeTo1CodeDropdownRow>
{
    public ExternalRelativeTo1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalRelativeTo1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
