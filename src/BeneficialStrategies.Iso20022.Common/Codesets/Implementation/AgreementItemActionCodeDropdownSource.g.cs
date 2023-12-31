﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AgreementItemActionCode.  ISO2002 ID# _OTgzMjc4-AOSNFX-8224496.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of action concerning registration information.
/// The default value is OPEN.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAgreementItemActionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_OTgzMjc4-AOSNFX-8224496")]
public partial class AgreementItemActionCodeDropdownSource : EnumMetadataManager<AgreementItemActionCode,IAgreementItemActionCodeDropdownRow,AgreementItemActionCodeDropdownRow>
{
    public AgreementItemActionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AgreementItemActionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
