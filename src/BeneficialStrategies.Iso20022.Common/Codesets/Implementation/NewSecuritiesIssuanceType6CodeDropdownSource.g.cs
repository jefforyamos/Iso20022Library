﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NewSecuritiesIssuanceType6Code.  ISO2002 ID# _PLMMMWKeEeWR9ZSfjmHwUA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of securities proceeds; whether they are defeased or non-defeased.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INewSecuritiesIssuanceType6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_PLMMMWKeEeWR9ZSfjmHwUA")]
public partial class NewSecuritiesIssuanceType6CodeDropdownSource : EnumMetadataManager<NewSecuritiesIssuanceType6Code,INewSecuritiesIssuanceType6CodeDropdownRow,NewSecuritiesIssuanceType6CodeDropdownRow>
{
    public NewSecuritiesIssuanceType6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new NewSecuritiesIssuanceType6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}