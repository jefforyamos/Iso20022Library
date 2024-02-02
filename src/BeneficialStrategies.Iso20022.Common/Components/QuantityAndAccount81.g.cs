﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityAndAccount81.  ISO2002 ID# _ZwDjy9LCEeiN28wlpBQScw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on a quantity, account and other related information.
/// </summary>
[DataContract]
[XmlType]
public partial record QuantityAndAccount81
{
    #nullable enable
    
    /// <summary>
    /// Denomination of the security to be received or delivered.
    /// </summary>
    [DataMember]
    public IsoMax210Text? DenominationChoice { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [DataMember]
    public PartyIdentification144? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [DataMember]
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [DataMember]
    public SafeKeepingPlace3? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    [DataMember]
    public ValueList<QuantityBreakdown46> QuantityBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
