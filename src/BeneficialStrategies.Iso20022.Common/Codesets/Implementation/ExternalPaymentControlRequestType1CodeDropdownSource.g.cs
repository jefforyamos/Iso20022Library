﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalPaymentControlRequestType1Code.  ISO2002 ID# _EJVeUJIhEeect698_YsnIA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external request type code for a payment control command in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalPaymentControlRequestType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EJVeUJIhEeect698_YsnIA")]
public partial class ExternalPaymentControlRequestType1CodeDropdownSource : EnumMetadataManager<ExternalPaymentControlRequestType1Code,IExternalPaymentControlRequestType1CodeDropdownRow,ExternalPaymentControlRequestType1CodeDropdownRow>
{
    public ExternalPaymentControlRequestType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalPaymentControlRequestType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
