﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BranchAndFinancialInstitutionIdentification.  ISO2002 ID# _TFnrI9p-Ed-ak6NoX_4Aeg_-701861729.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organisation established primarily to provide financial services.
/// </summary>
[DataContract]
[XmlType]
public partial record BranchAndFinancialInstitutionIdentification
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [DataMember]
    public required FinancialInstitutionIdentification1 FinancialInstitutionIdentification { get; init; } 
    /// <summary>
    /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    [DataMember]
    public BranchData? BranchIdentification { get; init; } 
    
    #nullable disable
}
