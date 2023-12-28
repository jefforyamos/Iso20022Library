﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReconciliationMessageType1Code.  ISO2002 ID# _CjGTwC7PEemIy6A-26wnAg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the reconciliation message type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CjGTwC7PEemIy6A-26wnAg")]
[Description(@"Contains the reconciliation message type.")]
[DerivedFrom(typeof(ReconciliationMessageTypeCode))]
public enum ReconciliationMessageType1Code
{
    /// <summary>
    /// Batch Transfer Response
    /// Encoded/decoded by serializers as "BatchTransferResponse".
    /// </summary>
    [EnumMember(Value = "BATR")]
    [IsoId("_IGu7cS7PEemIy6A-26wnAg")]
    [Description(@"Batch Transfer Response")]
    BatchTransferResponse,
    
    /// <summary>
    /// Card Management Initiation
    /// Encoded/decoded by serializers as "CardManagementInitiation".
    /// </summary>
    [EnumMember(Value = "CAMI")]
    [IsoId("_IXD2cS7PEemIy6A-26wnAg")]
    [Description(@"Card Management Initiation")]
    CardManagementInitiation,
    
    /// <summary>
    /// Card Management Response
    /// Encoded/decoded by serializers as "CardManagementResponse".
    /// </summary>
    [EnumMember(Value = "CAMR")]
    [IsoId("_IagMAS7PEemIy6A-26wnAg")]
    [Description(@"Card Management Response")]
    CardManagementResponse,
    
    /// <summary>
    /// Chargeback Initiation
    /// Encoded/decoded by serializers as "ChargebackInitiation".
    /// </summary>
    [EnumMember(Value = "CGBI")]
    [IsoId("_Id-WwS7PEemIy6A-26wnAg")]
    [Description(@"Chargeback Initiation")]
    ChargebackInitiation,
    
    /// <summary>
    /// Chargeback Response
    /// Encoded/decoded by serializers as "ChargebackResponse".
    /// </summary>
    [EnumMember(Value = "CGBR")]
    [IsoId("_IhZeMS7PEemIy6A-26wnAg")]
    [Description(@"Chargeback Response")]
    ChargebackResponse,
    
    /// <summary>
    /// Error
    /// Encoded/decoded by serializers as "Error".
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_Ik3o8S7PEemIy6A-26wnAg")]
    [Description(@"Error")]
    Error,
    
    /// <summary>
    /// Fee Collection Initiation
    /// Encoded/decoded by serializers as "FeeCollectionInitiation".
    /// </summary>
    [EnumMember(Value = "FECI")]
    [IsoId("_IowDYS7PEemIy6A-26wnAg")]
    [Description(@"Fee Collection Initiation")]
    FeeCollectionInitiation,
    
    /// <summary>
    /// Fee Collection Response
    /// Encoded/decoded by serializers as "FeeCollectionResponse".
    /// </summary>
    [EnumMember(Value = "FECR")]
    [IsoId("_IsQDUS7PEemIy6A-26wnAg")]
    [Description(@"Fee Collection Response")]
    FeeCollectionResponse,
    
    /// <summary>
    /// File Action Initiation
    /// Encoded/decoded by serializers as "FileActionInitiation".
    /// </summary>
    [EnumMember(Value = "FIAI")]
    [IsoId("_IvwDQS7PEemIy6A-26wnAg")]
    [Description(@"File Action Initiation")]
    FileActionInitiation,
    
    /// <summary>
    /// File Action Response
    /// Encoded/decoded by serializers as "FileActionResponse".
    /// </summary>
    [EnumMember(Value = "FIAR")]
    [IsoId("_IzfTwS7PEemIy6A-26wnAg")]
    [Description(@"File Action Response")]
    FileActionResponse,
    
    /// <summary>
    /// Financial Response
    /// Encoded/decoded by serializers as "FinancialResponse".
    /// </summary>
    [EnumMember(Value = "FINR")]
    [IsoId("_I9QTwS7PEemIy6A-26wnAg")]
    [Description(@"Financial Response")]
    FinancialResponse,
    
    /// <summary>
    /// Financial Initiation
    /// Encoded/decoded by serializers as "FinancialInitiation".
    /// </summary>
    [EnumMember(Value = "FINI")]
    [IsoId("_JOZuIS7PEemIy6A-26wnAg")]
    [Description(@"Financial Initiation")]
    FinancialInitiation,
    
    /// <summary>
    /// Fraud Disposition Initiation
    /// Encoded/decoded by serializers as "FraudDispositionInitiation".
    /// </summary>
    [EnumMember(Value = "FRDI")]
    [IsoId("_JeeKcS7PEemIy6A-26wnAg")]
    [Description(@"Fraud Disposition Initiation")]
    FraudDispositionInitiation,
    
    /// <summary>
    /// Fraud Disposition Response
    /// Encoded/decoded by serializers as "FraudDispositionResponse".
    /// </summary>
    [EnumMember(Value = "FRDR")]
    [IsoId("_JkbogS7PEemIy6A-26wnAg")]
    [Description(@"Fraud Disposition Response")]
    FraudDispositionResponse,
    
