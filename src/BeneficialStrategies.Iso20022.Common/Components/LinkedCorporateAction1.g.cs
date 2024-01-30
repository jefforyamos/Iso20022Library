﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LinkedCorporateAction1.  ISO2002 ID# _RjH9pNp-Ed-ak6NoX_4Aeg_866442593.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies linkage information of a corporate action message.
/// </summary>
public partial record LinkedCorporateAction1
{
    #nullable enable
    
    /// <summary>
    /// The function of the notification e.g. new notification.
    /// </summary>
    public required CorporateActionNotificationType1Code NotificationType { get; init; } 
    /// <summary>
    /// The identification of the linked notification advice.
    /// </summary>
    public DocumentIdentification8? LinkedAgentCANotificationAdviceIdentification { get; init; } 
    /// <summary>
    /// Specifies when the instruction is to be executed relative to a linked instruction.
    /// </summary>
    public IProcessingPosition2FormatChoice? LinkageType { get; init; } 
    /// <summary>
    /// Reference given to the linked event by the CA event issuer (agent).
    /// </summary>
    public IsoMax35Text? LinkedIssuerCorporateActionIdentification { get; init; } 
    /// <summary>
    /// Reference assigned by the CSD to the linked coporate avent.
    /// </summary>
    public IsoMax35Text? LinkedCorporateActionProcessingIdentification { get; init; } 
    
    #nullable disable
}
