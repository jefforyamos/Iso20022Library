﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction15.  ISO2002 ID# _iVYLIR0hEeK5OKMB21JFBg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction information in the cancellation request.
/// </summary>
[DataContract]
[XmlType]
public partial record CardPaymentTransaction15
{
    #nullable enable
    
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? TransactionCapture { get; init; } 
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [DataMember]
    public required IsoMin3Max4Text MerchantCategoryCode { get; init; } 
    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [DataMember]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [DataMember]
    public required CardPaymentTransaction17 OriginalTransaction { get; init; } 
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [DataMember]
    public required CardPaymentTransactionDetails5 TransactionDetails { get; init; } 
    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax70Text> AdditionalTransactionData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
