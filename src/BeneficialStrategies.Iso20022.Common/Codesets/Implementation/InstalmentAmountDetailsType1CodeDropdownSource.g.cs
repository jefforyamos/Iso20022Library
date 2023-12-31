﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InstalmentAmountDetailsType1Code.  ISO2002 ID# _KjGSMDEqEemzCpWiCwK4aQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the details of the grace period applicable to the instalment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInstalmentAmountDetailsType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KjGSMDEqEemzCpWiCwK4aQ")]
public partial class InstalmentAmountDetailsType1CodeDropdownSource : EnumMetadataManager<InstalmentAmountDetailsType1Code,IInstalmentAmountDetailsType1CodeDropdownRow,InstalmentAmountDetailsType1CodeDropdownRow>
{
    public InstalmentAmountDetailsType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InstalmentAmountDetailsType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
