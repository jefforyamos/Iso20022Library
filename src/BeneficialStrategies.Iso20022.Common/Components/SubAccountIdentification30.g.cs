﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubAccountIdentification30.  ISO2002 ID# _UGnzYQ3sEeKIIIcS0K4sAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sub-account reporting.
/// </summary>
[DataContract]
[XmlType]
public partial record SubAccountIdentification30
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [DataMember]
    public PartyIdentification36Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [DataMember]
    public required SecuritiesAccount14 SafekeepingAccount { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [DataMember]
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Reporting per financial instrument.
    /// </summary>
    [DataMember]
    public ValueList<FinancialInstrumentDetails13> FinancialInstrumentDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
