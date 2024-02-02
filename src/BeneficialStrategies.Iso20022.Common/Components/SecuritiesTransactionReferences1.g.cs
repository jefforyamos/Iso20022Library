﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesTransactionReferences1.  ISO2002 ID# _nhSfkZoSEeeGTuCFfgzOFw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying securities transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record SecuritiesTransactionReferences1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the securities transaction as known by the securities account owner (or the instructing party managing the account).
    /// </summary>
    [DataMember]
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the securities transaction as known by the securities account servicer.
    /// </summary>
    [DataMember]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of a securities transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [DataMember]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the securities transaction assigned by the processor of the instruction other than the securities account owner, the securities account servicer and the market infrastructure.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    
    #nullable disable
}
