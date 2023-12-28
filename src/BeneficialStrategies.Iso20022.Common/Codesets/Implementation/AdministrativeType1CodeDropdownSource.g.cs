﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AdministrativeType1Code.  ISO2002 ID# _3BW3kDNKEeylu6lH-gut-A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code that specifies the administrative type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAdministrativeType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_3BW3kDNKEeylu6lH-gut-A")]
public partial class AdministrativeType1CodeDropdownSource : EnumMetadataManager<AdministrativeType1Code,IAdministrativeType1CodeDropdownRow,AdministrativeType1CodeDropdownRow>
{
    public AdministrativeType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AdministrativeType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
