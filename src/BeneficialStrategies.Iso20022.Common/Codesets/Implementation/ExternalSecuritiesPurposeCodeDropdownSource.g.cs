﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalSecuritiesPurposeCode.  ISO2002 ID# _5eZzoPomEe2ClqPWkEN24A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external securities purpose code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalSecuritiesPurposeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_5eZzoPomEe2ClqPWkEN24A")]
public partial class ExternalSecuritiesPurposeCodeDropdownSource : EnumMetadataManager<ExternalSecuritiesPurposeCode,IExternalSecuritiesPurposeCodeDropdownRow,ExternalSecuritiesPurposeCodeDropdownRow>
{
    public ExternalSecuritiesPurposeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalSecuritiesPurposeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