    /// <summary>
    /// Fraud Reporting Initiation
    /// Encoded/decoded by serializers as "FraudReportingInitiation".
    /// </summary>
    [EnumMember(Value = "FRRI")]
    [IsoId("_Jn-EsS7PEemIy6A-26wnAg")]
    [Description(@"Fraud Reporting Initiation")]
    FraudReportingInitiation,
    
    /// <summary>
    /// Fraud Reporting Response
    /// Encoded/decoded by serializers as "FraudReportingResponse".
    /// </summary>
    [EnumMember(Value = "FRRR")]
    [IsoId("_Jrw_kS7PEemIy6A-26wnAg")]
    [Description(@"Fraud Reporting Response")]
    FraudReportingResponse,
    
    /// <summary>
    /// Inquiry Initiation
    /// Encoded/decoded by serializers as "InquiryInitiation".
    /// </summary>
    [EnumMember(Value = "INQI")]
    [IsoId("_JvV4AS7PEemIy6A-26wnAg")]
    [Description(@"Inquiry Initiation")]
    InquiryInitiation,
    
    /// <summary>
    /// Inquiry Response
    /// Encoded/decoded by serializers as "InquiryResponse".
    /// </summary>
    [EnumMember(Value = "INQR")]
    [IsoId("_Jy3tIS7PEemIy6A-26wnAg")]
    [Description(@"Inquiry Response")]
    InquiryResponse,
    
    /// <summary>
    /// Key Exchange Initiation
    /// Encoded/decoded by serializers as "KeyExchangeInitiation".
    /// </summary>
    [EnumMember(Value = "KYEI")]
    [IsoId("_J9dMgS7PEemIy6A-26wnAg")]
    [Description(@"Key Exchange Initiation")]
    KeyExchangeInitiation,
    
    /// <summary>
    /// Key Exchange Response
    /// Encoded/decoded by serializers as "KeyExchangeResponse".
    /// </summary>
    [EnumMember(Value = "KYER")]
    [IsoId("_KBTKsS7PEemIy6A-26wnAg")]
    [Description(@"Key Exchange Response")]
    KeyExchangeResponse,
    
    /// <summary>
    /// Network Management Initiation.
    /// Encoded/decoded by serializers as "NetworkManagementInitiation".
    /// </summary>
    [EnumMember(Value = "NWMI")]
    [IsoId("_KEzKoS7PEemIy6A-26wnAg")]
    [Description(@"Network Management Initiation.")]
    NetworkManagementInitiation,
    
    /// <summary>
    /// Network Management Response
    /// Encoded/decoded by serializers as "NetworkManagementResponse".
    /// </summary>
    [EnumMember(Value = "NWMR")]
    [IsoId("_KKgxES7PEemIy6A-26wnAg")]
    [Description(@"Network Management Response")]
    NetworkManagementResponse,
    
    /// <summary>
    /// Reconciliation Initiation
    /// Encoded/decoded by serializers as "ReconciliationInitiation".
    /// </summary>
    [EnumMember(Value = "RECI")]
    [IsoId("_KOB_IS7PEemIy6A-26wnAg")]
    [Description(@"Reconciliation Initiation")]
    ReconciliationInitiation,
    
    /// <summary>
    /// Reconciliation Response
    /// Encoded/decoded by serializers as "ReconciliationResponse".
    /// </summary>
    [EnumMember(Value = "RECR")]
    [IsoId("_KRoswS7PEemIy6A-26wnAg")]
    [Description(@"Reconciliation Response")]
    ReconciliationResponse,
    
    /// <summary>
    /// Retrieval Fulfilment Initiation
    /// Encoded/decoded by serializers as "RetrievalFulfilmentInitiation".
    /// </summary>
    [EnumMember(Value = "RTFI")]
    [IsoId("_KZKRES7PEemIy6A-26wnAg")]
    [Description(@"Retrieval Fulfilment Initiation")]
    RetrievalFulfilmentInitiation,
    
    /// <summary>
    /// Retrieval Fulfilment Response
    /// Encoded/decoded by serializers as "RetrievalFulfilmentResponse".
    /// </summary>
    [EnumMember(Value = "RTFR")]
    [IsoId("_Kcyz4S7PEemIy6A-26wnAg")]
    [Description(@"Retrieval Fulfilment Response")]
    RetrievalFulfilmentResponse,
    
    /// <summary>
    /// Retrieval Request
    /// Encoded/decoded by serializers as "RetrievalRequest".
    /// </summary>
    [EnumMember(Value = "RTRR")]
    [IsoId("_KgUpAS7PEemIy6A-26wnAg")]
    [Description(@"Retrieval Request")]
    RetrievalRequest,
    
    /// <summary>
    /// Retrieval Response
    /// Encoded/decoded by serializers as "RetrievalResponse".
    /// </summary>
    [EnumMember(Value = "RTRI")]
    [IsoId("_Kjw-kS7PEemIy6A-26wnAg")]
    [Description(@"Retrieval Response")]
    RetrievalResponse,
    
