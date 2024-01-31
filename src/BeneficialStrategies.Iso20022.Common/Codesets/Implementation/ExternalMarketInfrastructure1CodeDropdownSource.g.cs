﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalMarketInfrastructure1Code.  ISO2002 ID# _8MlMg6MgEeCJ6YNENx4h-w_-216754992.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the market infrastructure identification, as published in an external market infrastructure code list.
/// This is a synonym of the external cash clearing system code list, extended outside the pure cash domains.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalMarketInfrastructure1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8MlMg6MgEeCJ6YNENx4h-w_-216754992")]
public partial class ExternalMarketInfrastructure1CodeDropdownSource : EnumMetadataManager<ExternalMarketInfrastructure1Code,IExternalMarketInfrastructure1CodeDropdownRow,ExternalMarketInfrastructure1CodeDropdownRow>
{
    public ExternalMarketInfrastructure1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalMarketInfrastructure1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
