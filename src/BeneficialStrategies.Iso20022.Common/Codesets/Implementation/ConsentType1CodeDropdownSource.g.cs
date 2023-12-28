﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ConsentType1Code.  ISO2002 ID# _Ux3xACHnEeOQ7qT4JUI53A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of consent announced.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IConsentType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Ux3xACHnEeOQ7qT4JUI53A")]
public partial class ConsentType1CodeDropdownSource : EnumMetadataManager<ConsentType1Code,IConsentType1CodeDropdownRow,ConsentType1CodeDropdownRow>
{
    public ConsentType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ConsentType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}