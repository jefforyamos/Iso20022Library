﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionInformation1.  ISO2002 ID# _TdxFY9p-Ed-ak6NoX_4Aeg_1155832018.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the corporate action event.
/// </summary>
public partial record CorporateActionInformation1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the issuer agent.
    /// </summary>
    public required PartyIdentification2Choice_ AgentIdentification { get; init; } 
    /// <summary>
    /// Reference given to the event by the CA event issuer (agent).
    /// </summary>
    public IsoMax35Text? IssuerCorporateActionIdentification { get; init; } 
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public IsoMax35Text? CorporateActionProcessingIdentification { get; init; } 
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    public required CorporateActionEventType2FormatChoice_ EventType { get; init; } 
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    public required CorporateActionMandatoryVoluntary1FormatChoice_ MandatoryVoluntaryEventType { get; init; } 
    /// <summary>
    /// Type of processing involved by a Corporate Action.
    /// </summary>
    public CorporateActionEventProcessingType1FormatChoice_? EventProcessingType { get; init; } 
    /// <summary>
    /// Identification of the underlying financial instrument, ie, the financial instrument affected by the corporate action event.
    /// </summary>
    public required FinancialInstrumentDescription3 UnderlyingSecurity { get; init; } 
    
    #nullable disable
}