    /// <summary>
    /// Reversal Initiation
    /// Encoded/decoded by serializers as "ReversalInitiation".
    /// </summary>
    [EnumMember(Value = "REVI")]
    [IsoId("_KnPJUS7PEemIy6A-26wnAg")]
    [Description(@"Reversal Initiation")]
    ReversalInitiation,
    
    /// <summary>
    /// Reversal Response
    /// Encoded/decoded by serializers as "ReversalResponse".
    /// </summary>
    [EnumMember(Value = "REVR")]
    [IsoId("_KrDSUS7PEemIy6A-26wnAg")]
    [Description(@"Reversal Response")]
    ReversalResponse,
    
    /// <summary>
    /// Settlement Reporting Initiation
    /// Encoded/decoded by serializers as "SettlementReportingInitiation".
    /// </summary>
    [EnumMember(Value = "SERI")]
    [IsoId("_KujSQS7PEemIy6A-26wnAg")]
    [Description(@"Settlement Reporting Initiation")]
    SettlementReportingInitiation,
    
    /// <summary>
    /// Settlement Reporting Response
    /// Encoded/decoded by serializers as "SettlementReportingResponse".
    /// </summary>
    [EnumMember(Value = "SERR")]
    [IsoId("_Kx_AwS7PEemIy6A-26wnAg")]
    [Description(@"Settlement Reporting Response")]
    SettlementReportingResponse,
    
    /// <summary>
    /// Verification Initiation.
    /// Encoded/decoded by serializers as "VerificationInitiation".
    /// </summary>
    [EnumMember(Value = "VERI")]
    [IsoId("_K1dLgS7PEemIy6A-26wnAg")]
    [Description(@"Verification Initiation.")]
    VerificationInitiation,
    
    /// <summary>
    /// Verification Response
    /// Encoded/decoded by serializers as "VerificationResponse".
    /// </summary>
    [EnumMember(Value = "VERR")]
    [IsoId("_LGM9QS7PEemIy6A-26wnAg")]
    [Description(@"Verification Response")]
    VerificationResponse,
    
    /// <summary>
    /// Amendment
    /// Encoded/decoded by serializers as "Amendment".
    /// </summary>
    [EnumMember(Value = "AMDT")]
    [IsoId("_HQVeoRqSEeqH1IQNpbVpEw")]
    [Description(@"Amendment")]
    Amendment,
    
    /// <summary>
    /// Authorisation Initiation
    /// Encoded/decoded by serializers as "AuthorisationInitiation".
    /// </summary>
    [EnumMember(Value = "ATHI")]
    [IsoId("_HXxjYRqSEeqH1IQNpbVpEw")]
    [Description(@"Authorisation Initiation")]
    AuthorisationInitiation,
    
    /// <summary>
    /// Authorisation Response
    /// Encoded/decoded by serializers as "AuthorisationResponse".
    /// </summary>
    [EnumMember(Value = "ATHR")]
    [IsoId("_HiovkRqSEeqH1IQNpbVpEw")]
    [Description(@"Authorisation Response")]
    AuthorisationResponse,
    
    /// <summary>
    /// Batch Management Initiation
    /// Encoded/decoded by serializers as "BatchManagementInitiation".
    /// </summary>
    [EnumMember(Value = "BAMI")]
    [IsoId("_HxN-IRqSEeqH1IQNpbVpEw")]
    [Description(@"Batch Management Initiation")]
    BatchManagementInitiation,
    
    /// <summary>
    /// Batch Management Response
    /// Encoded/decoded by serializers as "BatchManagementResponse".
    /// </summary>
    [EnumMember(Value = "BAMR")]
    [IsoId("_H-T-8RqSEeqH1IQNpbVpEw")]
    [Description(@"Batch Management Response")]
    BatchManagementResponse,
    
    /// <summary>
    /// Batch Transfer Initiation
    /// Encoded/decoded by serializers as "BatchTransferInitiation".
    /// </summary>
    [EnumMember(Value = "BATI")]
    [IsoId("_IJeGERqSEeqH1IQNpbVpEw")]
    [Description(@"Batch Transfer Initiation")]
    BatchTransferInitiation,
    
    /// <summary>
    /// Addendum initiation
    /// Encoded/decoded by serializers as "AddendumInitiation".
    /// </summary>
    [EnumMember(Value = "ADDI")]
    [IsoId("_mkVGARqSEeqH1IQNpbVpEw")]
    [Description(@"Addendum initiation")]
    AddendumInitiation,
    
    /// <summary>
    /// Addendum response
    /// Encoded/decoded by serializers as "AddendumResponse".
    /// </summary>
    [EnumMember(Value = "ADDR")]
    [IsoId("_mtZicRqSEeqH1IQNpbVpEw")]
    [Description(@"Addendum response")]
    AddendumResponse,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReconciliationMessageType1CodeMetadataExtensions
{
    private static readonly ReconciliationMessageType1CodeDropdownSource _dropdownSource = new ReconciliationMessageType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReconciliationMessageType1CodeDropdownRow GetMetadata(this ReconciliationMessageType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


