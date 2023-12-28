﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionInformationType1Code.  ISO2002 ID# _ioVuQCXcEeOFIcNWlDEvdQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of information event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionInformationType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ioVuQCXcEeOFIcNWlDEvdQ")]
public partial class CorporateActionInformationType1CodeDropdownSource : EnumMetadataManager<CorporateActionInformationType1Code,ICorporateActionInformationType1CodeDropdownRow,CorporateActionInformationType1CodeDropdownRow>
{
    public CorporateActionInformationType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionInformationType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}