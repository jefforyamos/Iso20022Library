﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Cheque12.  ISO2002 ID# _AtvYwf8REemYYvJytExgzA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to a cheque instruction, such as cheque type or cheque number.
/// </summary>
[DataContract]
[XmlType]
public partial record Cheque12
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the cheque as assigned by the financial institution.
    /// </summary>
    [DataMember]
    public IsoMax35Text? Number { get; init; } 
    /// <summary>
    /// Party to which the cheque is made payable.
    /// </summary>
    [DataMember]
    public PartyIdentification139? PayeeIdentification { get; init; } 
    /// <summary>
    /// Financial institution on which the cheque is drawn, that is, the financial institution that services the account of the entity that issued the cheque.
    /// </summary>
    [DataMember]
    public FinancialInstitutionIdentification17? DraweeIdentification { get; init; } 
    /// <summary>
    /// Account owner that issues the cheque ordering the drawee bank to pay a specific amount, upon demand, to the payee.
    /// </summary>
    [DataMember]
    public PartyIdentification139? DrawerIdentification { get; init; } 
    
    #nullable disable
}
