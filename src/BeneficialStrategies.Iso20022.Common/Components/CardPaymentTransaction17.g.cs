﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction17.  ISO2002 ID# _i8u0IR0jEeK5OKMB21JFBg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the original transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record CardPaymentTransaction17
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [DataMember]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [DataMember]
    public GenericIdentification32? POIIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    [DataMember]
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    [DataMember]
    public IsoMax35Text? RecipientTransactionIdentification { get; init; } 
    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    [DataMember]
    public required CardPaymentServiceType4Code TransactionType { get; init; } 
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [DataMember]
    public ValueList<CardPaymentServiceType2Code> AdditionalService { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [DataMember]
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; } 
    /// <summary>
    /// Result of the original transaction.
    /// </summary>
    [DataMember]
    public CardPaymentTransactionResult1? TransactionResult { get; init; } 
    
    #nullable disable
}
