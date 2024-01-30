﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for GeneralBusiness.  ISO2002 ID# _Q2Ivw3hdEeidzqjNEfehPg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GeneralBusinessOrError8Choice;

/// <summary>
/// Requested business information.
/// </summary>
public partial record GeneralBusiness : IGeneralBusinessOrError8Choice
{
    #nullable enable
    /// <summary>
    /// Further information about the criticality or importance of a general business information system.
    /// </summary>
    public InformationQualifierType1? Qualifier { get; init; } 
    /// <summary>
    /// Subject line of an item of general business information, summarizing the topic and intended destination of the information.
    /// </summary>
    public IsoMax35Text? Subject { get; init; } 
    /// <summary>
    /// General business information, in unstructured form.
    /// </summary>
    public IsoMax350Text? SubjectDetails { get; init; } 
    #nullable disable
}
